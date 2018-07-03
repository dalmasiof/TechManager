namespace TechManager
{
    partial class frmProblemaTec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProblemaTec));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbProfessor = new System.Windows.Forms.PictureBox();
            this.dgvProb = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 768);
            this.panel1.TabIndex = 19;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::TechManager.Properties.Resources.if_go_home_118770__2_;
            this.btnVoltar.ImageActive = global::TechManager.Properties.Resources.if_go_home_118770;
            this.btnVoltar.Location = new System.Drawing.Point(97, 656);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(118, 109);
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
            this.pictureBox3.Location = new System.Drawing.Point(-22, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(345, 319);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNome.Location = new System.Drawing.Point(80, 179);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(135, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "tecnico ( Nome )";
            // 
            // pcbProfessor
            // 
            this.pcbProfessor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbProfessor.Image = global::TechManager.Properties.Resources.tec1;
            this.pcbProfessor.Location = new System.Drawing.Point(70, 21);
            this.pcbProfessor.Name = "pcbProfessor";
            this.pcbProfessor.Size = new System.Drawing.Size(145, 149);
            this.pcbProfessor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProfessor.TabIndex = 0;
            this.pcbProfessor.TabStop = false;
            // 
            // dgvProb
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProb.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProb.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProb.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProb.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cheka,
            this.id,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.check});
            this.dgvProb.DoubleBuffered = true;
            this.dgvProb.EnableHeadersVisualStyles = false;
            this.dgvProb.HeaderBgColor = System.Drawing.Color.Peru;
            this.dgvProb.HeaderForeColor = System.Drawing.Color.White;
            this.dgvProb.Location = new System.Drawing.Point(448, 173);
            this.dgvProb.Name = "dgvProb";
            this.dgvProb.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvProb.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProb.Size = new System.Drawing.Size(764, 373);
            this.dgvProb.TabIndex = 20;
            this.dgvProb.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProb_CellEndEdit);
            this.dgvProb.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProb_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "aula";
            this.Column1.HeaderText = "Aula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // cheka
            // 
            this.cheka.DataPropertyName = "Check";
            this.cheka.HeaderText = "Teste";
            this.cheka.Name = "cheka";
            this.cheka.Visible = false;
            // 
            // id
            // 
            this.id.DataPropertyName = "idProb";
            this.id.HeaderText = "Column6";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "professor";
            this.Column2.HeaderText = "Professor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "idmaquina";
            this.Column3.HeaderText = "ID Máquina";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "problema";
            this.Column4.HeaderText = "Problema";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "data";
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // check
            // 
            this.check.HeaderText = "Resolver";
            this.check.Name = "check";
            // 
            // frmProblemaTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.dgvProb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProblemaTec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Problemas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProblemaTec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbProfessor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cheka;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}