namespace TechManager
{
    partial class frmProblemaProf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProblemaProf));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtProblema = new System.Windows.Forms.TextBox();
            this.btnCacnelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(84, 551);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Voltar";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::TechManager.Properties.Resources.back2;
            this.btnVoltar.ImageActive = global::TechManager.Properties.Resources.back__1_;
            this.btnVoltar.Location = new System.Drawing.Point(12, 533);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(76, 60);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Zoom = 10;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-48, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 258);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNome.Location = new System.Drawing.Point(40, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(155, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Professor ( Nome )";
            // 
            // pcbProfessor
            // 
            this.pcbProfessor.BackgroundImage = global::TechManager.Properties.Resources.if_User_27887;
            this.pcbProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbProfessor.Location = new System.Drawing.Point(58, 25);
            this.pcbProfessor.Name = "pcbProfessor";
            this.pcbProfessor.Size = new System.Drawing.Size(118, 106);
            this.pcbProfessor.TabIndex = 0;
            this.pcbProfessor.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 20;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.Chocolate;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.Chocolate;
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Enviar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 20;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.White;
            this.btnEnviar.IdleForecolor = System.Drawing.Color.Chocolate;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.Chocolate;
            this.btnEnviar.Location = new System.Drawing.Point(261, 551);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(150, 41);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnAdve);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 614);
            this.panel1.TabIndex = 18;
            // 
            // btnAdve
            // 
            this.btnAdve.Active = false;
            this.btnAdve.Activecolor = System.Drawing.Color.Goldenrod;
            this.btnAdve.BackColor = System.Drawing.Color.Silver;
            this.btnAdve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdve.BorderRadius = 0;
            this.btnAdve.ButtonText = "Advertencias";
            this.btnAdve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdve.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdve.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdve.Iconimage = global::TechManager.Properties.Resources.error_warning_alert_attention_512;
            this.btnAdve.Iconimage_right = null;
            this.btnAdve.Iconimage_right_Selected = null;
            this.btnAdve.Iconimage_Selected = null;
            this.btnAdve.IconMarginLeft = 0;
            this.btnAdve.IconMarginRight = 0;
            this.btnAdve.IconRightVisible = true;
            this.btnAdve.IconRightZoom = 0D;
            this.btnAdve.IconVisible = true;
            this.btnAdve.IconZoom = 90D;
            this.btnAdve.IsTab = false;
            this.btnAdve.Location = new System.Drawing.Point(13, 368);
            this.btnAdve.Name = "btnAdve";
            this.btnAdve.Normalcolor = System.Drawing.Color.Silver;
            this.btnAdve.OnHovercolor = System.Drawing.Color.Brown;
            this.btnAdve.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdve.selected = false;
            this.btnAdve.Size = new System.Drawing.Size(206, 53);
            this.btnAdve.TabIndex = 6;
            this.btnAdve.Text = "Advertencias";
            this.btnAdve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdve.Textcolor = System.Drawing.Color.DarkRed;
            this.btnAdve.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdve.Click += new System.EventHandler(this.btnAdve_Click);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Problema";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID Máquina";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Peru;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(305, 299);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(542, 177);
            this.bunifuCustomDataGrid1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Aula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Problema";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(414, 57);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(154, 20);
            this.txtAula.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(414, 100);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(188, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtProblema
            // 
            this.txtProblema.Location = new System.Drawing.Point(413, 139);
            this.txtProblema.Multiline = true;
            this.txtProblema.Name = "txtProblema";
            this.txtProblema.Size = new System.Drawing.Size(238, 127);
            this.txtProblema.TabIndex = 3;
            // 
            // btnCacnelar
            // 
            this.btnCacnelar.ActiveBorderThickness = 1;
            this.btnCacnelar.ActiveCornerRadius = 20;
            this.btnCacnelar.ActiveFillColor = System.Drawing.Color.Chocolate;
            this.btnCacnelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCacnelar.ActiveLineColor = System.Drawing.Color.Chocolate;
            this.btnCacnelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCacnelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCacnelar.BackgroundImage")));
            this.btnCacnelar.ButtonText = "Cancelar";
            this.btnCacnelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCacnelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCacnelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCacnelar.IdleBorderThickness = 1;
            this.btnCacnelar.IdleCornerRadius = 20;
            this.btnCacnelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCacnelar.IdleForecolor = System.Drawing.Color.Chocolate;
            this.btnCacnelar.IdleLineColor = System.Drawing.Color.Chocolate;
            this.btnCacnelar.Location = new System.Drawing.Point(741, 550);
            this.btnCacnelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCacnelar.Name = "btnCacnelar";
            this.btnCacnelar.Size = new System.Drawing.Size(150, 41);
            this.btnCacnelar.TabIndex = 24;
            this.btnCacnelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcluir
            // 
            this.btnExcluir.ActiveBorderThickness = 1;
            this.btnExcluir.ActiveCornerRadius = 20;
            this.btnExcluir.ActiveFillColor = System.Drawing.Color.Chocolate;
            this.btnExcluir.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcluir.ActiveLineColor = System.Drawing.Color.Chocolate;
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.ButtonText = "Excluir";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExcluir.IdleBorderThickness = 1;
            this.btnExcluir.IdleCornerRadius = 20;
            this.btnExcluir.IdleFillColor = System.Drawing.Color.White;
            this.btnExcluir.IdleForecolor = System.Drawing.Color.Chocolate;
            this.btnExcluir.IdleLineColor = System.Drawing.Color.Chocolate;
            this.btnExcluir.Location = new System.Drawing.Point(581, 550);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(150, 41);
            this.btnExcluir.TabIndex = 25;
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlterar
            // 
            this.btnAlterar.ActiveBorderThickness = 1;
            this.btnAlterar.ActiveCornerRadius = 20;
            this.btnAlterar.ActiveFillColor = System.Drawing.Color.Chocolate;
            this.btnAlterar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAlterar.ActiveLineColor = System.Drawing.Color.Chocolate;
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
            this.btnAlterar.ButtonText = "Alterar";
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAlterar.IdleBorderThickness = 1;
            this.btnAlterar.IdleCornerRadius = 20;
            this.btnAlterar.IdleFillColor = System.Drawing.Color.White;
            this.btnAlterar.IdleForecolor = System.Drawing.Color.Chocolate;
            this.btnAlterar.IdleLineColor = System.Drawing.Color.Chocolate;
            this.btnAlterar.Location = new System.Drawing.Point(421, 550);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(150, 41);
            this.btnAlterar.TabIndex = 26;
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(645, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(714, 51);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 25);
            this.lblData.TabIndex = 28;
            this.lblData.Text = "Aula";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Clique para mostrar";
            this.notifyIcon1.Visible = true;
            // 
            // frmProblemaProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 614);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCacnelar);
            this.Controls.Add(this.txtProblema);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmProblemaProf";
            this.Text = "Problema";
            this.Load += new System.EventHandler(this.frmProblema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtProblema;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCacnelar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcluir;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}