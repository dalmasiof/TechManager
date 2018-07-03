namespace TechManager
{
    partial class frmPerfilAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilAdm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStand = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAltera = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.pcbFotoProf = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnStand);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAltera);
            this.panel1.Controls.Add(this.btnCad);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.pcbFotoProf);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 768);
            this.panel1.TabIndex = 1;
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
            this.toolTip1.SetToolTip(this.btnStand, "Modo StandBy");
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::TechManager.Properties.Resources.oie_transparent;
            this.btnSair.ImageActive = global::TechManager.Properties.Resources.oie_transparent__3_;
            this.btnSair.Location = new System.Drawing.Point(104, 688);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 77);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 3;
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 10;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDel
            // 
            this.btnDel.Active = false;
            this.btnDel.Activecolor = System.Drawing.Color.Silver;
            this.btnDel.BackColor = System.Drawing.Color.Silver;
            this.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDel.BorderRadius = 0;
            this.btnDel.ButtonText = "Deletar Usuário";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.DisabledColor = System.Drawing.Color.Gray;
            this.btnDel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDel.Iconimage = global::TechManager.Properties.Resources.if_f_cross_256_282471;
            this.btnDel.Iconimage_right = null;
            this.btnDel.Iconimage_right_Selected = null;
            this.btnDel.Iconimage_Selected = null;
            this.btnDel.IconMarginLeft = 0;
            this.btnDel.IconMarginRight = 0;
            this.btnDel.IconRightVisible = true;
            this.btnDel.IconRightZoom = 0D;
            this.btnDel.IconVisible = true;
            this.btnDel.IconZoom = 90D;
            this.btnDel.IsTab = false;
            this.btnDel.Location = new System.Drawing.Point(32, 464);
            this.btnDel.Name = "btnDel";
            this.btnDel.Normalcolor = System.Drawing.Color.Silver;
            this.btnDel.OnHovercolor = System.Drawing.Color.Brown;
            this.btnDel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDel.selected = false;
            this.btnDel.Size = new System.Drawing.Size(233, 64);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Deletar Usuário";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Textcolor = System.Drawing.Color.DarkRed;
            this.btnDel.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnDel, "Deletar Usuário");
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAltera
            // 
            this.btnAltera.Active = false;
            this.btnAltera.Activecolor = System.Drawing.Color.Silver;
            this.btnAltera.BackColor = System.Drawing.Color.Silver;
            this.btnAltera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAltera.BorderRadius = 0;
            this.btnAltera.ButtonText = "Alterar Usuário";
            this.btnAltera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltera.DisabledColor = System.Drawing.Color.Gray;
            this.btnAltera.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAltera.Iconimage = global::TechManager.Properties.Resources.if_button_blue_repeat_40719;
            this.btnAltera.Iconimage_right = null;
            this.btnAltera.Iconimage_right_Selected = null;
            this.btnAltera.Iconimage_Selected = null;
            this.btnAltera.IconMarginLeft = 0;
            this.btnAltera.IconMarginRight = 0;
            this.btnAltera.IconRightVisible = true;
            this.btnAltera.IconRightZoom = 0D;
            this.btnAltera.IconVisible = true;
            this.btnAltera.IconZoom = 90D;
            this.btnAltera.IsTab = false;
            this.btnAltera.Location = new System.Drawing.Point(32, 375);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Normalcolor = System.Drawing.Color.Silver;
            this.btnAltera.OnHovercolor = System.Drawing.Color.MediumAquamarine;
            this.btnAltera.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAltera.selected = false;
            this.btnAltera.Size = new System.Drawing.Size(233, 64);
            this.btnAltera.TabIndex = 8;
            this.btnAltera.Text = "Alterar Usuário";
            this.btnAltera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltera.Textcolor = System.Drawing.Color.DarkRed;
            this.btnAltera.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnAltera, "Alterar Usuário");
            this.btnAltera.Click += new System.EventHandler(this.btnAltera_Click);
            // 
            // btnCad
            // 
            this.btnCad.Active = false;
            this.btnCad.Activecolor = System.Drawing.Color.Silver;
            this.btnCad.BackColor = System.Drawing.Color.Silver;
            this.btnCad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCad.BorderRadius = 0;
            this.btnCad.ButtonText = "Cadastrar Usuário";
            this.btnCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCad.DisabledColor = System.Drawing.Color.Gray;
            this.btnCad.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCad.Iconimage = global::TechManager.Properties.Resources.user_namecard_128;
            this.btnCad.Iconimage_right = null;
            this.btnCad.Iconimage_right_Selected = null;
            this.btnCad.Iconimage_Selected = null;
            this.btnCad.IconMarginLeft = 0;
            this.btnCad.IconMarginRight = 0;
            this.btnCad.IconRightVisible = true;
            this.btnCad.IconRightZoom = 0D;
            this.btnCad.IconVisible = true;
            this.btnCad.IconZoom = 90D;
            this.btnCad.IsTab = false;
            this.btnCad.Location = new System.Drawing.Point(32, 286);
            this.btnCad.Name = "btnCad";
            this.btnCad.Normalcolor = System.Drawing.Color.Silver;
            this.btnCad.OnHovercolor = System.Drawing.Color.LightGreen;
            this.btnCad.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCad.selected = false;
            this.btnCad.Size = new System.Drawing.Size(233, 64);
            this.btnCad.TabIndex = 7;
            this.btnCad.Text = "Cadastrar Usuário";
            this.btnCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCad.Textcolor = System.Drawing.Color.DarkRed;
            this.btnCad.TextFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTip1.SetToolTip(this.btnCad, "Cadastrar usuário");
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(100, 205);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(116, 23);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Adm ( Nome )";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbFotoProf
            // 
            this.pcbFotoProf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbFotoProf.Image = global::TechManager.Properties.Resources.adm;
            this.pcbFotoProf.Location = new System.Drawing.Point(83, 35);
            this.pcbFotoProf.Name = "pcbFotoProf";
            this.pcbFotoProf.Size = new System.Drawing.Size(145, 149);
            this.pcbFotoProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoProf.TabIndex = 0;
            this.pcbFotoProf.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TechManager.Properties.Resources.etec_2018_inscricoes_11;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(388, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(395, 303);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "ETEC");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TechManager.Properties.Resources.logoTCC11;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(981, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(455, 419);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Sobre");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Operando em modo StandBy, clique para abrir novamente";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // frmPerfilAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPerfilAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPerfilAdm_FormClosed);
            this.Load += new System.EventHandler(this.frmPerfilAdm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStand;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private Bunifu.Framework.UI.BunifuFlatButton btnAltera;
        private Bunifu.Framework.UI.BunifuFlatButton btnCad;
        private Bunifu.Framework.UI.BunifuFlatButton btnDel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pcbFotoProf;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}