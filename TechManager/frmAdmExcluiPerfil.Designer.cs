namespace TechManager
{
    partial class frmAdmExcluiPerfil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmExcluiPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.dgvExclui = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblAdnm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExclui)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.lblAdnm);
            this.panel1.Controls.Add(this.pcbHome);
            this.panel1.Controls.Add(this.pcbLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 771);
            this.panel1.TabIndex = 2;
            // 
            // pcbHome
            // 
            this.pcbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbHome.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.pcbHome.ImageActive = global::TechManager.Properties.Resources.if_go_home_118770;
            this.pcbHome.Location = new System.Drawing.Point(67, 650);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(118, 109);
            this.pcbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbHome.TabIndex = 19;
            this.pcbHome.TabStop = false;
            this.pcbHome.Zoom = 10;
            this.pcbHome.Click += new System.EventHandler(this.pcbHome_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbLogo.Image = global::TechManager.Properties.Resources.adm;
            this.pcbLogo.Location = new System.Drawing.Point(49, 47);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(145, 149);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 13;
            this.pcbLogo.TabStop = false;
            // 
            // dgvExclui
            // 
            this.dgvExclui.AllowUserToAddRows = false;
            this.dgvExclui.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvExclui.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExclui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvExclui.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExclui.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvExclui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExclui.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExclui.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExclui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExclui.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.teste,
            this.nome,
            this.tipo,
            this.rg,
            this.login,
            this.senha,
            this.email});
            this.dgvExclui.DoubleBuffered = true;
            this.dgvExclui.EnableHeadersVisualStyles = false;
            this.dgvExclui.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvExclui.HeaderForeColor = System.Drawing.Color.White;
            this.dgvExclui.Location = new System.Drawing.Point(245, 47);
            this.dgvExclui.MultiSelect = false;
            this.dgvExclui.Name = "dgvExclui";
            this.dgvExclui.ReadOnly = true;
            this.dgvExclui.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExclui.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExclui.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExclui.Size = new System.Drawing.Size(1068, 150);
            this.dgvExclui.TabIndex = 3;
            this.dgvExclui.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExclui_CellClick);
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "id";
            this.idUsuario.HeaderText = "ID";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            // 
            // teste
            // 
            this.teste.HeaderText = "Tipo de acesso";
            this.teste.Name = "teste";
            this.teste.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo de acesso";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Visible = false;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            this.rg.HeaderText = "CPF";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(460, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id:";
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(502, 265);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(39, 29);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "Id:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(540, 393);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(85, 29);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(813, 686);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 33);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(545, 686);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 33);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(460, 521);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(186, 29);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "Tipo de acesso:";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(644, 521);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 29);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "Id:";
            // 
            // lblAdnm
            // 
            this.lblAdnm.AutoSize = true;
            this.lblAdnm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdnm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdnm.Location = new System.Drawing.Point(63, 217);
            this.lblAdnm.Name = "lblAdnm";
            this.lblAdnm.Size = new System.Drawing.Size(116, 23);
            this.lblAdnm.TabIndex = 20;
            this.lblAdnm.Text = "Adm ( Nome )";
            this.lblAdnm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdmExcluiPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 771);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExclui);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmExcluiPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Perfil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdmExcluiPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExclui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton pcbHome;
        private System.Windows.Forms.PictureBox pcbLogo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvExclui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn teste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label lblAdnm;
    }
}