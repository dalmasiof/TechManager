using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
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
            MessageBox.Show("Email enviado para "+txtEmail.Text+", caso não encontre verifique a caixa de spams","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtEmail.Clear();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Não foi possível enviar o email, verifique a conexão"+erro+"","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtEmail.Clear();
            }
            }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
