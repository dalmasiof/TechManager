using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using MySql.Data.MySqlClient;

namespace TechManager
{
    public partial class frmProblemaTec : Form
    {
        public frmProblemaTec()
        {
            InitializeComponent();
        }
        probBll bll = new probBll();
        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        MySqlConnection conexao = null;
        MySqlCommand comando = new MySqlCommand();

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaProf adv = new frmAdvertenciaProf();
            adv.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProblemaTec_Load(object sender, EventArgs e)
        {
            dgvProb.AutoGenerateColumns = false;
            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().listarProb();
                dgvProb.DataSource = ListDto;
            }
            catch (Exception erro)
            {
                throw erro;
            }

            
        }

        

        

       

       

        private void dgvProb_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            probDto dto = new probDto();

            int sel = dgvProb.CurrentRow.Index;

            if (Convert.ToBoolean(dgvProb["check", sel].Value) == true)
            {
                dgvProb.CurrentRow.DefaultCellStyle.BackColor = Color.ForestGreen;
                dto.Check = 1;
                dto.idProb = Convert.ToInt32(dgvProb["check", sel].Value);

                {
                    try
                    {
                        conexao = new MySqlConnection(conexao_sql);
                        MySqlCommand sql = new MySqlCommand("update problema set resolvido = @check where idprob = @id")
                        {
                            Connection = conexao
                        };
                        sql.Parameters.Add("@check", MySqlDbType.Int32).Value = dto.Check;
                        sql.Parameters.Add("@id", MySqlDbType.VarChar).Value = dto.idProb;


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
            else
            {
                dgvProb.CurrentRow.DefaultCellStyle.BackColor = Color.Maroon;
                dto.Check = 0;
                dto.idProb = Convert.ToInt32(dgvProb["check", sel].Value);

                try
                {
                    conexao = new MySqlConnection(conexao_sql);
                    MySqlCommand sql = new MySqlCommand("update problema set resolvido = @check where idprob = @id")
                    {
                        Connection = conexao
                    };
                    sql.Parameters.Add("@check", MySqlDbType.Int32).Value = dto.Check;
                    sql.Parameters.Add("@id", MySqlDbType.Int32).Value = dto.idProb;


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
}
