namespace TechManager
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.swiMostrar = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.pcbSenha = new System.Windows.Forms.PictureBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.linkSenha = new System.Windows.Forms.LinkLabel();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlLogo.Controls.Add(this.pictureBox3);
            this.pnlLogo.Location = new System.Drawing.Point(1, -7);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(349, 433);
            this.pnlLogo.TabIndex = 1;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            this.pnlLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.Location = new System.Drawing.Point(35, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(267, 337);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrar.ForeColor = System.Drawing.Color.DimGray;
            this.lblMostrar.Location = new System.Drawing.Point(489, 256);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(97, 18);
            this.lblMostrar.TabIndex = 10;
            this.lblMostrar.Text = "Mostrar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Black;
            this.txtSenha.Location = new System.Drawing.Point(492, 195);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(159, 26);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.Text = "Senha";
            this.txtSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSenha_MouseClick);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // swiMostrar
            // 
            this.swiMostrar.BackColor = System.Drawing.Color.Transparent;
            this.swiMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("swiMostrar.BackgroundImage")));
            this.swiMostrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.swiMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swiMostrar.Location = new System.Drawing.Point(445, 254);
            this.swiMostrar.Name = "swiMostrar";
            this.swiMostrar.OffColor = System.Drawing.Color.CornflowerBlue;
            this.swiMostrar.OnColor = System.Drawing.Color.Gray;
            this.swiMostrar.Size = new System.Drawing.Size(35, 20);
            this.swiMostrar.TabIndex = 9;
            this.swiMostrar.Value = true;
            this.swiMostrar.OnValueChange += new System.EventHandler(this.swiMostrar_OnValueChange);
            // 
            // pcbUser
            // 
            this.pcbUser.BackgroundImage = global::TechManager.Properties.Resources.if_user_group_285648;
            this.pcbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbUser.Location = new System.Drawing.Point(445, 119);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(41, 56);
            this.pcbUser.TabIndex = 4;
            this.pcbUser.TabStop = false;
            // 
            // pcbSenha
            // 
            this.pcbSenha.BackgroundImage = global::TechManager.Properties.Resources.if_lock_299105;
            this.pcbSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbSenha.Location = new System.Drawing.Point(445, 181);
            this.pcbSenha.Name = "pcbSenha";
            this.pcbSenha.Size = new System.Drawing.Size(41, 54);
            this.pcbSenha.TabIndex = 3;
            this.pcbSenha.TabStop = false;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(492, 135);
            this.txtUser.MaxLength = 50;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(159, 26);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Usuário";
            this.txtUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUser_MouseClick);
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(596, 350);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(120, 33);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(404, 350);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 33);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // linkSenha
            // 
            this.linkSenha.AutoSize = true;
            this.linkSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSenha.Location = new System.Drawing.Point(509, 307);
            this.linkSenha.Name = "linkSenha";
            this.linkSenha.Size = new System.Drawing.Size(112, 16);
            this.linkSenha.TabIndex = 4;
            this.linkSenha.TabStop = true;
            this.linkSenha.Text = "Recuperar senha";
            this.linkSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSenha_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 426);
            this.Controls.Add(this.linkSenha);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.swiMostrar);
            this.Controls.Add(this.pcbUser);
            this.Controls.Add(this.pcbSenha);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buni_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pcbSenha;
        private System.Windows.Forms.PictureBox pcbUser;
        private Bunifu.Framework.UI.BunifuiOSSwitch swiMostrar;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.LinkLabel linkSenha;
    }
}