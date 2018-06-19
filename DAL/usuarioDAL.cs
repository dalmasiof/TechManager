using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAL
{
    public class usuarioDAL
    {
        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();

        public void novoUsuario(usuarioDTO dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("insert into tb_usuario(nome,rg,login,senha,email,tipoUsu) values(@Nome,@Rg,@Login,@Senha,@Email,@Tipousu)")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = dtovar.nome;
                sql.Parameters.Add("@Rg", MySqlDbType.VarChar).Value = dtovar.rg;
                sql.Parameters.Add("@Login", MySqlDbType.VarChar).Value = dtovar.login;
                sql.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = dtovar.senha;
                sql.Parameters.Add("@Email", MySqlDbType.VarChar).Value = dtovar.email;
                sql.Parameters.Add("@Tipousu", MySqlDbType.VarChar).Value = dtovar.tipo;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexao.Close();
            }
        }

        public List<usuarioDTO> lista()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
               
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from tb_usuario";
                comando.Connection = conexao;

                
                List<usuarioDTO> lista = new List<usuarioDTO>();

                conexao.Open();
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        usuarioDTO dTO = new usuarioDTO();


                        dTO.login = Convert.ToString(dr["login"]);
                        dTO.senha = Convert.ToString(dr["senha"]);

                        dTO.id = Convert.ToInt32(dr["idUsuario"]);
                        dTO.tipo = Convert.ToInt32(dr["tipoUsu"]);
                        dTO.email = Convert.ToString(dr["email"]);

                        dTO.nome = Convert.ToString(dr["nome"]);
                        dTO.rg = Convert.ToString(dr["rg"]);



                        lista.Add(dTO);
                    }

                }
                return lista;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void alterarUsuario(usuarioDTO dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("update tb_usuario set login=@Login,senha=@Senha,email=@Email where idUsuario=@Id")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@Nome", MySqlDbType.VarChar).Value = dtovar.nome;
                sql.Parameters.Add("@Login", MySqlDbType.VarChar).Value = dtovar.login;
                sql.Parameters.Add("@Senha", MySqlDbType.VarChar).Value = dtovar.senha;
                sql.Parameters.Add("@Email", MySqlDbType.VarChar).Value = dtovar.email;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexao.Close();
            }
        }

        public void deletaUsuario(usuarioDTO dto)
        {
           
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conexao_sql;
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "delete from tb_usuario where idUsuario = @Idusu";

                comando.Connection = con;


                comando.Parameters.Add("@Idusu", MySqlDbType.Int32).Value = dto.id;

                con.Open();
                comando.ExecuteNonQuery();
            
        }
        public List<usuarioDTO> validar(usuarioDTO dto)
        {

            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from tb_usuario where login = @User and senha = @Pass";
                comando.Connection = conexao;

                comando.Parameters.Add("@User", MySqlDbType.VarChar).Value = dto.login;
                comando.Parameters.Add("@Pass", MySqlDbType.VarChar).Value = dto.senha;
                List<usuarioDTO> listaLogin = new List<usuarioDTO>();

                conexao.Open();
                MySqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        dto.login = Convert.ToString(dr["login"]);
                        dto.senha = Convert.ToString(dr["senha"]);

                        dto.id = Convert.ToInt32(dr["idUsuario"]);
                        dto.tipo = Convert.ToInt32(dr["tipoUsu"]);
                        dto.email = Convert.ToString(dr["email"]);

                        dto.nome = Convert.ToString(dr["nome"]);
                        dto.rg = Convert.ToString(dr["rg"]);

                        dto.foto = Convert.ToString(dr["foto"]);

                        listaLogin.Add(dto);
                    }

                }
                return listaLogin;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
