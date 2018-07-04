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


namespace TechManager
{
    public partial class frmPerfilTec : Form
    {
        public frmPerfilTec()
        {
            InitializeComponent();
        }
        probBll bll = new probBll();
        probDto dtovar = new probDto();
        advertenciaDTO dtoVarAdv = new advertenciaDTO();
        
        int notiComeco;
        int noti;

        int notiComecoAdv;
        int notiAdv;

        Boolean mostrar = true;
        Boolean mostrarADv = true;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmPerfilTec_Load(object sender, EventArgs e)
        {
           

            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().notificacao(dtovar);
                notiComeco = dtovar.noti;

                List<advertenciaDTO> ListDtoAdv = new List<advertenciaDTO>();
                ListDtoAdv = new advertenciaBLL().notificacaAdv(dtoVarAdv);
                notiComecoAdv = dtoVarAdv.noti;

            }
            catch (Exception erro)
            {
                throw erro;
            }



            lblNome.Text = Convert.ToString(information.nome);
            pcbFotoTec.ImageLocation = information.foto;
            notifyIcon1.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;

            
            
        }

        private void btnAdve_Click(object sender, EventArgs e)
        {
            btnAdve.Iconimage_right = null;
            this.Hide();
            frmAdvertenciaTecnico adv = new frmAdvertenciaTecnico();
            adv.ShowDialog();
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            btnErro.Iconimage_right = null;
            this.Hide();
            frmProblemaTec prob = new frmProblemaTec();
            prob.ShowDialog();
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            frmHistorico historico = new frmHistorico();
            historico.ShowDialog();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
        }



        private void notifyIcon1_MouseClick_1(object sender, MouseEventArgs e)
        {

            this.Show();
            notifyIcon1.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
            
        }

        private void frmPerfilTec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAbout sobre = new frmAbout();
            sobre.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                List<probDto> ListDto = new List<probDto>();
                ListDto = new probBll().notificacao(dtovar);
                noti = dtovar.noti;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha de conexão, entre em contato com o T.I.\n" + erro + "", "Falha de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
            
            if (noti - notiComeco == 1)
            {
                btnErro.Iconimage_right = Properties.Resources.noti12;

               if( mostrar == true){

                notifyIcon2.Visible = true;
                notifyIcon2.Icon = SystemIcons.Information;
                notifyIcon2.BalloonTipTitle = "Novo problema";
                notifyIcon2.BalloonTipText = "Foi registrado um novo problema";
                notifyIcon2.ShowBalloonTip(30000);
                    mostrar = false;
                }

            }
            else if(noti - notiComeco > 1)
            {
              

            }

           

           
        }

        private void pcbFotoTec_Click(object sender, EventArgs e)
        {
            frmAlteraPerfil alt = new frmAlteraPerfil();
            alt.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                List<advertenciaDTO> ListDto = new List<advertenciaDTO>();
                ListDto = new advertenciaBLL().notificacaAdv(dtoVarAdv);
                notiAdv = dtoVarAdv.noti;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha de conexão, entre em contato com o T.I.\n" + erro + "", "Falha de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (notiAdv - notiComecoAdv == 1)
            {
                btnAdve.Iconimage_right = Properties.Resources.noti12;

                if (mostrarADv == true)
                {

                    notifyIcon2.Visible = true;
                    notifyIcon2.Icon = SystemIcons.Exclamation;
                    notifyIcon2.BalloonTipTitle = "Novo aviso";
                    notifyIcon2.BalloonTipText = "Foi registrado um novo aviso";
                    notifyIcon2.ShowBalloonTip(30000);
                    mostrarADv = false;
                }

            }
            else if (notiAdv - notiComecoAdv > 1)
            {
                btnAdve.Iconimage_right = Properties.Resources.notiMais;

            }
        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

               
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cps.sp.gov.br/category/etec/");
        }
    }

}
