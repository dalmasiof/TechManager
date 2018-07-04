namespace TechManager
{
    partial class frmHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.dgvHist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolvido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.just = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbHist = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 768);
            this.panel1.TabIndex = 8;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton2.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.bunifuImageButton2.ImageActive = global::TechManager.Properties.Resources.if_go_home_118770;
            this.bunifuImageButton2.Location = new System.Drawing.Point(97, 633);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(118, 109);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 3;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(-49, 314);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(427, 330);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNome.Location = new System.Drawing.Point(92, 190);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(169, 26);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Professor ( Nome )";
            // 
            // pcbProfessor
            // 
            this.pcbProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbProfessor.Image = global::TechManager.Properties.Resources.logoTCC11;
            this.pcbProfessor.Location = new System.Drawing.Point(97, 12);
            this.pcbProfessor.Name = "pcbProfessor";
            this.pcbProfessor.Size = new System.Drawing.Size(145, 149);
            this.pcbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProfessor.TabIndex = 0;
            this.pcbProfessor.TabStop = false;
            // 
            // dgvHist
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHist.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.data,
            this.idMaquina,
            this.resolvido,
            this.adv,
            this.just});
            this.dgvHist.DoubleBuffered = true;
            this.dgvHist.EnableHeadersVisualStyles = false;
            this.dgvHist.HeaderBgColor = System.Drawing.Color.Brown;
            this.dgvHist.HeaderForeColor = System.Drawing.Color.White;
            this.dgvHist.Location = new System.Drawing.Point(415, 3);
            this.dgvHist.Name = "dgvHist";
            this.dgvHist.ReadOnly = true;
            this.dgvHist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHist.Size = new System.Drawing.Size(939, 387);
            this.dgvHist.TabIndex = 2;
            this.dgvHist.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHist_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "aula";
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "professor";
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "problema";
            this.Column4.HeaderText = "Problema";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // idMaquina
            // 
            this.idMaquina.DataPropertyName = "idMaquina";
            this.idMaquina.HeaderText = "ID";
            this.idMaquina.Name = "idMaquina";
            this.idMaquina.ReadOnly = true;
            // 
            // resolvido
            // 
            this.resolvido.DataPropertyName = "check";
            this.resolvido.HeaderText = "Resolvido?";
            this.resolvido.Name = "resolvido";
            this.resolvido.ReadOnly = true;
            // 
            // adv
            // 
            this.adv.DataPropertyName = "advertencia";
            this.adv.HeaderText = "Advertência";
            this.adv.Name = "adv";
            this.adv.ReadOnly = true;
            // 
            // just
            // 
            this.just.DataPropertyName = "justificativa";
            this.just.HeaderText = "Justificativa";
            this.just.Name = "just";
            this.just.ReadOnly = true;
            // 
            // cmbHist
            // 
            this.cmbHist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHist.BackColor = System.Drawing.SystemColors.Control;
            this.cmbHist.BorderRadius = 5;
            this.cmbHist.DisabledColor = System.Drawing.Color.Gray;
            this.cmbHist.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHist.ForeColor = System.Drawing.Color.White;
            this.cmbHist.Location = new System.Drawing.Point(481, 503);
            this.cmbHist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHist.Name = "cmbHist";
            this.cmbHist.NomalColor = System.Drawing.Color.CornflowerBlue;
            this.cmbHist.onHoverColor = System.Drawing.Color.Gray;
            this.cmbHist.selectedIndex = -1;
            this.cmbHist.Size = new System.Drawing.Size(243, 42);
            this.cmbHist.TabIndex = 0;
            this.cmbHist.onItemSelected += new System.EventHandler(this.cmbHist_onItemSelected);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUser.Location = new System.Drawing.Point(772, 519);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(253, 26);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // frmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cmbHist);
            this.Controls.Add(this.dgvHist);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histórico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvHist;
        private Bunifu.Framework.UI.BunifuDropdown cmbHist;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolvido;
        private System.Windows.Forms.DataGridViewTextBoxColumn adv;
        private System.Windows.Forms.DataGridViewTextBoxColumn just;
    }
}