namespace TechManager
{
    partial class frmProfessor
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfessor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataProfessor = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdvertencia = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtIdmaquina = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAula = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label1.Location = new System.Drawing.Point(113, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label2.Location = new System.Drawing.Point(135, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label3.Location = new System.Drawing.Point(78, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Problema";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtAula);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dataProfessor);
            this.panel1.Controls.Add(this.bunifuTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdmaquina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 420);
            this.panel1.TabIndex = 7;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.lblData.Location = new System.Drawing.Point(453, 73);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(50, 26);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Aula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label4.Location = new System.Drawing.Point(397, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data:";
            // 
            // dataProfessor
            // 
            this.dataProfessor.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dataProfessor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProfessor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aula,
            this.Professor,
            this.id,
            this.prob,
            this.data});
            this.dataProfessor.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataProfessor.Location = new System.Drawing.Point(83, 177);
            this.dataProfessor.Name = "dataProfessor";
            this.dataProfessor.Size = new System.Drawing.Size(543, 131);
            this.dataProfessor.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnEnviar.Location = new System.Drawing.Point(69, 346);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 42);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnAlterar.Location = new System.Drawing.Point(228, 346);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 42);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnExcluir.Location = new System.Drawing.Point(390, 347);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 42);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.Name = "aula";
            this.aula.ReadOnly = true;
            // 
            // Professor
            // 
            this.Professor.DataPropertyName = "nome";
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            this.Professor.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Id Máquina";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // prob
            // 
            this.prob.HeaderText = "Problema";
            this.prob.Name = "prob";
            this.prob.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.button1.Location = new System.Drawing.Point(545, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.lblNome.Location = new System.Drawing.Point(461, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 26);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Aula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label6.Location = new System.Drawing.Point(397, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome:";
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Sair";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(143)))), ((int)(((byte)(35)))));
            this.bunifuButton1.IdleBorderRadius = 40;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(143)))), ((int)(((byte)(35)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(13, 133);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties3;
            this.bunifuButton1.Size = new System.Drawing.Size(210, 45);
            this.bunifuButton1.TabIndex = 9;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnAdvertencia
            // 
            this.btnAdvertencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvertencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdvertencia.BackgroundImage")));
            this.btnAdvertencia.ButtonText = "Advertências";
            this.btnAdvertencia.ButtonTextMarginLeft = 0;
            this.btnAdvertencia.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAdvertencia.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnAdvertencia.DisabledForecolor = System.Drawing.Color.White;
            this.btnAdvertencia.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.btnAdvertencia.ForeColor = System.Drawing.Color.White;
            this.btnAdvertencia.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdvertencia.IconPadding = 10;
            this.btnAdvertencia.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAdvertencia.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(143)))), ((int)(((byte)(35)))));
            this.btnAdvertencia.IdleBorderRadius = 40;
            this.btnAdvertencia.IdleBorderThickness = 1;
            this.btnAdvertencia.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(143)))), ((int)(((byte)(35)))));
            this.btnAdvertencia.IdleIconLeftImage = null;
            this.btnAdvertencia.IdleIconRightImage = null;
            this.btnAdvertencia.Location = new System.Drawing.Point(13, 17);
            this.btnAdvertencia.Name = "btnAdvertencia";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnAdvertencia.onHoverState = stateProperties4;
            this.btnAdvertencia.Size = new System.Drawing.Size(210, 45);
            this.btnAdvertencia.TabIndex = 8;
            this.btnAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdvertencia.Click += new System.EventHandler(this.btnAdvertencia_Click);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(218)))), ((int)(((byte)(21)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Green;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Black;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 2;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(178, 119);
            this.bunifuTextBox1.MaximumSize = new System.Drawing.Size(400, 100);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(391, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 7;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Descreva o problema";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // txtIdmaquina
            // 
            this.txtIdmaquina.AcceptsReturn = false;
            this.txtIdmaquina.AcceptsTab = false;
            this.txtIdmaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIdmaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIdmaquina.BackColor = System.Drawing.Color.Transparent;
            this.txtIdmaquina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtIdmaquina.BackgroundImage")));
            this.txtIdmaquina.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(218)))), ((int)(((byte)(21)))));
            this.txtIdmaquina.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtIdmaquina.BorderColorHover = System.Drawing.Color.Green;
            this.txtIdmaquina.BorderColorIdle = System.Drawing.Color.Black;
            this.txtIdmaquina.BorderRadius = 1;
            this.txtIdmaquina.BorderThickness = 2;
            this.txtIdmaquina.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIdmaquina.FillColor = System.Drawing.Color.White;
            this.txtIdmaquina.HideSelection = true;
            this.txtIdmaquina.IconLeft = null;
            this.txtIdmaquina.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtIdmaquina.IconPadding = 10;
            this.txtIdmaquina.IconRight = null;
            this.txtIdmaquina.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtIdmaquina.Location = new System.Drawing.Point(178, 69);
            this.txtIdmaquina.MaximumSize = new System.Drawing.Size(400, 100);
            this.txtIdmaquina.MaxLength = 32767;
            this.txtIdmaquina.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtIdmaquina.Modified = false;
            this.txtIdmaquina.Name = "txtIdmaquina";
            this.txtIdmaquina.PasswordChar = '\0';
            this.txtIdmaquina.ReadOnly = false;
            this.txtIdmaquina.SelectedText = "";
            this.txtIdmaquina.SelectionLength = 0;
            this.txtIdmaquina.SelectionStart = 0;
            this.txtIdmaquina.ShortcutsEnabled = true;
            this.txtIdmaquina.Size = new System.Drawing.Size(200, 35);
            this.txtIdmaquina.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtIdmaquina.TabIndex = 2;
            this.txtIdmaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdmaquina.TextMarginLeft = 5;
            this.txtIdmaquina.TextPlaceholder = "Digite o ID da máquina";
            this.txtIdmaquina.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechManager.Properties.Resources.logoTCC;
            this.pictureBox1.Location = new System.Drawing.Point(22, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // txtAula
            // 
            this.txtAula.AcceptsReturn = false;
            this.txtAula.AcceptsTab = false;
            this.txtAula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAula.BackColor = System.Drawing.Color.Transparent;
            this.txtAula.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAula.BackgroundImage")));
            this.txtAula.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(218)))), ((int)(((byte)(21)))));
            this.txtAula.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAula.BorderColorHover = System.Drawing.Color.Green;
            this.txtAula.BorderColorIdle = System.Drawing.Color.Black;
            this.txtAula.BorderRadius = 1;
            this.txtAula.BorderThickness = 2;
            this.txtAula.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAula.FillColor = System.Drawing.Color.White;
            this.txtAula.HideSelection = true;
            this.txtAula.IconLeft = null;
            this.txtAula.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAula.IconPadding = 10;
            this.txtAula.IconRight = null;
            this.txtAula.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAula.Location = new System.Drawing.Point(178, 12);
            this.txtAula.MaximumSize = new System.Drawing.Size(400, 100);
            this.txtAula.MaxLength = 32767;
            this.txtAula.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAula.Modified = false;
            this.txtAula.Name = "txtAula";
            this.txtAula.PasswordChar = '\0';
            this.txtAula.ReadOnly = false;
            this.txtAula.SelectedText = "";
            this.txtAula.SelectionLength = 0;
            this.txtAula.SelectionStart = 0;
            this.txtAula.ShortcutsEnabled = true;
            this.txtAula.Size = new System.Drawing.Size(200, 35);
            this.txtAula.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAula.TabIndex = 14;
            this.txtAula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAula.TextMarginLeft = 5;
            this.txtAula.TextPlaceholder = "Digitea aula";
            this.txtAula.UseSystemPasswordChar = false;
            // 
            // frmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1023, 418);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.btnAdvertencia);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProfessor";
            this.Text = "frmProfessor";
            this.Load += new System.EventHandler(this.frmProfessor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtIdmaquina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataProfessor;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prob;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.Button button1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdvertencia;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label6;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAula;
    }
}