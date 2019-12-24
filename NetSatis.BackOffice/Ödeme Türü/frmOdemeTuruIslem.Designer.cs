namespace NetSatis.BackOffice.Ödeme_Türü
{
    partial class frmOdemeTuruIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOdemeTuruIslem));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtOdemeTuruAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtOdemeTuruKodu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 192);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 54);
            this.groupControl1.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(276, 20);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = " Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "user.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(185, 20);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 31);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl19);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.txtOdemeTuruAdi);
            this.groupControl2.Controls.Add(this.txtOdemeTuruKodu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(366, 82);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Ödeme Bilgileri";
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl19.Appearance.Options.UseBorderColor = true;
            this.labelControl19.Appearance.Options.UseTextOptions = true;
            this.labelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl19.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl19.Location = new System.Drawing.Point(5, 51);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(101, 19);
            this.labelControl19.TabIndex = 11;
            this.labelControl19.Text = "Ödeme Türü Adı:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl15.Appearance.Options.UseBorderColor = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl15.Location = new System.Drawing.Point(7, 25);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(101, 19);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "Ödeme Türü Kodu :";
            // 
            // txtOdemeTuruAdi
            // 
            this.txtOdemeTuruAdi.Location = new System.Drawing.Point(112, 50);
            this.txtOdemeTuruAdi.Name = "txtOdemeTuruAdi";
            this.txtOdemeTuruAdi.Size = new System.Drawing.Size(242, 20);
            this.txtOdemeTuruAdi.TabIndex = 1;
            // 
            // txtOdemeTuruKodu
            // 
            this.txtOdemeTuruKodu.Location = new System.Drawing.Point(114, 24);
            this.txtOdemeTuruKodu.Name = "txtOdemeTuruKodu";
            this.txtOdemeTuruKodu.Size = new System.Drawing.Size(128, 20);
            this.txtOdemeTuruKodu.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtAciklama);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(0, 82);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(366, 110);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Diğer Bilgiler";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(104, 23);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(261, 61);
            this.txtAciklama.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(4, 23);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(99, 61);
            this.labelControl10.TabIndex = 8;
            this.labelControl10.Text = "Açıklama :";
            // 
            // frmOdemeTuruIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 246);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOdemeTuruIslem";
            this.ShowIcon = false;
            this.Text = "Ödeme Türü İşlem";
            this.Load += new System.EventHandler(this.frmOdemeTuruIslem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOdemeTuruIslem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuruKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtOdemeTuruAdi;
        private DevExpress.XtraEditors.TextEdit txtOdemeTuruKodu;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}