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
            frmAdvertenciaTecnico adv = new frmAdvertenciaTecnico();
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

            probDto dtoVar = new probDto();

            int sel = dgvProb.CurrentRow.Index;

            if (Convert.ToBoolean(dgvProb["check", sel].Value) == true)
            {
                dgvProb.CurrentRow.DefaultCellStyle.BackColor = Color.ForestGreen;
                dtoVar.Check = "1";
                dtoVar.idProb = Convert.ToInt32(dgvProb["id", sel].Value);
            }


            else
            {
                dgvProb.CurrentRow.DefaultCellStyle.BackColor = Color.Maroon;
                dtoVar.Check = "0";
                dtoVar.idProb = Convert.ToInt32(dgvProb["id", sel].Value);

            }
                try
                {
                    try
                    {
                        probBll bll = new probBll();
                        bll.alteraSituacao(dtoVar);
                        
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("" + erro);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

               

        }

        private void dgvProb_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
