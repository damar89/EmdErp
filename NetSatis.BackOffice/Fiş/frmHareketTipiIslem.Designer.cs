namespace NetSatis.BackOffice.Fiş
{
    partial class frmHareketTipiIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHareketTipiIslem));
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKodu = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl19.Appearance.Options.UseBorderColor = true;
            this.labelControl19.Appearance.Options.UseTextOptions = true;
            this.labelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl19.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl19.Location = new System.Drawing.Point(8, 35);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(91, 17);
            this.labelControl19.TabIndex = 19;
            this.labelControl19.Text = "Açıklama :";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl15.Appearance.Options.UseBorderColor = true;
            this.labelControl15.Appearance.Options.UseTextOptions = true;
            this.labelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl15.Location = new System.Drawing.Point(10, 9);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(91, 17);
            this.labelControl15.TabIndex = 20;
            this.labelControl15.Text = "Kodu :";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(105, 34);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(244, 20);
            this.txtAdi.TabIndex = 18;
            // 
            // txtKodu
            // 
            this.txtKodu.Location = new System.Drawing.Point(105, 8);
            this.txtKodu.Name = "txtKodu";
            this.txtKodu.Size = new System.Drawing.Size(244, 20);
            this.txtKodu.TabIndex = 17;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnKapat);
            this.groupControl4.Controls.Add(this.btnKaydet);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 56);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(354, 54);
            this.groupControl4.TabIndex = 21;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(264, 20);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = " Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.Location = new System.Drawing.Point(173, 20);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 31);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmHareketTipiIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 110);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.labelControl19);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.txtKodu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHareketTipiIslem";
            this.ShowIcon = false;
            this.Text = "Hareket Tipi İşlem";
            ((System.ComponentModel.ISupportInitialize)(this.txtAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit txtAdi;
        private DevExpress.XtraEditors.TextEdit txtKodu;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}