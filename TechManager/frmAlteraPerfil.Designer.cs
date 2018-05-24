namespace TechManager
{
    partial class frmAlteraPerfil
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcurarImagem = new System.Windows.Forms.Button();
            this.txtImagemUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pcbHome);
            this.panel1.Controls.Add(this.pcbLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 471);
            this.panel1.TabIndex = 1;
            // 
            // pcbHome
            // 
            this.pcbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbHome.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.pcbHome.ImageActive = global::TechManager.Properties.Resources.if_go_home_118770;
            this.pcbHome.Location = new System.Drawing.Point(52, 372);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(71, 71);
            this.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHome.TabIndex = 19;
            this.pcbHome.TabStop = false;
            this.pcbHome.Zoom = 10;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImage = global::TechManager.Properties.Resources.logoTCC1;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLogo.Location = new System.Drawing.Point(2, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(167, 222);
            this.pcbLogo.TabIndex = 13;
            this.pcbLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(84, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Voltar";
            // 
            // btnProcurarImagem
            // 
            this.btnProcurarImagem.Location = new System.Drawing.Point(556, 63);
            this.btnProcurarImagem.Name = "btnProcurarImagem";
            this.btnProcurarImagem.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarImagem.TabIndex = 8;
            this.btnProcurarImagem.Text = "Procurar";
            this.btnProcurarImagem.UseVisualStyleBackColor = true;
            // 
            // txtImagemUsuario
            // 
            this.txtImagemUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtImagemUsuario.Enabled = false;
            this.txtImagemUsuario.Location = new System.Drawing.Point(357, 66);
            this.txtImagemUsuario.Name = "txtImagemUsuario";
            this.txtImagemUsuario.Size = new System.Drawing.Size(193, 20);
            this.txtImagemUsuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Foto de Perfil";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TechManager.Properties.Resources.if_Camera_Front_379526;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(207, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 109);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(385, 267);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmarSenha.TabIndex = 26;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(385, 234);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(162, 20);
            this.txtSenha.TabIndex = 25;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(385, 201);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(162, 20);
            this.txtLogin.TabIndex = 24;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(387, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(385, 168);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 22;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(237, 263);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(139, 23);
            this.lblConfirmarSenha.TabIndex = 21;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.DimGray;
            this.lblSenha.Location = new System.Drawing.Point(237, 230);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 23);
            this.lblSenha.TabIndex = 20;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(237, 296);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogin.Location = new System.Drawing.Point(237, 197);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 23);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Login";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(237, 164);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 23);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "Nome";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(311, 356);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(82, 18);
            this.lblMensagem.TabIndex = 29;
            this.lblMensagem.Text = "mensagem";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(247, 409);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 33);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(442, 409);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(120, 33);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "Alterar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmAlteraPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 471);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnProcurarImagem);
            this.Controls.Add(this.txtImagemUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAlteraPerfil";
            this.Text = "Alterar Usuário";
            this.Load += new System.EventHandler(this.frmAlteraPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcurarImagem;
        private System.Windows.Forms.TextBox txtImagemUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.PictureBox pcbLogo;
        private Bunifu.Framework.UI.BunifuImageButton pcbHome;
    }
}