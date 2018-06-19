using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class advertenciaDAL
    {
        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();

        public List<advertenciaDTO> carregaTudoPraJustificar()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema INNER JOIN ADVERTENCIA ON ADVERTENCIA.idprob = problema.idprob";
                comando.Connection = conexao;

                List<advertenciaDTO> listAdvertenciaDto = new List<advertenciaDTO>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        advertenciaDTO dtovar = new advertenciaDTO();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);
                        dtovar.justificativa = Convert.ToString(dr["justificativa"]);
                        dtovar.advertencia = Convert.ToString(dr["advertencia"]);

                        listAdvertenciaDto.Add(dtovar);


                    }
                }
                return listAdvertenciaDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public List<advertenciaDTO> carregaTudoPraAdvertencia()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM problema";
                comando.Connection = conexao;

                List<advertenciaDTO> listAdvertenciaDto = new List<advertenciaDTO>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        advertenciaDTO dtovar = new advertenciaDTO();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);
                        dtovar.advertencia = Convert.ToString(dr["advertencia"]);

                        listAdvertenciaDto.Add(dtovar);


                    }
                }
                return listAdvertenciaDto;


            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void novaAdvertencia(advertenciaDTO dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand sql = new MySqlCommand("insert into advertencia(idprob,advertencia) values(@IdProblema,@Advertencia)")
                {
                    Connection = conexao
                };
                sql.Parameters.Add("@IdProblema", MySqlDbType.Int32).Value = dtovar.idProb;
                sql.Parameters.Add("@Advertencia", MySqlDbType.VarChar).Value = dtovar.advertencia;
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
