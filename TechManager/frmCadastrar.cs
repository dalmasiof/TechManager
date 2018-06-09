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
    public partial class frmCadastrar : Form
    {
        usuarioDTO dtovar = new usuarioDTO();
        usuarioBLL bll = new usuarioBLL();
        char acesso;

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (cbbAcesso.Text == "Professor")
            {
                acesso = '1';
            }
            else
            {
                acesso = '0';
            }

            if(!verificaCampos())
            {
                return;
            }
            
            else
            {
                dtovar.nome = txtNome.Text;
                dtovar.rg = mktxtRG.Text;
                dtovar.login = txtLogin.Text;
                dtovar.senha = txtSenha.Text;
                dtovar.email = txtEmail.Text;
                dtovar.tipo = acesso;

                try
                {
                    bll.novoUsuario(dtovar);
                    lblMensagem.Text = "Cadastrado com sucesso!";
                }
                catch (Exception er)
                {
                    throw er;
                }
            }
            limpaCampos();
            lblMensagem.ForeColor = Color.Green;
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
            cbbAcesso.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
        }

        private bool verificaCampos()
        {
            string email = txtEmail.Text;
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txtNome.Text == "" || txtLogin.Text == "" || txtEmail.Text == "" || mktxtRG.Text == "")
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
            txtEmail.Text = null;
            txtConfirmarSenha = null;
            mktxtRG.Text = null;
            cbbAcesso.SelectedIndex = 0;
            lblMensagem.ForeColor = Color.Black;
        }

        private void btnProcurarFoto_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialogo = new OpenFileDialog();




            dialogo.Title = "Procurar arquivos no computador";


            dialogo.InitialDirectory = @"C:\";



            dialogo.Filter = "Imagens (*.png)|*.png|Todos os arquivos (*.*)|*.*";




            DialogResult resposta = dialogo.ShowDialog();




            if (resposta == DialogResult.OK)

            {

                string caminhoCompleto = dialogo.FileName;
                txtNomeFotoPerfil.Text = caminhoCompleto;
                pcbFoto.Image = null;
                pcbFoto.ImageLocation = caminhoCompleto;

            }
        }
    }
}
