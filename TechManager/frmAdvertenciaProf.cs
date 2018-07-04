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
    public partial class frmJustificativaProf : Form
    {
        int registro;

        advertenciaDTO dtovar = new advertenciaDTO();
        advertenciaBLL bll = new advertenciaBLL();

        public frmJustificativaProf()
        {
            InitializeComponent();
        }

        private void frmAdvertenciaTecnico_Load(object sender, EventArgs e)
        {
            txtAdvert.Enabled = false;
            pcbProfessor.ImageLocation = information.foto;
            lblNome.Text = information.nome;
            carregaGrid();
        }

        private void carregaGrid()
        {
            dataGridProb.AutoGenerateColumns = false;
            try
            {
                List<advertenciaDTO> ListDto = new List<advertenciaDTO>();
                ListDto = new advertenciaBLL().listarProbProProf();
                dataGridProb.DataSource = ListDto;

                CurrencyManager cm = (CurrencyManager)BindingContext[dataGridProb.DataSource];
                cm.EndCurrentEdit();
                cm.ResumeBinding();
                cm.SuspendBinding();

                foreach (DataGridViewRow row in dataGridProb.Rows)
                {

                    if (Convert.ToString(row.Cells["justificativa"].Value) != "")
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

            registro = Convert.ToInt32(dataGridProb["idProb", sel].Value);

            lblMensagem.Text = "Relate o aviso e clique no botão Enviar!";
            lblMensagem.ForeColor = Color.Red;

            txtAdvert.Clear();
            txtAdvert.ForeColor = Color.Black;
            txtAdvert.Enabled = true;
            txtAdvert.Focus();
        }

        private void txtAdvert_TextChanged(object sender, EventArgs e)
        {
            if(txtAdvert.Text == "")
            {
                lblMensagem.Text = "O aviso não pode estar vazio!";
                lblMensagem.ForeColor = Color.Red;
                btnEnviar.Enabled = false;
            }

            else
            {
                lblMensagem.Text = "Envie seu aviso clicando no botão Enviar!";
                lblMensagem.ForeColor = Color.Green;
                btnEnviar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAdvert.Text = "Selecione um problema na tabela acima";
            txtAdvert.ForeColor = Color.Gray;

            lblMensagem.Text = "";

            lblMensagem.Text = "Selecione um problema para mandar um aviso, e depois clique no botão enviar!";
            lblMensagem.ForeColor = Color.Red;

            btnEnviar.Enabled = false;

            registro = -1;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            dtovar.idProb = registro;
            dtovar.advertencia = txtAdvert.Text;

            try
            {
                bll.novaAdvertencia(dtovar);
                lblMensagem.ForeColor = Color.Green;

                txtAdvert.Text = "Selecione um problema na tabela acima";
                txtAdvert.ForeColor = Color.Gray;

                btnEnviar.Enabled = false;

                lblMensagem.Text = "Aviso enviado ao técnico, selecione um novo problema caso desejar enviar outro aviso!";
                txtAdvert.Enabled = false;

                carregaGrid();
            }

            catch
            {
                MessageBox.Show("Erro Inexperado, contate o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmJustificativaAoProf tela = new frmJustificativaAoProf();
            tela.Show();
            this.Close();

        }
    }
}
