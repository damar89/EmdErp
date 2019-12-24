namespace NetSatis.BackOffice.Tanım
{
    partial class frmAnaGrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaGrup));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtAnaGrupAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtAnaGrupKodu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnaGrupAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnaGrupKodu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 81);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 54);
            this.groupControl1.TabIndex = 3;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 3;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(271, 20);
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
            this.ımageList1.Images.SetKeyName(3, "içıkış.png");
            this.ımageList1.Images.SetKeyName(4, "ikaydet.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 4;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(180, 20);
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
            this.groupControl2.Controls.Add(this.txtAnaGrupAdi);
            this.groupControl2.Controls.Add(this.txtAnaGrupKodu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(361, 81);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "AnaGrup Bilgileri";
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
            this.labelControl19.Size = new System.Drawing.Size(91, 17);
            this.labelControl19.TabIndex = 11;
            this.labelControl19.Text = "AnaGrup Adı :";
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
            this.labelControl15.Size = new System.Drawing.Size(91, 17);
            this.labelControl15.TabIndex = 12;
            this.labelControl15.Text = "AnaGrup Kodu :";
            // 
            // txtAnaGrupAdi
            // 
            this.txtAnaGrupAdi.Location = new System.Drawing.Point(102, 50);
            this.txtAnaGrupAdi.Name = "txtAnaGrupAdi";
            this.txtAnaGrupAdi.Size = new System.Drawing.Size(252, 20);
            this.txtAnaGrupAdi.TabIndex = 1;
            // 
            // txtAnaGrupKodu
            // 
            this.txtAnaGrupKodu.Location = new System.Drawing.Point(104, 24);
            this.txtAnaGrupKodu.Name = "txtAnaGrupKodu";
            this.txtAnaGrupKodu.Size = new System.Drawing.Size(128, 20);
            this.txtAnaGrupKodu.TabIndex = 0;
            // 
            // frmAnaGrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 135);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnaGrup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaGrup İşlemleri";
            this.Load += new System.EventHandler(this.frmAnaGrup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAnaGrup_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAnaGrupAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnaGrupKodu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtAnaGrupAdi;
        private DevExpress.XtraEditors.TextEdit txtAnaGrupKodu;
    }
}