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
    public partial class frmPerfilAdm : Form
    {
        public frmPerfilAdm()
        {
            InitializeComponent();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        usuarioDTO dtovar = new usuarioDTO();

        private void frmPerfilAdm_Load(object sender, EventArgs e)
        {
            lblNome.Text = information.nome;
            notifyIcon1.Visible = false;
            pcbFotoProf.ImageLocation = information.foto;
        }

        

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            frmCadastrar cad = new frmCadastrar();
            cad.ShowDialog();
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            frmAdmAlteraPerfil altera = new frmAdmAlteraPerfil();
            altera.ShowDialog();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void frmPerfilAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            frmAdmExcluiPerfil exclui = new frmAdmExcluiPerfil();
            exclui.Show();
        }
    }
}
