using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechManager
{
    public partial class frmAdmAlteraPerfil : Form
    {
        public frmAdmAlteraPerfil()
        {
            InitializeComponent();
        }

        private void frmAdmAlteraPerfil_Load(object sender, EventArgs e)
        {
            desativaCampos();
        }

        private void desativaCampos()
        {
            txtConfirmarSenha.Enabled = false;
            txtEmail.Enabled = false;
            txtLogin.Enabled = false;
            txtNome.Enabled = false;
            txtNomeFotoPerfil.Enabled = false;
            txtSenha.Enabled = false;
            cbbAcesso.Enabled = false;
            mktxtRG.Enabled = false;
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
