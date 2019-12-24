namespace NetSatisAdmin
{
    partial class frmKullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciGiris));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnParolaUnuttum = new DevExpress.XtraEditors.SimpleButton();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.checkAnimsa = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnimsa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseImageAlign = true;
            this.lblBaslik.Appearance.Options.UseImageList = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(477, 35);
            this.lblBaslik.TabIndex = 9;
            this.lblBaslik.Text = "Kullanıcı Girişi";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGiris);
            this.groupControl1.Controls.Add(this.btnParolaUnuttum);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 173);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(477, 57);
            this.groupControl1.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 3;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(387, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = " Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "key.ico");
            this.ımageList1.Images.SetKeyName(1, "keyforgate.ico");
            this.ımageList1.Images.SetKeyName(2, "keygiris.ico");
            this.ımageList1.Images.SetKeyName(3, "folder_out.png");
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiris.ImageOptions.ImageIndex = 2;
            this.btnGiris.ImageOptions.ImageList = this.ımageList1;
            this.btnGiris.Location = new System.Drawing.Point(200, 23);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(85, 31);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnParolaUnuttum
            // 
            this.btnParolaUnuttum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParolaUnuttum.ImageOptions.ImageIndex = 1;
            this.btnParolaUnuttum.ImageOptions.ImageList = this.ımageList1;
            this.btnParolaUnuttum.Location = new System.Drawing.Point(291, 23);
            this.btnParolaUnuttum.Name = "btnParolaUnuttum";
            this.btnParolaUnuttum.Size = new System.Drawing.Size(90, 31);
            this.btnParolaUnuttum.TabIndex = 1;
            this.btnParolaUnuttum.Text = "Parolamı\r\nUnuttum";
            this.btnParolaUnuttum.Click += new System.EventHandler(this.btnParolaUnuttum_Click);
            // 
            // txtKullanici
            // 
            this.txtKullanici.Location = new System.Drawing.Point(135, 44);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Properties.ContextImageOptions.AllowChangeAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.txtKullanici.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtKullanici.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullanici.Properties.ContextImageOptions.Image")));
            this.txtKullanici.Size = new System.Drawing.Size(311, 36);
            this.txtKullanici.TabIndex = 0;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(135, 98);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Properties.ContextImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.txtParola.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImageOptions.Image")));
            this.txtParola.Properties.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(311, 36);
            this.txtParola.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(31, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(98, 37);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Kullanıcı Adı :";
            this.labelControl1.UseMnemonic = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(30, 97);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 37);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Parola :";
            this.labelControl2.UseMnemonic = false;
            // 
            // checkAnimsa
            // 
            this.checkAnimsa.Location = new System.Drawing.Point(135, 140);
            this.checkAnimsa.Name = "checkAnimsa";
            this.checkAnimsa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkAnimsa.Properties.Appearance.Options.UseFont = true;
            this.checkAnimsa.Properties.AutoHeight = false;
            this.checkAnimsa.Properties.Caption = "Beni Anımsa";
            this.checkAnimsa.Size = new System.Drawing.Size(130, 34);
            this.checkAnimsa.TabIndex = 2;
            // 
            // frmKullaniciGiris
            // 
            this.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 230);
            this.Controls.Add(this.checkAnimsa);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKullaniciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmKullaniciGiris_FormClosed);
            this.Load += new System.EventHandler(this.frmKullaniciGiris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKullaniciGiris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAnimsa.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnParolaUnuttum;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit checkAnimsa;
    }
}