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
    public class ProblemaDal
    {

        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();

        public List<probDto> carregaTudo()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from historico ";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        probDto dtovar = new probDto();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<probDto> carregaTec()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from problema";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        probDto dtovar = new probDto();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void cadProd(probDto dto)
        {
                MySqlConnection conexaoPro = new MySqlConnection();
            try
            {
                MySqlCommand comand = new MySqlCommand("inserir");
                conexaoPro.ConnectionString = conexao_sql;

                comand.CommandType = System.Data.CommandType.StoredProcedure;
                comand.Connection = conexaoPro;
                conexaoPro.Open();


                comand.Parameters.Add("@Aaula", MySqlDbType.VarChar).Value = dto.aula;
                comand.Parameters.Add("@Aprofessor", MySqlDbType.VarChar).Value = dto.professor;
                comand.Parameters.Add("@AidMaquina", MySqlDbType.VarChar).Value = dto.idMaquina;
                comand.Parameters.Add("@Aproblema", MySqlDbType.VarChar).Value = dto.problema;
                comand.Parameters.Add("@AdataProb", MySqlDbType.DateTime).Value = System.DateTime.Now;
                
                
                
                

                comand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexaoPro.Close();
            }
        }

        public void alteraProb(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("update problema set idMaquina = @idM,problema = @prob where idProb = @id")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@idM", MySqlDbType.VarChar).Value = dtovar.idMaquina;
                sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dtovar.idProb;
                sql.Parameters.Add("@prob", MySqlDbType.VarChar).Value = dtovar.problema;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }
        public void deletaProb(probDto dto)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("delete from problema where idProb = @id")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dto.idProb;
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<probDto> carregaPorData()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema order by dataProb";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


               
               
                    while (dr.Read())
                    {
                        probDto dtovar = new probDto();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);


                    listProbDto.Add(dtovar);


                    }
               
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
        public List<probDto> carregaPorDataNova()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema order by dataProb desc";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();




                while (dr.Read())
                {
                    probDto dtovar = new probDto();

                    dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                    dtovar.problema = Convert.ToString(dr["problema"]);
                    dtovar.aula = Convert.ToString(dr["aula"]);
                    dtovar.professor = Convert.ToString(dr["professor"]);
                    dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                    dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                    dtovar.Check = Convert.ToString(dr["resolvido"]);


                    listProbDto.Add(dtovar);


                }

                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<probDto> carregaPorProfessor(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema WHERE CONCAT(professor) LIKE '%" + dtovar.professor + "%'";
                comando.Connection = conexao;

                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);


                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public List<probDto> carregaPorId(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema WHERE CONCAT(idmaquina) LIKE '%" + dtovar.idMaquina + "%';";
                comando.Connection = conexao;


                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void alteraSituacao(probDto dtoVar)
        {
            MySqlConnection conexaoPro = new MySqlConnection();
            try
            {
                conexaoPro = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("alterar")
                {
                    Connection = conexaoPro
                };
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.Parameters.Add("@Vresolvido", MySqlDbType.VarChar).Value = dtoVar.Check;
                sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dtoVar.idProb;
                conexaoPro.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                conexaoPro.Close();
            }
        }
        public List<probDto> notifica(probDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM problema";
                comando.Connection = conexao;


                List<probDto> listProbDto = new List<probDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        dtovar.noti = Convert.ToInt32(dr["COUNT(*)"]);
                        

                        listProbDto.Add(dtovar);


                    }
                }
                return listProbDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
