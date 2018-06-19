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
    public partial class frmAdvertenciaProf : Form
    {
        int registro;

        advertenciaDTO dtovar = new advertenciaDTO();
        advertenciaBLL bll = new advertenciaBLL();

        public frmAdvertenciaProf()
        {
            InitializeComponent();
        }

        private void frmAdvertenciaTecnico_Load(object sender, EventArgs e)
        {
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
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        private void dataGridProb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridProb.CurrentRow.Index;

            registro = Convert.ToInt32(dataGridProb["idProb", sel].Value);

            lblMensagem.Text = "Relate a Advertencia e clique no botão Enviar!";
            lblMensagem.ForeColor = Color.Red;

            txtAdvert.Clear();
            txtAdvert.ForeColor = Color.Black;
            txtAdvert.Focus();
        }

        private void txtAdvert_TextChanged(object sender, EventArgs e)
        {
            if(txtAdvert.Text == "")
            {
                lblMensagem.Text = "A advertencia não pode estar vazia!";
                lblMensagem.ForeColor = Color.Red;
                btnEnviar.Enabled = false;
            }

            else
            {
                lblMensagem.Text = "Envie sua advertencia clicando no botão Enviar!";
                lblMensagem.ForeColor = Color.Green;
                btnEnviar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAdvert.Text = "Escreva sua advertencia aqui!";
            txtAdvert.ForeColor = Color.Gray;

            lblMensagem.Text = "";

            lblMensagem.Text = "Selecione um problema para mandar uma Advertencia, e depois clique no botão enviar!";
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
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
