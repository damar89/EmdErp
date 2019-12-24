namespace NetSatisAdmin
{
    partial class frmBaglantiAyarlari
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
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.chkWindows = new DevExpress.XtraEditors.CheckButton();
            this.chkSqlServer = new DevExpress.XtraEditors.CheckButton();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(392, 35);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Bağlantı Ayarları";
            // 
            // chkWindows
            // 
            this.chkWindows.Checked = true;
            this.chkWindows.GroupIndex = 1;
            this.chkWindows.Location = new System.Drawing.Point(12, 42);
            this.chkWindows.Name = "chkWindows";
            this.chkWindows.Size = new System.Drawing.Size(179, 78);
            this.chkWindows.TabIndex = 1;
            this.chkWindows.Text = "Windows Oturumu";
            // 
            // chkSqlServer
            // 
            this.chkSqlServer.GroupIndex = 1;
            this.chkSqlServer.Location = new System.Drawing.Point(197, 41);
            this.chkSqlServer.Name = "chkSqlServer";
            this.chkSqlServer.Size = new System.Drawing.Size(186, 80);
            this.chkSqlServer.TabIndex = 2;
            this.chkSqlServer.TabStop = false;
            this.chkSqlServer.Text = "SQL Server Oturumu";
            this.chkSqlServer.CheckedChanged += new System.EventHandler(this.chkSqlServer_CheckedChanged);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(109, 135);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(271, 20);
            this.txtServer.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 136);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 17);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Server Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(12, 162);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "DB Adı :";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(109, 161);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(271, 20);
            this.txtDatabase.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 188);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(91, 17);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(109, 187);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(271, 20);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(12, 214);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 17);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "Parola :";
            // 
            // txtParola
            // 
            this.txtParola.Enabled = false;
            this.txtParola.Location = new System.Drawing.Point(109, 213);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(271, 20);
            this.txtParola.TabIndex = 6;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 283);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(115, 38);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(265, 283);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(115, 38);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmBaglantiAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 333);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.chkSqlServer);
            this.Controls.Add(this.chkWindows);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBaglantiAyarlari";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bağlantı Ayarı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBaglantiAyarlari_FormClosing);
            this.Load += new System.EventHandler(this.frmBaglantiAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.CheckButton chkWindows;
        private DevExpress.XtraEditors.CheckButton chkSqlServer;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}