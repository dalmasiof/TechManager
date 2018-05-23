namespace TechManager
{
    partial class frmCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.lblFotoPerfil = new System.Windows.Forms.Label();
            this.txtNomeFotoPerfil = new System.Windows.Forms.TextBox();
            this.btnProcurarFoto = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.cbbAcesso = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pcbHome);
            this.panel1.Controls.Add(this.pcbLogo);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 472);
            this.panel1.TabIndex = 0;
            // 
            // pcbHome
            // 
            this.pcbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbHome.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.pcbHome.ImageActive = global::TechManager.Properties.Resources.if_go_home_118770;
            this.pcbHome.Location = new System.Drawing.Point(53, 373);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(71, 71);
            this.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHome.TabIndex = 18;
            this.pcbHome.TabStop = false;
            this.pcbHome.Zoom = 10;
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImage = global::TechManager.Properties.Resources.logoTCC1;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLogo.Location = new System.Drawing.Point(3, 13);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(167, 222);
            this.pcbLogo.TabIndex = 2;
            this.pcbLogo.TabStop = false;
            // 
            // lblFotoPerfil
            // 
            this.lblFotoPerfil.AutoSize = true;
            this.lblFotoPerfil.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFotoPerfil.Location = new System.Drawing.Point(354, 45);
            this.lblFotoPerfil.Name = "lblFotoPerfil";
            this.lblFotoPerfil.Size = new System.Drawing.Size(91, 18);
            this.lblFotoPerfil.TabIndex = 2;
            this.lblFotoPerfil.Text = "Foto de Perfil";
            // 
            // txtNomeFotoPerfil
            // 
            this.txtNomeFotoPerfil.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomeFotoPerfil.Enabled = false;
            this.txtNomeFotoPerfil.Location = new System.Drawing.Point(357, 66);
            this.txtNomeFotoPerfil.Name = "txtNomeFotoPerfil";
            this.txtNomeFotoPerfil.Size = new System.Drawing.Size(193, 20);
            this.txtNomeFotoPerfil.TabIndex = 3;
            // 
            // btnProcurarFoto
            // 
            this.btnProcurarFoto.Location = new System.Drawing.Point(556, 63);
            this.btnProcurarFoto.Name = "btnProcurarFoto";
            this.btnProcurarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarFoto.TabIndex = 4;
            this.btnProcurarFoto.Text = "Procurar";
            this.btnProcurarFoto.UseVisualStyleBackColor = true;
            this.btnProcurarFoto.Click += new System.EventHandler(this.btnProcurarFoto_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(237, 146);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(56, 23);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.DimGray;
            this.lblLogin.Location = new System.Drawing.Point(237, 179);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 23);
            this.lblLogin.TabIndex = 6;
            this.lblLogin.Text = "Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmail.Location = new System.Drawing.Point(237, 278);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 23);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.DimGray;
            this.lblSenha.Location = new System.Drawing.Point(237, 212);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 23);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.DimGray;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(237, 245);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(139, 23);
            this.lblConfirmarSenha.TabIndex = 9;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(385, 150);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(162, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(387, 282);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(385, 183);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(162, 20);
            this.txtLogin.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(385, 216);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(162, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(385, 249);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmarSenha.TabIndex = 14;
            // 
            // pcbFoto
            // 
            this.pcbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbFoto.Image = global::TechManager.Properties.Resources.if_Camera_Front_379526;
            this.pcbFoto.Location = new System.Drawing.Point(207, 12);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(109, 109);
            this.pcbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoto.TabIndex = 1;
            this.pcbFoto.TabStop = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGravar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGravar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.Location = new System.Drawing.Point(430, 410);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(120, 33);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(235, 410);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 33);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(311, 360);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(82, 18);
            this.lblMensagem.TabIndex = 19;
            this.lblMensagem.Text = "mensagem";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.BackColor = System.Drawing.SystemColors.Control;
            this.lblAcesso.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.ForeColor = System.Drawing.Color.DimGray;
            this.lblAcesso.Location = new System.Drawing.Point(237, 311);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(64, 23);
            this.lblAcesso.TabIndex = 20;
            this.lblAcesso.Text = "Acesso";
            // 
            // cbbAcesso
            // 
            this.cbbAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAcesso.FormattingEnabled = true;
            this.cbbAcesso.Items.AddRange(new object[] {
            "Professor",
            "Técnico"});
            this.cbbAcesso.Location = new System.Drawing.Point(385, 315);
            this.cbbAcesso.Name = "cbbAcesso";
            this.cbbAcesso.Size = new System.Drawing.Size(162, 21);
            this.cbbAcesso.TabIndex = 21;
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(752, 470);
            this.Controls.Add(this.cbbAcesso);
            this.Controls.Add(this.lblAcesso);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
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
            this.Controls.Add(this.btnProcurarFoto);
            this.Controls.Add(this.txtNomeFotoPerfil);
            this.Controls.Add(this.lblFotoPerfil);
            this.Controls.Add(this.pcbFoto);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.frmCadastrar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.Label lblFotoPerfil;
        private System.Windows.Forms.TextBox txtNomeFotoPerfil;
        private System.Windows.Forms.Button btnProcurarFoto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.PictureBox pcbLogo;
        private Bunifu.Framework.UI.BunifuImageButton pcbHome;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.ComboBox cbbAcesso;
    }
}