namespace TechManager
{
    partial class frmAdvertenciaTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvertenciaTecnico));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblApague = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdvert = new System.Windows.Forms.TextBox();
            this.btnEnviar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPC = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblApague);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Location = new System.Drawing.Point(1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 616);
            this.panel1.TabIndex = 1;
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
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::TechManager.Properties.Resources.back2;
            this.bunifuImageButton2.ImageActive = global::TechManager.Properties.Resources.back__1_;
            this.bunifuImageButton2.Location = new System.Drawing.Point(12, 533);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(76, 60);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-43, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(306, 258);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblApague
            // 
            this.lblApague.AutoSize = true;
            this.lblApague.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApague.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblApague.Location = new System.Drawing.Point(55, 7);
            this.lblApague.Name = "lblApague";
            this.lblApague.Size = new System.Drawing.Size(98, 15);
            this.lblApague.TabIndex = 5;
            this.lblApague.Text = "//Foto do usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(40, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Professor ( Nome )";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(440, 264);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(174, 26);
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Advertência";
            // 
            // txtAdvert
            // 
            this.txtAdvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvert.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtAdvert.Location = new System.Drawing.Point(440, 316);
            this.txtAdvert.Name = "txtAdvert";
            this.txtAdvert.Size = new System.Drawing.Size(295, 26);
            this.txtAdvert.TabIndex = 2;
            this.txtAdvert.Text = "Escreva sua Advertência (Opcional)";
            // 
            // btnEnviar
            // 
            this.btnEnviar.ActiveBorderThickness = 1;
            this.btnEnviar.ActiveCornerRadius = 20;
            this.btnEnviar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEnviar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviar.BackgroundImage")));
            this.btnEnviar.ButtonText = "Enviar";
            this.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.IdleBorderThickness = 1;
            this.btnEnviar.IdleCornerRadius = 20;
            this.btnEnviar.IdleFillColor = System.Drawing.Color.White;
            this.btnEnviar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEnviar.Location = new System.Drawing.Point(593, 548);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(181, 41);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ActiveBorderThickness = 1;
            this.btnCancelar.ActiveCornerRadius = 20;
            this.btnCancelar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancelar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleBorderThickness = 1;
            this.btnCancelar.IdleCornerRadius = 20;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.White;
            this.btnCancelar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCancelar.Location = new System.Drawing.Point(326, 547);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(181, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Column1
            // 
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            // 
            // grdPC
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdPC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPC.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grdPC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdPC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdPC.DoubleBuffered = true;
            this.grdPC.EnableHeadersVisualStyles = false;
            this.grdPC.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.grdPC.HeaderForeColor = System.Drawing.Color.White;
            this.grdPC.Location = new System.Drawing.Point(288, 21);
            this.grdPC.Name = "grdPC";
            this.grdPC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdPC.Size = new System.Drawing.Size(542, 189);
            this.grdPC.TabIndex = 2;
            // 
            // frmAdvertenciaTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 605);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtAdvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grdPC);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdvertenciaTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advertencia Tecnico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.Label lblApague;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdvert;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEnviar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid grdPC;
    }
}