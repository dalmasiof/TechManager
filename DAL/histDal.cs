using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class histDal
    {
        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();

        public List<histDto> carregaTudo()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM historico LEFT JOIN ADVERTENCIA ON ADVERTENCIA.idprob = historico.idprob";
                comando.Connection = conexao;

                List<histDto> listHistDto = new List<histDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();


                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        histDto dtovar = new histDto();

                        dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                        dtovar.problema = Convert.ToString(dr["problema"]);
                        dtovar.aula = Convert.ToString(dr["aula"]);
                        dtovar.professor = Convert.ToString(dr["professor"]);
                        dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                        dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                        dtovar.Check = Convert.ToString(dr["resolvido"]);
                        dtovar.advertencia = Convert.ToString(dr["advertencia"]);
                        dtovar.justificativa = Convert.ToString(dr["justificativa"]);

                        listHistDto.Add(dtovar);


                    }
                }
                return listHistDto;


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

        public List<histDto> carregaDataAtual()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM historico LEFT JOIN ADVERTENCIA ON ADVERTENCIA.idprob = historico.idprob order by dataProb desc";
                comando.Connection = conexao;

                List<histDto> listProbDto = new List<histDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();




                while (dr.Read())
                {
                    histDto dtovar = new histDto();

                    dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                    dtovar.problema = Convert.ToString(dr["problema"]);
                    dtovar.aula = Convert.ToString(dr["aula"]);
                    dtovar.professor = Convert.ToString(dr["professor"]);
                    dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                    dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                    dtovar.Check = Convert.ToString(dr["resolvido"]);
                    dtovar.advertencia = Convert.ToString(dr["advertencia"]);
                    dtovar.justificativa = Convert.ToString(dr["justificativa"]);


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

        public List<histDto> carregaDataAntiga()
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM historico LEFT JOIN ADVERTENCIA ON ADVERTENCIA.idprob = historico.idprob order by dataProb";
                comando.Connection = conexao;

                List<histDto> listProbDto = new List<histDto>();
                conexao.Open();

                MySqlDataReader dr = comando.ExecuteReader();




                while (dr.Read())
                {
                    histDto dtovar = new histDto();

                    dtovar.idProb = Convert.ToInt32(dr["idProb"]);
                    dtovar.problema = Convert.ToString(dr["problema"]);
                    dtovar.aula = Convert.ToString(dr["aula"]);
                    dtovar.professor = Convert.ToString(dr["professor"]);
                    dtovar.data = Convert.ToDateTime(dr["dataProb"]);
                    dtovar.idMaquina = Convert.ToString(dr["idMaquina"]);
                    dtovar.Check = Convert.ToString(dr["resolvido"]);
                    dtovar.advertencia = Convert.ToString(dr["advertencia"]);
                    dtovar.justificativa = Convert.ToString(dr["justificativa"]);


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

        public List<histDto> carregaProf(histDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM HISTORICO LEFT JOIN ADVERTENCIA ON ADVERTENCIA.idprob = historico.idprob WHERE CONCAT(professor) LIKE '%" + dtovar.professor + "%'";
                comando.Connection = conexao;

                List<histDto> listProbDto = new List<histDto>();
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
                        dtovar.advertencia = Convert.ToString(dr["advertencia"]);
                        dtovar.justificativa = Convert.ToString(dr["justificativa"]);


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

        public List<histDto> carregaId(histDto dtovar)
        {
            try
            {
                conexao = new MySqlConnection(conexao_sql);
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM historico LEFT JOIN ADVERTENCIA ON ADVERTENCIA.idprob = historico.idprob WHERE CONCAT(idmaquina) LIKE '%" + dtovar.idMaquina+"%';";
                comando.Connection = conexao;

                

                List<histDto> listProbDto = new List<histDto>();
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
                        dtovar.advertencia = Convert.ToString(dr["advertencia"]);
                        dtovar.justificativa = Convert.ToString(dr["justificativa"]);

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
    }
}
