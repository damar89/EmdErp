namespace NetSatis.BackOffice.Kasa_Hareketleri
{
    partial class frmTarihKasaHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarihKasaHareket));
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContKasaHareket = new DevExpress.XtraGrid.GridControl();
            this.gridKasaHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaCikis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKasaGiris = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuruAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.ImageList = this.ımageList1;
            this.btnKapat.Location = new System.Drawing.Point(463, 26);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 39);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "içıkış.png");
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 281);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(553, 68);
            this.groupControl1.TabIndex = 8;
            // 
            // gridContKasaHareket
            // 
            this.gridContKasaHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasaHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContKasaHareket.MainView = this.gridKasaHareket;
            this.gridContKasaHareket.Name = "gridContKasaHareket";
            this.gridContKasaHareket.Size = new System.Drawing.Size(553, 281);
            this.gridContKasaHareket.TabIndex = 11;
            this.gridContKasaHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaHareket});
            // 
            // gridKasaHareket
            // 
            this.gridKasaHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colHareket,
            this.colKasaCikis,
            this.colKasaGiris,
            this.colOdemeTuruKodu,
            this.colOdemeTuruAdi,
            this.colTarih,
            this.colTutar,
            this.colAciklama,
            this.colVadeTarihi});
            this.gridKasaHareket.GridControl = this.gridContKasaHareket;
            this.gridKasaHareket.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", this.colTutar, "(Tutar: SUM={0:C2})")});
            this.gridKasaHareket.Name = "gridKasaHareket";
            this.gridKasaHareket.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridKasaHareket.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            this.gridKasaHareket.OptionsView.ShowFooter = true;
            this.gridKasaHareket.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTarih, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridKasaHareket.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridKasaHareket_PopupMenuShowing);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFisKodu
            // 
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.OptionsColumn.ShowInCustomizationForm = false;
            this.colFisKodu.Width = 224;
            // 
            // colHareket
            // 
            this.colHareket.Caption = "Hareket";
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            this.colHareket.OptionsColumn.ShowInCustomizationForm = false;
            this.colHareket.Width = 102;
            // 
            // colKasaCikis
            // 
            this.colKasaCikis.Caption = "Kasa Kodu";
            this.colKasaCikis.FieldName = "KasaCikis";
            this.colKasaCikis.Name = "colKasaCikis";
            this.colKasaCikis.OptionsColumn.AllowEdit = false;
            this.colKasaCikis.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colKasaGiris
            // 
            this.colKasaGiris.Caption = "Kasa Adı";
            this.colKasaGiris.FieldName = "KasaGiris";
            this.colKasaGiris.Name = "colKasaGiris";
            this.colKasaGiris.OptionsColumn.AllowEdit = false;
            this.colKasaGiris.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOdemeTuruKodu
            // 
            this.colOdemeTuruKodu.Caption = "Ödeme Türü Kodu";
            this.colOdemeTuruKodu.FieldName = "OdemeTuru.OdemeTuruKodu";
            this.colOdemeTuruKodu.Name = "colOdemeTuruKodu";
            this.colOdemeTuruKodu.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruKodu.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colOdemeTuruAdi
            // 
            this.colOdemeTuruAdi.Caption = "Ödeme Türü";
            this.colOdemeTuruAdi.FieldName = "OdemeTuruAdi";
            this.colOdemeTuruAdi.Name = "colOdemeTuruAdi";
            this.colOdemeTuruAdi.OptionsColumn.AllowEdit = false;
            this.colOdemeTuruAdi.OptionsColumn.ShowInCustomizationForm = false;
            this.colOdemeTuruAdi.Visible = true;
            this.colOdemeTuruAdi.VisibleIndex = 0;
            this.colOdemeTuruAdi.Width = 173;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.ShowInCustomizationForm = false;
            this.colTarih.Width = 151;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Bakiye";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.ShowInCustomizationForm = false;
            this.colTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Bakiye", "Kasa Toplamı ={0:c2}")});
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 1;
            this.colTutar.Width = 362;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.OptionsColumn.ShowInCustomizationForm = false;
            this.colAciklama.Width = 122;
            // 
            // colVadeTarihi
            // 
            this.colVadeTarihi.Caption = "Vade Tarihi";
            this.colVadeTarihi.DisplayFormat.FormatString = "d";
            this.colVadeTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVadeTarihi.FieldName = "VadeTarihi";
            this.colVadeTarihi.Name = "colVadeTarihi";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYazdir),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdf)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 0;
       
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Exel Aktar";
            this.btnExcel.Id = 1;
      
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Pdf Aktar";
            this.btnPdf.Id = 2;
         
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPdf_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnYazdir,
            this.btnExcel,
            this.btnPdf});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(553, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 281);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(553, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 281);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(553, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 281);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmTarihKasaHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 349);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.gridContKasaHareket);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.Name = "frmTarihKasaHareket";
            this.ShowIcon = false;
            this.Text = "Kasa Rapor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTarihKasaHareket_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridContKasaHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaCikis;
        private DevExpress.XtraGrid.Columns.GridColumn colKasaGiris;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuruAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeTarihi;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}