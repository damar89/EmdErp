namespace NetSatis.BackOffice.Fiş
{
    partial class frmMasrafEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasrafEkrani));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnKasaSec = new DevExpress.XtraEditors.SimpleButton();
            this.calcTutar = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtOdemeTuru = new DevExpress.XtraEditors.TextEdit();
            this.lookMasraf = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasrafKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasrafAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMasraf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(459, 55);
            this.lblBaslik.TabIndex = 12;
            this.lblBaslik.Text = "Masraf Ekrani";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 265);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(459, 61);
            this.groupControl1.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 3;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(366, 22);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 36);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "safe.png");
            this.ımageList1.Images.SetKeyName(2, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(3, "içıkış.png");
            this.ımageList1.Images.SetKeyName(4, "ikaydet.png");
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 4;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(271, 22);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 36);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnKasaSec);
            this.groupControl2.Controls.Add(this.calcTutar);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.labelControl11);
            this.groupControl2.Controls.Add(this.txtKasaAdi);
            this.groupControl2.Controls.Add(this.txtKasaKodu);
            this.groupControl2.Controls.Add(this.txtOdemeTuru);
            this.groupControl2.Controls.Add(this.lookMasraf);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 55);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(459, 210);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Bilgiler";
            // 
            // btnKasaSec
            // 
            this.btnKasaSec.ImageOptions.ImageIndex = 1;
            this.btnKasaSec.ImageOptions.ImageList = this.ımageList1;
            this.btnKasaSec.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnKasaSec.Location = new System.Drawing.Point(345, 57);
            this.btnKasaSec.Name = "btnKasaSec";
            this.btnKasaSec.Size = new System.Drawing.Size(103, 45);
            this.btnKasaSec.TabIndex = 35;
            this.btnKasaSec.Click += new System.EventHandler(this.btnKasaSec_Click);
            // 
            // calcTutar
            // 
            this.calcTutar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calcTutar.Location = new System.Drawing.Point(91, 111);
            this.calcTutar.Name = "calcTutar";
            this.calcTutar.Properties.Appearance.BackColor = System.Drawing.Color.Green;
            this.calcTutar.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTutar.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.calcTutar.Properties.Appearance.Options.UseBackColor = true;
            this.calcTutar.Properties.Appearance.Options.UseFont = true;
            this.calcTutar.Properties.Appearance.Options.UseForeColor = true;
            this.calcTutar.Properties.Appearance.Options.UseTextOptions = true;
            this.calcTutar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.calcTutar.Properties.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.calcTutar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.calcTutar.Properties.DisplayFormat.FormatString = "C2";
            this.calcTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcTutar.Properties.EditFormat.FormatString = "C2";
            this.calcTutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcTutar.Properties.Mask.EditMask = "C";
            this.calcTutar.Properties.NullText = "0,00";
            this.calcTutar.Size = new System.Drawing.Size(357, 35);
            this.calcTutar.TabIndex = 0;
            this.calcTutar.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.calcTutar_ButtonClick);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(13, 158);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(72, 47);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Masraf Seçim :";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl3.Location = new System.Drawing.Point(13, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 36);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Tutar :";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl2.Location = new System.Drawing.Point(13, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 21);
            this.labelControl2.TabIndex = 31;
            this.labelControl2.Text = "Kasa Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(13, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 21);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Kasa Kodu :";
            // 
            // labelControl11
            // 
            this.labelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl11.Appearance.Options.UseTextOptions = true;
            this.labelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl11.Location = new System.Drawing.Point(13, 29);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(72, 20);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "Ödeme Türü :";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(90, 82);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(248, 20);
            this.txtKasaAdi.TabIndex = 30;
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(90, 56);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(248, 20);
            this.txtKasaKodu.TabIndex = 30;
            // 
            // txtOdemeTuru
            // 
            this.txtOdemeTuru.Location = new System.Drawing.Point(90, 30);
            this.txtOdemeTuru.Name = "txtOdemeTuru";
            this.txtOdemeTuru.Properties.ReadOnly = true;
            this.txtOdemeTuru.Size = new System.Drawing.Size(358, 20);
            this.txtOdemeTuru.TabIndex = 30;
            // 
            // lookMasraf
            // 
            this.lookMasraf.EditValue = "<Null>";
            this.lookMasraf.Location = new System.Drawing.Point(90, 168);
            this.lookMasraf.Name = "lookMasraf";
            this.lookMasraf.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lookMasraf.Properties.Appearance.Options.UseFont = true;
            this.lookMasraf.Properties.AutoHeight = false;
            this.lookMasraf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMasraf.Properties.DisplayMember = "MasrafAdi";
            this.lookMasraf.Properties.NullText = "Lütfen Masraf Seçiniz...";
            this.lookMasraf.Properties.PopupView = this.gridLookUpEdit1View;
            this.lookMasraf.Properties.ValueMember = "Id";
            this.lookMasraf.Size = new System.Drawing.Size(360, 29);
            this.lookMasraf.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasrafKodu,
            this.colMasrafAdi});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMasrafKodu
            // 
            this.colMasrafKodu.Caption = "Kodu";
            this.colMasrafKodu.FieldName = "MasrafKodu";
            this.colMasrafKodu.Name = "colMasrafKodu";
            this.colMasrafKodu.Visible = true;
            this.colMasrafKodu.VisibleIndex = 0;
            // 
            // colMasrafAdi
            // 
            this.colMasrafAdi.Caption = "Masraf Adı";
            this.colMasrafAdi.FieldName = "MasrafAdi";
            this.colMasrafAdi.Name = "colMasrafAdi";
            this.colMasrafAdi.Visible = true;
            this.colMasrafAdi.VisibleIndex = 1;
            // 
            // frmMasrafEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 326);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMasrafEkrani";
            this.ShowIcon = false;
            this.Text = "Masraf Ekranı";
            this.Load += new System.EventHandler(this.frmMasrafEkrani_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMasrafEkrani_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOdemeTuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMasraf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraEditors.TextEdit txtOdemeTuru;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.CalcEdit calcTutar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnKasaSec;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GridLookUpEdit lookMasraf;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMasrafKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMasrafAdi;
    }
}