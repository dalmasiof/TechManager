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
    public partial class frmPerfilTec : Form
    {
        public frmPerfilTec(int idLogon, string nomeLogon)
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilTec_Load(object sender, EventArgs e)
        {
            lblNome.Text = Convert.ToString(information.nome);
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaProf adv = new frmAdvertenciaProf();
            adv.Show();
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            frmProblemaTec prob = new frmProblemaTec();
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            frmHistorico historico = new frmHistorico();
            historico.Show();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

       

        private void notifyIcon1_MouseClick_1(object sender, MouseEventArgs e)
        {

            this.Show();
            notifyIcon1.Visible = false;
        }
    }
}
