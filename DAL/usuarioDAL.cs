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
            catch(Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexao.Close();
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
    }
}
