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
            Bunifu.ToggleSwitch.ToggleState toggleState13 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState14 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState15 = new Bunifu.ToggleSwitch.ToggleState();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.comboUser = new Bunifu.UI.WinForms.BunifuDropdown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuToggleSwitch1 = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.txtPass = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtUsuario = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEntrar.Location = new System.Drawing.Point(5, 328);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(113, 34);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(134, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(113, 34);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // comboUser
            // 
            this.comboUser.AccessibleName = "";
            this.comboUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.comboUser.BorderRadius = 5;
            this.comboUser.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.comboUser.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.comboUser.DisabledColor = System.Drawing.Color.Gray;
            this.comboUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboUser.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.comboUser.FillDropDown = false;
            this.comboUser.FillIndicator = false;
            this.comboUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboUser.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Icon = null;
            this.comboUser.IndicatorColor = System.Drawing.Color.MidnightBlue;
            this.comboUser.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.comboUser.ItemBackColor = System.Drawing.Color.White;
            this.comboUser.ItemBorderColor = System.Drawing.Color.White;
            this.comboUser.ItemForeColor = System.Drawing.Color.MidnightBlue;
            this.comboUser.ItemHeight = 25;
            this.comboUser.ItemHighLightColor = System.Drawing.Color.LightSlateGray;
            this.comboUser.Items.AddRange(new object[] {
            "Professor",
            "Técnico"});
            this.comboUser.Location = new System.Drawing.Point(34, 75);
            this.comboUser.MinimumSize = new System.Drawing.Size(48, 0);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(196, 31);
            this.comboUser.TabIndex = 0;
            this.comboUser.Text = "Escolha um acesso:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuToggleSwitch1);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.comboUser);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 400);
            this.panel1.TabIndex = 8;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.label1.Location = new System.Drawing.Point(75, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mostrar senha";
            // 
            // bunifuToggleSwitch1
            // 
            this.bunifuToggleSwitch1.Animation = 5;
            this.bunifuToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuToggleSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuToggleSwitch1.BackgroundImage")));
            this.bunifuToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuToggleSwitch1.Location = new System.Drawing.Point(34, 279);
            this.bunifuToggleSwitch1.Name = "bunifuToggleSwitch1";
            this.bunifuToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuToggleSwitch1.TabIndex = 5;
            toggleState13.BackColor = System.Drawing.Color.Empty;
            toggleState13.BackColorInner = System.Drawing.Color.Empty;
            toggleState13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState13.BorderColorInner = System.Drawing.Color.Empty;
            toggleState13.BorderRadius = 1;
            toggleState13.BorderRadiusInner = 1;
            toggleState13.BorderThickness = 1;
            toggleState13.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateDisabled = toggleState13;
            toggleState14.BackColor = System.Drawing.Color.Empty;
            toggleState14.BackColorInner = System.Drawing.Color.Empty;
            toggleState14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState14.BorderColorInner = System.Drawing.Color.Empty;
            toggleState14.BorderRadius = 1;
            toggleState14.BorderRadiusInner = 1;
            toggleState14.BorderThickness = 1;
            toggleState14.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOff = toggleState14;
            toggleState15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            toggleState15.BackColorInner = System.Drawing.Color.White;
            toggleState15.BorderColor = System.Drawing.Color.Black;
            toggleState15.BorderColorInner = System.Drawing.Color.White;
            toggleState15.BorderRadius = 17;
            toggleState15.BorderRadiusInner = 15;
            toggleState15.BorderThickness = 1;
            toggleState15.BorderThicknessInner = 1;
            this.bunifuToggleSwitch1.ToggleStateOn = toggleState15;
            this.bunifuToggleSwitch1.Value = true;
            // 
            // txtPass
            // 
            this.txtPass.AcceptsReturn = false;
            this.txtPass.AcceptsTab = false;
            this.txtPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPass.BackgroundImage")));
            this.txtPass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPass.BorderColorHover = System.Drawing.Color.MidnightBlue;
            this.txtPass.BorderColorIdle = System.Drawing.Color.Black;
            this.txtPass.BorderRadius = 1;
            this.txtPass.BorderThickness = 2;
            this.txtPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPass.FillColor = System.Drawing.Color.White;
            this.txtPass.HideSelection = true;
            this.txtPass.IconLeft = null;
            this.txtPass.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPass.IconPadding = 10;
            this.txtPass.IconRight = null;
            this.txtPass.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPass.Location = new System.Drawing.Point(34, 217);
            this.txtPass.MaximumSize = new System.Drawing.Size(400, 100);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtPass.Modified = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.ReadOnly = false;
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.ShortcutsEnabled = true;
            this.txtPass.Size = new System.Drawing.Size(200, 35);
            this.txtPass.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass.TextMarginLeft = 5;
            this.txtPass.TextPlaceholder = "Senha";
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = false;
            this.txtUsuario.AcceptsTab = false;
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsuario.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUsuario.BackgroundImage")));
            this.txtUsuario.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUsuario.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUsuario.BorderColorHover = System.Drawing.Color.MidnightBlue;
            this.txtUsuario.BorderColorIdle = System.Drawing.Color.Black;
            this.txtUsuario.BorderRadius = 1;
            this.txtUsuario.BorderThickness = 2;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsuario.FillColor = System.Drawing.Color.White;
            this.txtUsuario.HideSelection = true;
            this.txtUsuario.IconLeft = null;
            this.txtUsuario.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtUsuario.IconPadding = 10;
            this.txtUsuario.IconRight = null;
            this.txtUsuario.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtUsuario.Location = new System.Drawing.Point(34, 161);
            this.txtUsuario.MaximumSize = new System.Drawing.Size(400, 100);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtUsuario.Modified = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ReadOnly = false;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(200, 35);
            this.txtUsuario.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsuario.TextMarginLeft = 5;
            this.txtUsuario.TextPlaceholder = "Usuário:";
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TechManager.Properties.Resources.logoTCC1;
            this.pictureBox1.Location = new System.Drawing.Point(1, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtUsuario;
        private Bunifu.UI.WinForms.BunifuDropdown comboUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPass;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch bunifuToggleSwitch1;
        private System.Windows.Forms.Label label1;
    }
}