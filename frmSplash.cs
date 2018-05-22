using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechManager
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            desaparecer();
        }

        public void desaparecer()
        {
            this.timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            bunifuProgressBar1.Value = 1;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ativo = true;

            if (ativo == true)
            {
                bunifuProgressBar1.Value +=1;
                
            }
            if (bunifuProgressBar1.Value == bunifuProgressBar1.MaximumValue)
            {
                ativo = false;
                timer1.Enabled = false;
                frmLogin janela = new frmLogin();
                janela.Show();
               // this.Close();
            }

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new Bunifu.UI.Winforms.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechManager.Properties.Resources.logoTCC1;
            this.pictureBox1.Location = new System.Drawing.Point(108, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 20.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(100, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facilitando a comunicação";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.Animation = 0;
            this.bunifuProgressBar1.AnimationStep = 10;
            this.bunifuProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar1.BackgroundImage")));
            this.bunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.BorderThickness = 2;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(98, 230);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.MinimumValue = 0;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.bunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(237)))), ((int)(((byte)(70)))));
            this.bunifuProgressBar1.ProgressColorRight = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(109)))), ((int)(((byte)(10)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(284, 16);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 0;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
