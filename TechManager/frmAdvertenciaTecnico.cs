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
    public partial class frmAdvertenciaTecnico : Form
    {
        advertenciaDTO dtovar = new advertenciaDTO();
        advertenciaBLL bll = new advertenciaBLL();
        int registro;

        public frmAdvertenciaTecnico()
        {
            InitializeComponent();
        }

        private void frmAdvertencia_Load(object sender, EventArgs e)
        {
            pcbProfessor.ImageLocation = information.foto;
            lblNome.Text = information.nome;
            carregaGrid();
        }

        private void carregaGrid()
        {
            dataGridAdvert.AutoGenerateColumns = false;
            try
            {
                List<advertenciaDTO> ListDto = new List<advertenciaDTO>();
                ListDto = new advertenciaBLL().listarProbProTec();
                dataGridAdvert.DataSource = ListDto;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            dtovar.idAdv = registro;
            dtovar.justificativa = txtJustificativa.Text;
            dtovar.nomeTec = lblNome.Text;

            try
            {
                bll.novaJustificativa(dtovar);
                lblMensagem.ForeColor = Color.Green;

                txtJustificativa.Text = "Escreva sua Justificativa aqui!";
                txtJustificativa.ForeColor = Color.Gray;

                btnEnviar.Enabled = false;

                lblMensagem.Text = "Justificativa enviada ao professor, selecione uma nova advertencia caso queira justificar!";
                lblAdvertencia.Text = "Advertencia:    ";
            }

            catch
            {
                lblMensagem.Text = "Ocorreu um erro, por favor contatar a equipe Visus!";
            }
        }

        private void dataGridAdvert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridAdvert.CurrentRow.Index;

            registro = Convert.ToInt32(dataGridAdvert["idAdv", sel].Value);

            lblAdvertencia.Text = "Advertencia:    "+Convert.ToString(dataGridAdvert["advertencia", sel].Value);
            txtJustificativa.Enabled = true;
            txtJustificativa.Clear();
            txtJustificativa.ForeColor = Color.Black;
            txtJustificativa.Focus();
            btnEnviar.Enabled = true;
        }

        private void txtJustificativa_TextChanged(object sender, EventArgs e)
        {
            if (txtJustificativa.Text == "")
            {
                lblMensagem.Text = "A justificativa não pode estar vazia!";
                lblMensagem.ForeColor = Color.Red;
                btnEnviar.Enabled = false;
            }

            else
            {
                lblMensagem.Text = "Envie sua justificativa clicando no botão Enviar!";
                lblMensagem.ForeColor = Color.Green;
                btnEnviar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtJustificativa.Text = "Escreva sua advertencia aqui!";
            txtJustificativa.Enabled = false;
            txtJustificativa.ForeColor = Color.Gray;

            lblMensagem.Text = "";

            lblMensagem.Text = "Selecione um problema para mandar uma Justificativa, e depois clique no botão enviar!";
            lblMensagem.ForeColor = Color.Red;

            btnEnviar.Enabled = false;

            registro = -1;
        }
    }
}
