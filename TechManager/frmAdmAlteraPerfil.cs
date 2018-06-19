using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using System.Text.RegularExpressions;


namespace TechManager
{
    public partial class frmAdmAlteraPerfil : Form
    {
        public frmAdmAlteraPerfil()
        {
            InitializeComponent();
        }
        usuarioDTO dto = new usuarioDTO();
        usuarioBLL bll = new usuarioBLL();

        private void frmAdmAlteraPerfil_Load(object sender, EventArgs e)
        {
            //desativaCampos();
            carregaGrid();
            lblMensagem.Text = "Selecione um registro na tabela.";

        }

        private void carregaGrid()
        {
            dgvAltera.AutoGenerateColumns = false;
            try
            {
                List<usuarioDTO> ListDto = new List<usuarioDTO>();
                ListDto = new usuarioBLL().listaUsuario();


                dgvAltera.DataSource = ListDto;

               // Pintalinhas();
            }
            catch (Exception erro)
            {
                throw erro;
            }
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

        private void btnGravar_Click(object sender, EventArgs e)
        {

            if (!verificaCampos())
            {
                return;
            }
            else
            {
                dto.nome = txtNome.Text;
                dto.login = txtLogin.Text;
                dto.senha = txtSenha.Text;
                dto.email = txtEmail.Text;
                dto.rg = mktxtRG.Text;
                if (cbbAcesso.SelectedIndex == 0)
                {
                    dto.tipo = 0;

                }
                else
                {
                    dto.tipo = 1;
                }

                try
                {
                    bll.alterarUsuario(dto);
                    lblMensagem.Text = "Alterado com sucesso!";
                    LimpaCampos();
                }
                catch (Exception er)
                {
                    throw er;
                }
            }
        }

        private void LimpaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as Control).Text = "";
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

        private void dgvAltera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int sel = dgvAltera.CurrentRow.Index;

            txtConfirmarSenha.Text = "";
            txtEmail.Text = Convert.ToString(dgvAltera["email", sel].Value);
            txtLogin.Text = Convert.ToString(dgvAltera["login", sel].Value);;
            txtNome.Text = Convert.ToString(dgvAltera["nome", sel].Value);;
            //txtNomeFotoPerfil.Text = Convert.ToString(dgvAltera["foto", sel].Value);;
            txtSenha.Text = Convert.ToString(dgvAltera["senha", sel].Value);
            mktxtRG.Text = Convert.ToString(dgvAltera["rg", sel].Value);
            dto.id = Convert.ToInt32(dgvAltera["id", sel].Value);
            
            lblMensagem.Text = "Após terminar a edição clique em ALTERAR";
        }

        
    }
}
