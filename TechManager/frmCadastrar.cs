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
        int acesso;

        public frmCadastrar()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            if (!mktxtRG.MaskCompleted)
            {
                lblMensagem.Text = ("O campo CPF está incompleto.");
                lblMensagem.ForeColor = Color.Red;
                mktxtRG.BackColor = Color.Salmon;

                return;
            }
            else
            {
                if (Valida(mktxtRG.Text))
                {
                    lblMensagem.Text = ("");
                }
                else
                {
                    lblMensagem.Text = ("CPF inválido");
                    lblMensagem.ForeColor = Color.Red;
                    mktxtRG.BackColor = Color.Salmon;
                    mktxtRG.Focus();
                    return;
                }
            }
            if (!verificaCampos())
            {
                return;
            }
            
            else
            {
                if (cbbAcesso.Text == "Professor")
                {
                    acesso = 1;
                }
                else
                {
                    acesso = 2;
                }

                    dtovar.nome = txtNome.Text;
                    dtovar.rg = mktxtRG.Text;
                    dtovar.login = txtLogin.Text;
                    dtovar.senha = txtSenha.Text;
                    dtovar.email = txtEmail.Text;
                    dtovar.tipo = acesso;
                    dtovar.aula = txtAula.Text;

                try
                {
                    bll.novoUsuario(dtovar);
                    lblMensagem.Text = "Cadastrado com sucesso!";
                    txtNome.Focus();
                    limpaCampos();
                    lblMensagem.ForeColor = Color.Green;
                }
                catch (Exception er)
                {
                    MessageBox.Show("Erro Inexperado, contate o T.I." , "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void frmCadastrar_Load(object sender, EventArgs e)
        {
            label1.Text = information.nome;
            lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
            cbbAcesso.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
            lblMensagem.Text = "Após preencher os campos, clique no botão gravar!";
        }

        public bool Valida(string cpf)
        {

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;

            string digito;

            int soma;

            int resto;

            cpf = cpf.Trim();

           

            if (cpf.Length < 11)
            {
                return false;

            }


            tempCpf = cpf.Substring(0, 9);

            soma = 0;

            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "00000000000":
                    return false;
                case "2222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }

            for (int i = 0; i < 9; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)

                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

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

            if (txtSenha.TextLength < 7)
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
            if ((txtAula.Visible == true) &&  (txtAula.Text == "") )
            {
                
                lblMensagem.Text = "Digite a aula";
                lblMensagem.ForeColor = Color.Red;
                return false;
               
                
            }
            if (cbbAcesso.SelectedIndex == 0)
            {
                lblMensagem.Text = "Escolha o tipo de acesso";
                lblMensagem.ForeColor = Color.Red;
                return false;
            }
            try
            {
                dtovar.rg = mktxtRG.Text;
                dtovar.email = txtEmail.Text;

                bll.verificaLogin(dtovar);

                if (dtovar.valida == false)
                {
                    lblMensagem.Text = "Email já cadastrado";
                    lblMensagem.ForeColor = Color.Red;
                    txtEmail.Focus();
                    return false;
                }
                

            }
            catch (Exception er)
            {
                MessageBox.Show("Erro Inexperado, contate o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                dtovar.rg = mktxtRG.Text;
                dtovar.login = txtLogin.Text;

                bll.verificaLoginUsu(dtovar);

                if (dtovar.valida == false)
                {
                    lblMensagem.Text = "Login já cadastrado";
                    lblMensagem.ForeColor = Color.Red;
                    txtEmail.Focus();
                    return false;
                }


            }
            catch (Exception er)
            {
                MessageBox.Show("Erro Inexperado, contate o T.I.", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private void limpaCampos()
        {
            txtNome.Text = null;
            txtLogin.Text = null;
            txtSenha.Text = null;
            txtEmail.Text = null;
            txtConfirmarSenha.Text = null;
            mktxtRG.Text = null;
            cbbAcesso.SelectedIndex = 0;
            lblMensagem.ForeColor = Color.Black;
        }

        private void pcbHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbAcesso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbAcesso.Text == "Professor")
            {
                txtAula.Visible = true;
                lblAula.Visible = true;
               

            }
            else
            {
                txtAula.Visible = false;
                lblAula.Visible = false;
            }
        }

        private void mktxtRG_TextChanged(object sender, EventArgs e)
        {
            mktxtRG.BackColor = Color.White;
        }
    }
}
