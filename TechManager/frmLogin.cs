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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int X = 0;
        int Y = 0;
        
        private void btnSeleciona()
        {
            
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.Text = "";
        }

        private void buni_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.Text = "Usuário";
            txtSenha.Text = "Senha";
            txtUser.ForeColor = Color.DarkGray;
            txtSenha.ForeColor = Color.DarkGray;
            pnlLogo.Focus();


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbAcesso.AddItem("Escolha um acesso");
            cmbAcesso.AddItem("Professor");
            cmbAcesso.AddItem("Técnico");

            cmbAcesso.selectedIndex = 0;
        }

        private void swiMostrar_OnValueChange(object sender, EventArgs e)
        {

            if (txtSenha.PasswordChar == char.Parse("*"))
            {
                txtSenha.PasswordChar = char.Parse("\0");
                txtSenha.Focus();
            }
            else
            {
                txtSenha.PasswordChar = char.Parse("*");
                txtSenha.Focus();
            }
        }
        #region mover
        private void segura(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void arrasta(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            segura(e);
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            arrasta(e);
        }
       

        private void pnlLogo_MouseMove(object sender, MouseEventArgs e)
        {
            arrasta(e);
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            segura(e);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            segura(e);
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            arrasta(e);
        }
        #endregion

       

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
                btnEntrar.ForeColor = Color.Black;
                return;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(cmbAcesso.selectedIndex == 0)
            {
                MessageBox.Show("Escolha um acesso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbAcesso.Focus();
                cmbAcesso.NomalColor = Color.Salmon;
                return;
            }
            else if(cmbAcesso.selectedIndex == 1)
            {
                usuarioDTO.Nome = txtUser.Text;
                frmPerfilProf prof = new frmPerfilProf();
                prof.ShowDialog();
                this.Hide();
                this.Close();
            }
            else
            {
                frmPerfilTec tec = new frmPerfilTec();
                tec.ShowDialog();
                this.Hide();
                this.Close();
            }
        }

       
    }
}
