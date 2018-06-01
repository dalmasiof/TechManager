using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechManager
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            if (!verificaCampos())
            {
                return;
            }
            else
            {

                try
                {

                    System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.emailmyname.com");
                    message.From = new MailAddress("suportetechmanager@outlook.com", "TechManager");
                    message.To.Add(txtEmail.Text);

                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.Host = "smtp.live.com";
                    smtp.Credentials = new System.Net.NetworkCredential("suportetechmanager@outlook.com", "trabTcc12!@");
                    smtp.Send(message);

                    message.Subject = "Recuperação de senha";
                    message.Body = "Ola -nome usuario-, sua antiga senha é -senha-,é sugerido que altere para uma nova senha" +
                            "\n\nEssa é uma mensagem automática, por favor não responder";

                    smtp.Send(message);
                    txtEmail.Clear();
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Não foi possível enviar o email, verifique a conexão" + erro + "", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Clear();
                }
            }
        }
        private bool verificaCampos()
        {
            string email = txtEmail.Text;
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (txtEmail.Text == "")
            {
                lblMensagem.Text = "O campo não pode estar vazio";
                lblMensagem.ForeColor = Color.Red;
                txtEmail.Focus();
                return false;
            }



            if (rg.IsMatch(email))
            {
                lblMensagem.Text = "";
                MessageBox.Show("Email enviado para " + txtEmail.Text + ", caso não encontre verifique a caixa de spams", "Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = "";
        }
    }
}
