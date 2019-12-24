namespace NetSatis.BackOffice.Fiyat_Değiştir
{
    partial class frmFiyatDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiyatDegistir));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colfiyatturu2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lupreffiyat = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colFiyatTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKolonAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDegistir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegistir = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.colDegisimTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegisimTuru = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegisimYonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegisimYonu = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colDegeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoDegisimMiktari = new DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupreffiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegistir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimYonu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 353);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 62);
            this.groupControl1.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.ImageOptions.ImageIndex = 1;
            this.btnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(420, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(85, 36);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "içıkış.png");
            this.ımageList1.Images.SetKeyName(1, "ikaydet.png");
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(511, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 36);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoDegistir,
            this.repoDegisimTuru,
            this.repoDegisimYonu,
            this.repoDegisimMiktari,
            this.lupreffiyat});
            this.gridControl1.Size = new System.Drawing.Size(601, 353);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colfiyatturu2,
            this.colFiyatTuru,
            this.colKolonAdi,
            this.colDegistir,
            this.colDegisimTuru,
            this.colDegisimYonu,
            this.colDegeri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colfiyatturu2
            // 
            this.colfiyatturu2.Caption = "Baz Alınacak Fiyat";
            this.colfiyatturu2.ColumnEdit = this.lupreffiyat;
            this.colfiyatturu2.FieldName = "Referans";
            this.colfiyatturu2.Name = "colfiyatturu2";
            this.colfiyatturu2.Visible = true;
            this.colfiyatturu2.VisibleIndex = 0;
            this.colfiyatturu2.Width = 143;
            // 
            // lupreffiyat
            // 
            this.lupreffiyat.AutoHeight = false;
            this.lupreffiyat.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lupreffiyat.Name = "lupreffiyat";
            this.lupreffiyat.NullText = "Seçim Yapınız.";
            // 
            // colFiyatTuru
            // 
            this.colFiyatTuru.Caption = "Fiyat Türü";
            this.colFiyatTuru.FieldName = "FiyatTuru";
            this.colFiyatTuru.Name = "colFiyatTuru";
            this.colFiyatTuru.OptionsColumn.AllowEdit = false;
            this.colFiyatTuru.Visible = true;
            this.colFiyatTuru.VisibleIndex = 1;
            this.colFiyatTuru.Width = 86;
            // 
            // colKolonAdi
            // 
            this.colKolonAdi.Caption = "Kolon Adı";
            this.colKolonAdi.FieldName = "KolonAdi";
            this.colKolonAdi.Name = "colKolonAdi";
            this.colKolonAdi.OptionsColumn.AllowEdit = false;
            this.colKolonAdi.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colDegistir
            // 
            this.colDegistir.Caption = "Fiyat Değiştirilecek Mi ?";
            this.colDegistir.ColumnEdit = this.repoDegistir;
            this.colDegistir.FieldName = "Degistir";
            this.colDegistir.Name = "colDegistir";
            this.colDegistir.Visible = true;
            this.colDegistir.VisibleIndex = 2;
            this.colDegistir.Width = 98;
            // 
            // repoDegistir
            // 
            this.repoDegistir.AutoHeight = false;
            this.repoDegistir.Name = "repoDegistir";
            this.repoDegistir.OffText = "Off";
            this.repoDegistir.OnText = "On";
            // 
            // colDegisimTuru
            // 
            this.colDegisimTuru.Caption = "Değişim Türü";
            this.colDegisimTuru.ColumnEdit = this.repoDegisimTuru;
            this.colDegisimTuru.FieldName = "DegisimTuru";
            this.colDegisimTuru.Name = "colDegisimTuru";
            this.colDegisimTuru.Visible = true;
            this.colDegisimTuru.VisibleIndex = 3;
            this.colDegisimTuru.Width = 82;
            // 
            // repoDegisimTuru
            // 
            this.repoDegisimTuru.AutoHeight = false;
            this.repoDegisimTuru.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoDegisimTuru.Items.AddRange(new object[] {
            "Yüzde",
            "Tutar"});
            this.repoDegisimTuru.Name = "repoDegisimTuru";
            this.repoDegisimTuru.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegisimYonu
            // 
            this.colDegisimYonu.Caption = "Değişim Yönü";
            this.colDegisimYonu.ColumnEdit = this.repoDegisimYonu;
            this.colDegisimYonu.FieldName = "DegisimYonu";
            this.colDegisimYonu.Name = "colDegisimYonu";
            this.colDegisimYonu.Visible = true;
            this.colDegisimYonu.VisibleIndex = 4;
            this.colDegisimYonu.Width = 82;
            // 
            // repoDegisimYonu
            // 
            this.repoDegisimYonu.AutoHeight = false;
            this.repoDegisimYonu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoDegisimYonu.Items.AddRange(new object[] {
            "Arttır",
            "Azalt"});
            this.repoDegisimYonu.Name = "repoDegisimYonu";
            this.repoDegisimYonu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colDegeri
            // 
            this.colDegeri.Caption = "Değişim Miktarı";
            this.colDegeri.ColumnEdit = this.repoDegisimMiktari;
            this.colDegeri.FieldName = "Degeri";
            this.colDegeri.Name = "colDegeri";
            this.colDegeri.Visible = true;
            this.colDegeri.VisibleIndex = 5;
            this.colDegeri.Width = 92;
            // 
            // repoDegisimMiktari
            // 
            this.repoDegisimMiktari.AutoHeight = false;
            this.repoDegisimMiktari.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoDegisimMiktari.DisplayFormat.FormatString = "N2";
            this.repoDegisimMiktari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repoDegisimMiktari.Name = "repoDegisimMiktari";
            // 
            // frmFiyatDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 415);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiyatDegistir";
            this.ShowIcon = false;
            this.Text = "Toplu Fiyat Degistir";
            this.Load += new System.EventHandler(this.frmFiyatDegistir_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFiyatDegistir_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lupreffiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegistir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimYonu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoDegisimMiktari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFiyatTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colKolonAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colDegistir;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colDegisimYonu;
        private DevExpress.XtraGrid.Columns.GridColumn colDegeri;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repoDegistir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoDegisimTuru;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repoDegisimYonu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit repoDegisimMiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colfiyatturu2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lupreffiyat;
    }
}