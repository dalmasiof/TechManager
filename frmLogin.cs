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
        int X = 0;
        int Y = 0;

        public frmLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(pictureBox1_MouseDown);
            this.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmProfessor professor = new frmProfessor();
            usuarioDTO.Nome = txtUsuario.Text;
            
            professor.Show();
            
            
        }
        #region mover


        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
        #endregion

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }
    }
}
