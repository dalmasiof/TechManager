namespace TechManager
{
    partial class frmTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTecnico));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkConserto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuRadioButton1 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuRadioButton2 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuRadioButton3 = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdvertencia = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdmaquina = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bunifuRadioButton3);
            this.panel1.Controls.Add(this.bunifuRadioButton2);
            this.panel1.Controls.Add(this.bunifuRadioButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdmaquina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(325, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 475);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.Id,
            this.professor,
            this.aula,
            this.problema,
            this.checkConserto});
            this.dataGridView1.Location = new System.Drawing.Point(30, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID Máquina";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // professor
            // 
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            // 
            // aula
            // 
            this.aula.HeaderText = "Aula";
            this.aula.Name = "aula";
            this.aula.ReadOnly = true;
            // 
            // problema
            // 
            this.problema.HeaderText = "Problema";
            this.problema.Name = "problema";
            this.problema.ReadOnly = true;
            // 
            // checkConserto
            // 
            this.checkConserto.HeaderText = "Tem conserto?";
            this.checkConserto.Name = "checkConserto";
            this.checkConserto.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label1.Location = new System.Drawing.Point(25, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verificar histórico: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label2.Location = new System.Drawing.Point(25, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Definir prazo?";
            // 
            // bunifuRadioButton1
            // 
            this.bunifuRadioButton1.Checked = true;
            this.bunifuRadioButton1.Location = new System.Drawing.Point(30, 320);
            this.bunifuRadioButton1.Name = "bunifuRadioButton1";
            this.bunifuRadioButton1.OutlineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuRadioButton1.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.bunifuRadioButton1.Size = new System.Drawing.Size(22, 22);
            this.bunifuRadioButton1.TabIndex = 5;
            this.bunifuRadioButton1.Text = null;
            // 
            // bunifuRadioButton2
            // 
            this.bunifuRadioButton2.Checked = true;
            this.bunifuRadioButton2.Location = new System.Drawing.Point(30, 376);
            this.bunifuRadioButton2.Name = "bunifuRadioButton2";
            this.bunifuRadioButton2.OutlineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuRadioButton2.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.bunifuRadioButton2.Size = new System.Drawing.Size(22, 22);
            this.bunifuRadioButton2.TabIndex = 6;
            this.bunifuRadioButton2.Text = null;
            // 
            // bunifuRadioButton3
            // 
            this.bunifuRadioButton3.Checked = true;
            this.bunifuRadioButton3.Location = new System.Drawing.Point(30, 348);
            this.bunifuRadioButton3.Name = "bunifuRadioButton3";
            this.bunifuRadioButton3.OutlineColor = System.Drawing.Color.MidnightBlue;
            this.bunifuRadioButton3.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.bunifuRadioButton3.Size = new System.Drawing.Size(22, 22);
            this.bunifuRadioButton3.TabIndex = 7;
            this.bunifuRadioButton3.Text = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12.25F);
            this.label3.Location = new System.Drawing.Point(58, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12.25F);
            this.label4.Location = new System.Drawing.Point(58, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Não";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12.25F);
            this.label5.Location = new System.Drawing.Point(58, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Indeterminado";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(347, 322);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 82);
            this.textBox1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label6.Location = new System.Drawing.Point(342, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Relatório";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label7.Location = new System.Drawing.Point(170, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prazo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnAlterar.Location = new System.Drawing.Point(216, 420);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 42);
            this.btnAlterar.TabIndex = 15;
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
            this.btnExcluir.Location = new System.Drawing.Point(378, 421);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(113, 42);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.btnEnviar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEnviar.FlatAppearance.BorderSize = 2;
            this.btnEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnEnviar.Location = new System.Drawing.Point(57, 420);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(113, 42);
            this.btnEnviar.TabIndex = 14;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(224)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.button1.Location = new System.Drawing.Point(533, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
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
            this.bunifuButton1.Location = new System.Drawing.Point(13, 106);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties7;
            this.bunifuButton1.Size = new System.Drawing.Size(210, 45);
            this.bunifuButton1.TabIndex = 12;
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
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.BorderRadius = 1;
            stateProperties8.BorderThickness = 1;
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties8.IconLeftImage = null;
            stateProperties8.IconRightImage = null;
            this.btnAdvertencia.onHoverState = stateProperties8;
            this.btnAdvertencia.Size = new System.Drawing.Size(210, 45);
            this.btnAdvertencia.TabIndex = 11;
            this.btnAdvertencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechManager.Properties.Resources.logoTCC;
            this.pictureBox1.Location = new System.Drawing.Point(13, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
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
            this.txtIdmaquina.Location = new System.Drawing.Point(189, 238);
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
            this.txtIdmaquina.Size = new System.Drawing.Size(280, 35);
            this.txtIdmaquina.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtIdmaquina.TabIndex = 3;
            this.txtIdmaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdmaquina.TextMarginLeft = 5;
            this.txtIdmaquina.TextPlaceholder = "Digite a data,id da maquina ou o nome do professor";
            this.txtIdmaquina.UseSystemPasswordChar = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.lblNome.Location = new System.Drawing.Point(88, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 26);
            this.lblNome.TabIndex = 19;
            this.lblNome.Text = "Nometec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 15.25F);
            this.label8.Location = new System.Drawing.Point(24, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nome:";
            // 
            // frmTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1023, 487);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.btnAdvertencia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTecnico";
            this.Text = "frmTecnico";
            this.Load += new System.EventHandler(this.frmTecnico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdvertencia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn aula;
        private System.Windows.Forms.DataGridViewTextBoxColumn problema;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkConserto;
        private Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtIdmaquina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton3;
        private Bunifu.UI.WinForms.BunifuRadioButton bunifuRadioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label8;
    }
}