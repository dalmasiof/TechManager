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
        probDto dto = new probDto();

        public frmAdvertenciaProf()
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
                ListDto = new advertenciaBLL().listarProb();
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
    }
}
