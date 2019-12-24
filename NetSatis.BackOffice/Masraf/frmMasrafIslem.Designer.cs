namespace NetSatis.BackOffice.Masraf
{
    partial class frmMasrafIslem
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.grupGenel = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtMasrafAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKod = new DevExpress.XtraEditors.TextEdit();
            this.togDurum = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrup = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grupGenel)).BeginInit();
            this.grupGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasrafAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.togDurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(395, 0);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 237);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 237);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Size = new System.Drawing.Size(0, 0);
            // 
            // grupGenel
            // 
            this.grupGenel.Controls.Add(this.txtAciklama);
            this.grupGenel.Controls.Add(this.txtMasrafAdi);
            this.grupGenel.Controls.Add(this.txtKod);
            this.grupGenel.Controls.Add(this.togDurum);
            this.grupGenel.Controls.Add(this.labelControl6);
            this.grupGenel.Controls.Add(this.labelControl4);
            this.grupGenel.Controls.Add(this.labelControl10);
            this.grupGenel.Controls.Add(this.labelControl2);
            this.grupGenel.Controls.Add(this.labelControl1);
            this.grupGenel.Controls.Add(this.txtGrup);
            this.grupGenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grupGenel.Location = new System.Drawing.Point(0, 0);
            this.grupGenel.Name = "grupGenel";
            this.grupGenel.Size = new System.Drawing.Size(395, 237);
            this.grupGenel.TabIndex = 9;
            this.grupGenel.Text = "Genel Bilgiler";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(109, 132);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(267, 42);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtMasrafAdi
            // 
            this.txtMasrafAdi.Location = new System.Drawing.Point(110, 81);
            this.txtMasrafAdi.Name = "txtMasrafAdi";
            this.txtMasrafAdi.Size = new System.Drawing.Size(266, 20);
            this.txtMasrafAdi.TabIndex = 3;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(109, 55);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(185, 20);
            this.txtKod.TabIndex = 0;
            // 
            // togDurum
            // 
            this.togDurum.EditValue = true;
            this.togDurum.ImeMode = System.Windows.Forms.ImeMode.On;
            this.togDurum.Location = new System.Drawing.Point(110, 30);
            this.togDurum.Name = "togDurum";
            this.togDurum.Properties.OffText = "Pasif";
            this.togDurum.Properties.OnText = "Aktif";
            this.togDurum.Size = new System.Drawing.Size(95, 24);
            this.togDurum.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl6.Appearance.Options.UseBorderColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(13, 105);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 17);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Grup :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl4.Appearance.Options.UseBorderColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl4.Location = new System.Drawing.Point(14, 82);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 17);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Masraf Adı :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(14, 128);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 46);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Açıklama :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Masraf Kodu :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(13, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "  Durumu :";
            // 
            // txtGrup
            // 
            this.txtGrup.Location = new System.Drawing.Point(110, 104);
            this.txtGrup.Name = "txtGrup";
            editorButtonImageOptions1.ImageUri.Uri = "Add;Size16x16";
            editorButtonImageOptions2.ImageUri.Uri = "Delete;Size16x16";
            this.txtGrup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions1, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null),
            new DevExpress.XtraEditors.Controls.EditorButton(editorButtonImageOptions2, DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, null)});
            this.txtGrup.Size = new System.Drawing.Size(136, 22);
            this.txtGrup.TabIndex = 4;
            this.txtGrup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtGrup_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 180);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 57);
            this.groupControl1.TabIndex = 12;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 1;
            this.btnKapat.Location = new System.Drawing.Point(305, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Appearance.Options.UseTextOptions = true;
            this.btnKaydet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnKaydet.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.btnKaydet.ImageOptions.ImageIndex = 0;
            this.btnKaydet.Location = new System.Drawing.Point(214, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 31);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmMasrafIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 237);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grupGenel);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlLeft);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasrafIslem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf İşlem";
            this.Load += new System.EventHandler(this.frmMasrafIslem_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMasrafIslem_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grupGenel)).EndInit();
            this.grupGenel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMasrafAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.togDurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraEditors.GroupControl grupGenel;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.TextEdit txtMasrafAdi;
        private DevExpress.XtraEditors.TextEdit txtKod;
        private DevExpress.XtraEditors.ToggleSwitch togDurum;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtGrup;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}