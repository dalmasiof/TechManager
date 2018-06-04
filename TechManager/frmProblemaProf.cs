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

namespace TechManager
{
    public partial class frmProblemaProf : Form
    {
        usuarioDTO dtovar = new usuarioDTO();
        public frmProblemaProf()
        {
            InitializeComponent();
        }

        private void frmProblema_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
            lblNome.Text = dtovar.nome ;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaProf adv = new frmAdvertenciaProf();
            adv.ShowDialog();
        }
    }
}
