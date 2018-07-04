namespace TechManager
{
    partial class frmPerfilTec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilTec));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStand = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHist = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbFotoTec = new System.Windows.Forms.PictureBox();
            this.btnErro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoTec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnStand);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnHist);
            this.panel1.Controls.Add(this.btnAdve);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbFotoTec);
            this.panel1.Controls.Add(this.btnErro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 768);
            this.panel1.TabIndex = 8;
            // 
            // btnStand
            // 
            this.btnStand.Active = false;
            this.btnStand.Activecolor = System.Drawing.Color.Silver;
            this.btnStand.BackColor = System.Drawing.Color.Silver;
            this.btnStand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStand.BorderRadius = 0;
            this.btnStand.ButtonText = "Modo StandBy";
            this.btnStand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStand.DisabledColor = System.Drawing.Color.Gray;
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStand.Iconimage = global::TechManager.Properties.Resources.sleep__2_;
            this.btnStand.Iconimage_right = null;
            this.btnStand.Iconimage_right_Selected = null;
            this.btnStand.Iconimage_Selected = null;
            this.btnStand.IconMarginLeft = 0;
            this.btnStand.IconMarginRight = 0;
            this.btnStand.IconRightVisible = true;
            this.btnStand.IconRightZoom = 0D;
            this.btnStand.IconVisible = true;
            this.btnStand.IconZoom = 90D;
            this.btnStand.IsTab = false;
            this.btnStand.Location = new System.Drawing.Point(32, 553);
            this.btnStand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStand.Name = "btnStand";
            this.btnStand.Normalcolor = System.Drawing.Color.Silver;
            this.btnStand.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btnStand.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStand.selected = false;
            this.btnStand.Size = new System.Drawing.Size(233, 64);
            this.btnStand.TabIndex = 9;
            this.btnStand.Text = "Modo StandBy";
            this.btnStand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStand.Textcolor = System.Drawing.Color.DarkRed;
            this.btnStand.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::TechManager.Properties.Resources.oie_transparent;
            this.btnSair.ImageActive = global::TechManager.Properties.Resources.oie_transparent__3_;
            this.btnSair.Location = new System.Drawing.Point(111, 690);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 78);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 3;
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 10;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnHist
            // 
            this.btnHist.Active = false;
            this.btnHist.Activecolor = System.Drawing.Color.Silver;
            this.btnHist.BackColor = System.Drawing.Color.Silver;
            this.btnHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHist.BorderRadius = 0;
            this.btnHist.ButtonText = "Verificar Histórico";
            this.btnHist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHist.DisabledColor = System.Drawing.Color.Gray;
            this.btnHist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHist.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHist.Iconimage = global::TechManager.Properties.Resources.list;
            this.btnHist.Iconimage_right = null;
            this.btnHist.Iconimage_right_Selected = null;
            this.btnHist.Iconimage_Selected = null;
            this.btnHist.IconMarginLeft = 0;
            this.btnHist.IconMarginRight = 0;
            this.btnHist.IconRightVisible = true;
            this.btnHist.IconRightZoom = 0D;
            this.btnHist.IconVisible = true;
            this.btnHist.IconZoom = 90D;
            this.btnHist.IsTab = false;
            this.btnHist.Location = new System.Drawing.Point(32, 464);
            this.btnHist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHist.Name = "btnHist";
            this.btnHist.Normalcolor = System.Drawing.Color.Silver;
            this.btnHist.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.btnHist.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHist.selected = false;
            this.btnHist.Size = new System.Drawing.Size(233, 64);
            this.btnHist.TabIndex = 8;
            this.btnHist.Text = "Verificar Histórico";
            this.btnHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHist.Textcolor = System.Drawing.Color.DarkRed;
            this.btnHist.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHist.Click += new System.EventHandler(this.btnHist_Click);
            // 
            // btnAdve
            // 
            this.btnAdve.Active = false;
            this.btnAdve.Activecolor = System.Drawing.Color.Silver;
            this.btnAdve.BackColor = System.Drawing.Color.Silver;
            this.btnAdve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdve.BorderRadius = 0;
            this.btnAdve.ButtonText = "Checar Avisos";
            this.btnAdve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdve.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdve.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdve.Iconimage = global::TechManager.Properties.Resources.warning_alert_attention_search_512;
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
            this.btnAdve.Location = new System.Drawing.Point(32, 375);
            this.btnAdve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdve.Name = "btnAdve";
            this.btnAdve.Normalcolor = System.Drawing.Color.Silver;
            this.btnAdve.OnHovercolor = System.Drawing.Color.BurlyWood;
            this.btnAdve.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdve.selected = false;
            this.btnAdve.Size = new System.Drawing.Size(233, 64);
            this.btnAdve.TabIndex = 6;
            this.btnAdve.Text = "Checar Avisos";
            this.btnAdve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdve.Textcolor = System.Drawing.Color.DarkRed;
            this.btnAdve.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdve.Click += new System.EventHandler(this.btnAdve_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(83, 191);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(105, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "tEC ( Nome )";
            // 
            // pcbFotoTec
            // 
            this.pcbFotoTec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbFotoTec.Image = global::TechManager.Properties.Resources.tec1;
            this.pcbFotoTec.Location = new System.Drawing.Point(61, 39);
            this.pcbFotoTec.Name = "pcbFotoTec";
            this.pcbFotoTec.Size = new System.Drawing.Size(145, 149);
            this.pcbFotoTec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoTec.TabIndex = 0;
            this.pcbFotoTec.TabStop = false;
            this.pcbFotoTec.Click += new System.EventHandler(this.pcbFotoTec_Click);
            // 
            // btnErro
            // 
            this.btnErro.Active = false;
            this.btnErro.Activecolor = System.Drawing.Color.Silver;
            this.btnErro.BackColor = System.Drawing.Color.Silver;
            this.btnErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnErro.BorderRadius = 0;
            this.btnErro.ButtonText = "Ver Problemas";
            this.btnErro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnErro.DisabledColor = System.Drawing.Color.Gray;
            this.btnErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnErro.Iconimage = global::TechManager.Properties.Resources.error_warning_alert_attention_512;
            this.btnErro.Iconimage_right = null;
            this.btnErro.Iconimage_right_Selected = null;
            this.btnErro.Iconimage_Selected = null;
            this.btnErro.IconMarginLeft = 0;
            this.btnErro.IconMarginRight = 0;
            this.btnErro.IconRightVisible = true;
            this.btnErro.IconRightZoom = 0D;
            this.btnErro.IconVisible = true;
            this.btnErro.IconZoom = 90D;
            this.btnErro.IsTab = false;
            this.btnErro.Location = new System.Drawing.Point(32, 286);
            this.btnErro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnErro.Name = "btnErro";
            this.btnErro.Normalcolor = System.Drawing.Color.Silver;
            this.btnErro.OnHovercolor = System.Drawing.Color.Maroon;
            this.btnErro.OnHoverTextColor = System.Drawing.Color.White;
            this.btnErro.selected = false;
            this.btnErro.Size = new System.Drawing.Size(233, 64);
            this.btnErro.TabIndex = 7;
            this.btnErro.Text = "Ver Problemas";
            this.btnErro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErro.Textcolor = System.Drawing.Color.DarkRed;
            this.btnErro.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErro.Click += new System.EventHandler(this.btnErro_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TechManager.Properties.Resources.etec_2018_inscricoes_11;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(388, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 303);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(981, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(455, 419);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Sobre");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Operando em modo StandBy, clique para abrir novamente";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 800;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon2_MouseDoubleClick);
            // 
            // frmPerfilTec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfilTec";
            this.Text = "Menu Técnico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPerfilTec_FormClosed);
            this.Load += new System.EventHandler(this.frmPerfilTec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoTec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStand;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private Bunifu.Framework.UI.BunifuFlatButton btnHist;
        private Bunifu.Framework.UI.BunifuFlatButton btnErro;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdve;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbFotoTec;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}