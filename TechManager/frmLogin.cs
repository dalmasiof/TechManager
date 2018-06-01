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
using MySql.Data.MySqlClient;

namespace TechManager
{
    public partial class frmLogin : Form
    {
        MySqlConnection conexao = null;
        string conexao_sql = "server=localhost;database=db_tech;user=root;password=1234;port=3306";
        usuarioDTO dtovar = new usuarioDTO();
        usuarioBLL usuarioBLL = new usuarioBLL();
        
        char acesso = 'N';

        public frmLogin()
        {
            InitializeComponent();
        }
        int X = 0;
        int Y = 0;
        
        private void btnSeleciona()
        {
            
        }


        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.Text = "";
        }

        private void buni_MouseClick(object sender, MouseEventArgs e)
        {
            if(cmbAcesso.selectedIndex != 0)
            {
                
            }
            else
            {
                txtUser.Enabled = false;
                txtSenha.Enabled = false;
                txtUser.Text = "Usuário";
                txtSenha.Text = "Senha";
                pnlLogo.Focus();
                cmbAcesso.selectedIndex = 0;
            }


        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.ForeColor = Color.Black;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Enabled = false;
            txtSenha.Enabled = false;
            cmbAcesso.AddItem("Escolha um acesso");
            cmbAcesso.AddItem("Professor");
            cmbAcesso.AddItem("Técnico");
            cmbAcesso.AddItem("Administrador");

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
            string senha = "";

            #region
            //conexao = new MySqlConnection(conexao_sql);

            //if (cmbAcesso.selectedIndex == 1)
            //{
            //    try
            //    {
            //        conexao.Open();
            //        MySqlCommand comando = new MySqlCommand();
            //        comando.CommandText = "SELECT senha FROM tb_prof WHERE login='" + txtUser.Text + "' and senha='" + txtSenha.Text + "';";
            //        comando.CommandType = CommandType.Text;
            //        comando.Connection = conexao;
            //        senha = (string)comando.ExecuteScalar();
            //        MySqlDataReader dr = comando.ExecuteReader();
            //        if (dr.HasRows == true)
            //            {
            //            //    while (dr.Read())
            //            //    {
            //            //        dtovar.id = Convert.ToInt32(dr["idUsuario"]);
            //            //        dtovar.tipo = Convert.ToChar(dr["tipoUsu"]);
            //            //        dtovar.email = Convert.ToString(dr["email"]);
            //            //        dtovar.login = Convert.ToString(dr["login"]);
            //            //        dtovar.senha = Convert.ToString(dr["senha"]);
            //            //        dtovar.nome = Convert.ToString(dr["nome"]);
            //            //        dtovar.rg = Convert.ToString(dr["rg"]);

            //            frmPerfilProf prof = new frmPerfilProf();
            //        prof.Show();
            //        this.Hide();
            //        //    }


            //    }
            //        else
            //        {
            //            MessageBox.Show("Dados incorretos", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            txtUser.Focus();
            //            txtUser.Clear();
            //            txtSenha.Clear();
            //            return;
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        txtUser.Focus();
            //        txtUser.Clear();
            //        txtSenha.Clear();
            //        MessageBox.Show("" + ex);

            //    }
            //}

            //else if (cmbAcesso.selectedIndex == 2)
            //{
            //    try
            //    {
            //        conexao.Open();
            //        MySqlCommand comando = new MySqlCommand();
            //        comando.CommandText = "SELECT senha FROM tb_tec WHERE login='" + txtUser.Text + "' and senha='" + txtSenha.Text + "';";
            //        comando.CommandType = CommandType.Text;
            //        comando.Connection = conexao;
            //        senha = (string)comando.ExecuteScalar();
            //        MySqlDataReader dr = comando.ExecuteReader();
            //        if (dr.HasRows == true)
            //        {
            //            while (dr.Read())
            //            {
            //                dtovar.tipo = Convert.ToChar(dr["tipoUsu"]);
            //                dtovar.email = Convert.ToString(dr["email"]);
            //                dtovar.login = Convert.ToString(dr["login"]);
            //                dtovar.senha = Convert.ToString(dr["senha"]);
            //                dtovar.nome = Convert.ToString(dr["nome"]);
            //                dtovar.rg = Convert.ToString(dr["rg"]);

            //                frmPerfilTec prof = new frmPerfilTec();
            //                prof.Show();
            //                this.Hide();
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("Dados incorretos", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            txtUser.Focus();
            //            txtUser.Clear();
            //            txtSenha.Clear();
            //            return;
            //        }

            //    }
            //    catch (Exception ex)
            //    {

            //        txtUser.Focus();
            //        txtUser.Clear();
            //        txtSenha.Clear();
            //        MessageBox.Show("" + ex);

            //    }
            //}

            //else
            //{
            //    try
            //    {
            //        conexao.Open();
            //        MySqlCommand comando = new MySqlCommand();
            //        comando.CommandText = "SELECT senha FROM tb_adm WHERE login='" + txtUser.Text + "' and senha='" + txtSenha.Text + "';";
            //        comando.CommandType = CommandType.Text;
            //        comando.Connection = conexao;
            //        senha = (string)comando.ExecuteScalar();
            //        MySqlDataReader dr = comando.ExecuteReader();
            //        if (dr.HasRows == true)
            //        {
            //            while (dr.Read())
            //            {
            //                dtovar.tipo = Convert.ToChar(dr["tipoUsu"]);
            //                dtovar.email = Convert.ToString(dr["email"]);
            //                dtovar.login = Convert.ToString(dr["login"]);
            //                dtovar.senha = Convert.ToString(dr["senha"]);
            //                dtovar.nome = Convert.ToString(dr["nome"]);
            //                dtovar.rg = Convert.ToString(dr["rg"]);

            //                frmPerfilAdm prof = new frmPerfilAdm();
            //                prof.Show();
            //                this.Hide();
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("Dados incorretos", "Acesso Negado!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            txtUser.Focus();
            //            txtUser.Clear();
            //            txtSenha.Clear();
            //            return;
            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //        MessageBox.Show("Falha com o banco de dados", "Consulte o T.I.!"+ex, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        txtUser.Focus();
            //        txtUser.Clear();
            //        txtSenha.Clear();

            //    }


            //}
            #endregion teste

            dtovar.login = txtUser.Text;
            dtovar.senha = txtSenha.Text;



            try
            {
                List<usuarioDTO> ListDto = new List<usuarioDTO>();
                ListDto = new usuarioBLL().validar(dtovar);
                if ((ListDto.Count > 0)&&(dtovar.tipo == cmbAcesso.selectedIndex))
                {
                    if (dtovar.tipo == 1)
                    {
                    MessageBox.Show("Bem vindo "+dtovar.nome);
                    frmPerfilProf prof = new frmPerfilProf();
                    prof.Show();
                    this.Hide();

                    }
                    else if (dtovar.tipo == 2)
                    {
                        MessageBox.Show("Bem vindo " + dtovar.nome);
                        frmPerfilTec prof = new frmPerfilTec();
                        prof.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Bem vindo " + dtovar.nome);
                        frmPerfilAdm prof = new frmPerfilAdm();
                        prof.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("errrro ");
                    return;
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

           
           
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbAcesso_onItemSelected(object sender, EventArgs e)
        {
            if (cmbAcesso.selectedIndex == 0)
            {
                txtUser.Enabled = false;
                txtSenha.Enabled = false;
                txtUser.Text = "Usuário";
                txtSenha.Text = "Senha";
            }

            else if (cmbAcesso.selectedIndex == 1 || cmbAcesso.selectedIndex == 2)
            {
                txtUser.Enabled = true;
                txtSenha.Enabled = true;
            }
            

            else if (cmbAcesso.selectedIndex == 3)
            {
                
                txtUser.Enabled = true;
                txtSenha.Enabled = true;
                txtUser.Focus();
                
                lblMostrar.Visible = false;
                txtSenha.PasswordChar = char.Parse("*");

            }
            else
            {
                swiMostrar.Visible = true;
                lblMostrar.Visible = true;
            }
        }

        private void txtSenha_MouseClick(object sender, MouseEventArgs e)
        {
            txtSenha.Text = null;
        }

        private void linkSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAlterarSenha frmAlterarSenha = new frmAlterarSenha();
            frmAlterarSenha.ShowDialog();
        }
    }
}
