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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString();
            lblNome.Text = usuarioDTO.Nome;
            
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdvertencia_Click(object sender, EventArgs e)
        {
            frmAdvertencia adv = new frmAdvertencia();
            adv.Show();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            //if(e.Equals)
            pictureBox1.Image = Properties.Resources.logoTCC1;
        }
    }
}
