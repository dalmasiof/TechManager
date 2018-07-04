using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace TechManager
{
    public partial class frmJustificativaAoProf : Form
    {
        advertenciaDTO dtovar = new advertenciaDTO();
        advertenciaBLL bll = new advertenciaBLL();

        public frmJustificativaAoProf()
        {
            InitializeComponent();
        }

        private void frmJustificativaAoProf_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void carregaGrid()
        {
            dataGridProb.AutoGenerateColumns = false;
            try
            {
                List<advertenciaDTO> ListDto = new List<advertenciaDTO>();
                ListDto = new advertenciaBLL().listarProbProTec();
                dataGridProb.DataSource = ListDto;

                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridProb.DataSource];
                cm.EndCurrentEdit();
                cm.ResumeBinding();
                cm.SuspendBinding();

                foreach (DataGridViewRow row in dataGridProb.Rows)
                {

                    if (Convert.ToString(row.Cells["advertido"].Value) == "")
                    {
                        row.Visible = true;

                    }

                    else
                    {
                        row.Visible = false;


                    }


                }


            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha na conexão com o banco de dados, favor entrar em contato com o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridProb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridProb.CurrentRow.Index;

            lblJustificativa.Text = "Justificativa:     " + Convert.ToString(dataGridProb["justificativa", sel].Value);
        }
    }
}
