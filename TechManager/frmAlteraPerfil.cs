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
using System.Text.RegularExpressions;

namespace TechManager
{
    public partial class frmAlteraPerfil : Form
    {
        usuarioDTO dtovar = new usuarioDTO();
        usuarioBLL bll = new usuarioBLL();

        public frmAlteraPerfil()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (!verificaCampos())
            {
                return;
            }

            else
            {
                dtovar.id = information.id;
                dtovar.nome = txtNome.Text;
                dtovar.login = txtLogin.Text;
                dtovar.senha = txtSenha.Text;
                dtovar.email = txtEmail.Text;
                dtovar.aula = txtAula.Text;

                try
                {
                    bll.alterarUsuario(dtovar);
                    lblMensagem.Text = "Alterado com sucesso!";
                    limpaCampos();
                }
                catch (Exception er)
                {
                    throw er;
                }
            }
        }

        private bool verificaCampos()
        {
            string email = txtEmail.Text;
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txtNome.Text == "" || txtLogin.Text == "" || txtEmail.Text == "")
            {
                lblMensagem.Text = "Todos os campos devem ser preenchidos!";
                lblMensagem.ForeColor = Color.Red;
                txtNome.Focus();
                return false;
            }

            if (txtSenha.Text.Length < 7)
            {
                lblMensagem.Text = "Senha deve ter no mínimo 8 caracteres";
                lblMensagem.ForeColor = Color.Red;
                txtSenha.Focus();
                return false;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                lblMensagem.Text = "As senhas não coincidem!";
                lblMensagem.ForeColor = Color.Red;
                txtSenha.Focus();
                return false;
            }

            if (rg.IsMatch(email))
            {
                lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
                lblMensagem.ForeColor = Color.Green;
                txtEmail.Focus();
            }
            else
            {
                lblMensagem.Text = "Email Inválido!";
                lblMensagem.ForeColor = Color.Red;
                return false;
            }
            return true;
        }

        private void limpaCampos()
        {
            txtNome.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtConfirmarSenha.Text = null;
            txtEmail.Text = null;
            lblMensagem.ForeColor = Color.Black;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
        }

        private void frmAlteraPerfil_Load(object sender, EventArgs e)
        {
            if (information.tipo == 1)
            {
                pcbLogo.Image = Properties.Resources.prof;

            }
            else if (information.tipo == 2)
            {
                pcbLogo.Image = Properties.Resources.tec1;
                txtAula.Visible = false;
                lblAula.Visible = false;
            }
            else
            {
                pcbLogo.Image = Properties.Resources.adm;
                txtAula.Visible = false;
                lblAula.Visible = false;
            }
                lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcurarImagem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
