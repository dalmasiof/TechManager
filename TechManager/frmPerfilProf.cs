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
    public partial class frmPerfilProf : Form
    {
        usuarioDTO dtovar = new usuarioDTO();

        public frmPerfilProf()
        {
            InitializeComponent();
        }

        private void frmPerfilProf_Load(object sender, EventArgs e)
        {
            lblNome.Text = dtovar.nome;
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            frmProblema prob = new frmProblema();
            prob.ShowDialog();
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            frmAdvertenciaProf adv = new frmAdvertenciaProf();
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
            historico.ShowDialog();
        }
    }
}
