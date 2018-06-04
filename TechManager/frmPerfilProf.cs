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
    public partial class frmPerfilProf : Form
    {
        
        public frmPerfilProf(int idLogon, string nomeLogon)
        {
            string nome = nomeLogon;
            int id = idLogon;    

            InitializeComponent();
        }



        private void frmPerfilProf_Load(object sender, EventArgs e)
        {

            notifyIcon1.Visible = false;
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            frmProblemaProf prob = new frmProblemaProf();
            prob.ShowDialog();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaTecnico adv = new frmAdvertenciaTecnico();
            adv.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbFotoProf_Click(object sender, EventArgs e)
        {
            frmAlteraPerfil alteraPerfil = new frmAlteraPerfil();
            alteraPerfil.ShowDialog();
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

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        
    }
}
