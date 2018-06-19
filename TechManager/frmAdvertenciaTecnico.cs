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
        probDto dto = new probDto();

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

        }

        private void dataGridAdvert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridAdvert.CurrentRow.Index;

            lblAdvertencia.Text = Convert.ToString(dataGridAdvert["advertencia", sel].Value);
            txtJustificativa.Enabled = true;
            txtJustificativa.Focus();
            btnEnviar.Enabled = true;
        }
    }
}
