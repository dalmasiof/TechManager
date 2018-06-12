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
    public partial class frmPerfilTec : Form
    {
        public frmPerfilTec()
        {
            InitializeComponent();
        }
        probBll bll = new probBll();
        probDto dto = new probDto();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilTec_Load(object sender, EventArgs e)
        {
            lblNome.Text = Convert.ToString(information.nome);
            pcbFotoTec.ImageLocation = information.foto;
            notifyIcon1.Visible = false;
            ////btnErro.Iconimage_right = Properties.Resources.;

            //try
            //{
            //    List<probDto> ListDto = new List<probDto>();
            //    ListDto = new probBll().listarProb();

            //}
            //catch (Exception erro)
            //{
            //    throw erro;
            //}
            //if(dto.check == 0)
            //{

            //}

        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaProf adv = new frmAdvertenciaProf();
            adv.Show();
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            frmProblemaTec prob = new frmProblemaTec();
            prob.ShowDialog();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
