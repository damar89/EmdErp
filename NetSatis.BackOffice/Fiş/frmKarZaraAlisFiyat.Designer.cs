namespace NetSatis.BackOffice.Fiş
{
    partial class frmKarZaraAlisFiyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKarZaraAlisFiyat));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnWord = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.gridContStokHareket = new DevExpress.XtraGrid.GridControl();
            this.gridStokHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHareket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimOrani = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKdvToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAlisFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAlisToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKarOran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKarTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnaGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.calcToplam = new DevExpress.XtraEditors.CalcEdit();
            this.calcKarOran = new DevExpress.XtraEditors.CalcEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calcToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKarOran.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.PrintToFile = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYazdir),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 0;
            this.btnYazdir.ImageOptions.Image = global::NetSatis.BackOffice.Properties.Resources.printpreview_16x16;
            this.btnYazdir.ImageOptions.LargeImage = global::NetSatis.BackOffice.Properties.Resources.printpreview_32x32;
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Dışarı Aktar";
            this.barSubItem1.Id = 2;
            this.barSubItem1.ImageOptions.Image = global::NetSatis.BackOffice.Properties.Resources.export_16x16;
            this.barSubItem1.ImageOptions.LargeImage = global::NetSatis.BackOffice.Properties.Resources.export_32x32;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWord),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdf)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excel";
            this.btnExcel.Id = 3;
            this.btnExcel.ImageOptions.Image = global::NetSatis.BackOffice.Properties.Resources.exporttoxlsx_16x16;
            this.btnExcel.ImageOptions.LargeImage = global::NetSatis.BackOffice.Properties.Resources.exporttoxlsx_32x32;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnWord
            // 
            this.btnWord.Caption = "Word";
            this.btnWord.Id = 4;
            this.btnWord.ImageOptions.Image = global::NetSatis.BackOffice.Properties.Resources.exporttodoc_16x16;
            this.btnWord.ImageOptions.LargeImage = global::NetSatis.BackOffice.Properties.Resources.exporttodoc_32x32;
            this.btnWord.Name = "btnWord";
            this.btnWord.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWord_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Pdf";
            this.btnPdf.Id = 5;
            this.btnPdf.ImageOptions.Image = global::NetSatis.BackOffice.Properties.Resources.exporttopdf_16x16;
            this.btnPdf.ImageOptions.LargeImage = global::NetSatis.BackOffice.Properties.Resources.exporttopdf_32x32;
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
            this.barButtonItem2,
            this.barSubItem1,
            this.btnExcel,
            this.btnWord,
            this.btnPdf});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 556);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1167, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1167, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 556);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Aktar";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // gridContStokHareket
            // 
            this.gridContStokHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContStokHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContStokHareket.MainView = this.gridStokHareket;
            this.gridContStokHareket.Name = "gridContStokHareket";
            this.gridContStokHareket.Size = new System.Drawing.Size(1167, 508);
            this.gridContStokHareket.TabIndex = 6;
            this.gridContStokHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridStokHareket,
            this.gridView1});
            // 
            // gridStokHareket
            // 
            this.gridStokHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFisKodu,
            this.colHareket,
            this.colMiktar,
            this.colKdv,
            this.colBirimFiyati,
            this.colIndirimOrani,
            this.colDepoId,
            this.colTarih,
            this.colAciklama,
            this.colStok,
            this.colDepo,
            this.colKdvToplam,
            this.colIndirimTutar,
            this.colAlisFiyati,
            this.ColAlisToplam,
            this.colNetTutar,
            this.colKarOran,
            this.colKarTutari,
            this.colKategori,
            this.colAnaGrup,
            this.colAltGrup,
            this.colMarka});
            this.gridStokHareket.CustomizationFormBounds = new System.Drawing.Rectangle(673, 405, 266, 240);
            this.gridStokHareket.GridControl = this.gridContStokHareket;
            this.gridStokHareket.Name = "gridStokHareket";
            this.gridStokHareket.OptionsPrint.PrintGroupFooter = false;
            this.gridStokHareket.OptionsPrint.RtfPageHeader = resources.GetString("gridStokHareket.OptionsPrint.RtfPageHeader");
            this.gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            this.gridStokHareket.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridStokHareket_PopupMenuShowing);
            // 
            // colFisKodu
            // 
            this.colFisKodu.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colFisKodu.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colFisKodu.AppearanceHeader.Options.UseBackColor = true;
            this.colFisKodu.AppearanceHeader.Options.UseForeColor = true;
            this.colFisKodu.AppearanceHeader.Options.UseTextOptions = true;
            this.colFisKodu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 102;
            // 
            // colHareket
            // 
            this.colHareket.FieldName = "Hareket";
            this.colHareket.Name = "colHareket";
            this.colHareket.OptionsColumn.AllowEdit = false;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceCell.Options.UseTextOptions = true;
            this.colMiktar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiktar.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colMiktar.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMiktar.AppearanceHeader.Options.UseBackColor = true;
            this.colMiktar.AppearanceHeader.Options.UseForeColor = true;
            this.colMiktar.AppearanceHeader.Options.UseTextOptions = true;
            this.colMiktar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMiktar.DisplayFormat.FormatString = "n2";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 7;
            this.colMiktar.Width = 60;
            // 
            // colKdv
            // 
            this.colKdv.FieldName = "Kdv";
            this.colKdv.Name = "colKdv";
            this.colKdv.OptionsColumn.AllowEdit = false;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.AppearanceCell.Options.UseTextOptions = true;
            this.colBirimFiyati.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirimFiyati.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colBirimFiyati.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colBirimFiyati.AppearanceHeader.Options.UseBackColor = true;
            this.colBirimFiyati.AppearanceHeader.Options.UseForeColor = true;
            this.colBirimFiyati.AppearanceHeader.Options.UseTextOptions = true;
            this.colBirimFiyati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBirimFiyati.Caption = "Satış Fiyatı";
            this.colBirimFiyati.DisplayFormat.FormatString = "c2";
            this.colBirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyati.FieldName = "BirimFiyati";
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.OptionsColumn.AllowEdit = false;
            this.colBirimFiyati.Visible = true;
            this.colBirimFiyati.VisibleIndex = 9;
            this.colBirimFiyati.Width = 80;
            // 
            // colIndirimOrani
            // 
            this.colIndirimOrani.FieldName = "IndirimOrani";
            this.colIndirimOrani.Name = "colIndirimOrani";
            this.colIndirimOrani.OptionsColumn.AllowEdit = false;
            // 
            // colDepoId
            // 
            this.colDepoId.FieldName = "DepoId";
            this.colDepoId.Name = "colDepoId";
            this.colDepoId.OptionsColumn.AllowEdit = false;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colTarih.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colTarih.AppearanceHeader.Options.UseBackColor = true;
            this.colTarih.AppearanceHeader.Options.UseForeColor = true;
            this.colTarih.AppearanceHeader.Options.UseTextOptions = true;
            this.colTarih.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 90;
            // 
            // colAciklama
            // 
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            // 
            // colStok
            // 
            this.colStok.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colStok.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colStok.AppearanceHeader.Options.UseBackColor = true;
            this.colStok.AppearanceHeader.Options.UseForeColor = true;
            this.colStok.AppearanceHeader.Options.UseTextOptions = true;
            this.colStok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStok.FieldName = "StokAdi";
            this.colStok.Name = "colStok";
            this.colStok.OptionsColumn.AllowEdit = false;
            this.colStok.Visible = true;
            this.colStok.VisibleIndex = 2;
            this.colStok.Width = 271;
            // 
            // colDepo
            // 
            this.colDepo.FieldName = "Depo";
            this.colDepo.Name = "colDepo";
            this.colDepo.OptionsColumn.AllowEdit = false;
            // 
            // colKdvToplam
            // 
            this.colKdvToplam.FieldName = "KdvToplam";
            this.colKdvToplam.Name = "colKdvToplam";
            this.colKdvToplam.OptionsColumn.AllowEdit = false;
            // 
            // colIndirimTutar
            // 
            this.colIndirimTutar.FieldName = "IndirimTutar";
            this.colIndirimTutar.Name = "colIndirimTutar";
            this.colIndirimTutar.OptionsColumn.AllowEdit = false;
            // 
            // colAlisFiyati
            // 
            this.colAlisFiyati.AppearanceCell.Options.UseTextOptions = true;
            this.colAlisFiyati.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlisFiyati.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colAlisFiyati.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colAlisFiyati.AppearanceHeader.Options.UseBackColor = true;
            this.colAlisFiyati.AppearanceHeader.Options.UseForeColor = true;
            this.colAlisFiyati.AppearanceHeader.Options.UseTextOptions = true;
            this.colAlisFiyati.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAlisFiyati.Caption = "Alış Fiyatı";
            this.colAlisFiyati.DisplayFormat.FormatString = "c2";
            this.colAlisFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAlisFiyati.FieldName = "AlisFiyati1";
            this.colAlisFiyati.Name = "colAlisFiyati";
            this.colAlisFiyati.OptionsColumn.AllowEdit = false;
            this.colAlisFiyati.Visible = true;
            this.colAlisFiyati.VisibleIndex = 8;
            this.colAlisFiyati.Width = 85;
            // 
            // ColAlisToplam
            // 
            this.ColAlisToplam.AppearanceCell.Options.UseTextOptions = true;
            this.ColAlisToplam.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColAlisToplam.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ColAlisToplam.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.ColAlisToplam.AppearanceHeader.Options.UseBackColor = true;
            this.ColAlisToplam.AppearanceHeader.Options.UseForeColor = true;
            this.ColAlisToplam.AppearanceHeader.Options.UseTextOptions = true;
            this.ColAlisToplam.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ColAlisToplam.Caption = "Alis Toplam";
            this.ColAlisToplam.DisplayFormat.FormatString = "c2";
            this.ColAlisToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColAlisToplam.FieldName = "AlisToplam";
            this.ColAlisToplam.Name = "ColAlisToplam";
            this.ColAlisToplam.OptionsColumn.AllowEdit = false;
            this.ColAlisToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AlisToplam", "Alış Toplamı : {0:C2}")});
            this.ColAlisToplam.Visible = true;
            this.ColAlisToplam.VisibleIndex = 10;
            this.ColAlisToplam.Width = 107;
            // 
            // colNetTutar
            // 
            this.colNetTutar.AppearanceCell.Options.UseTextOptions = true;
            this.colNetTutar.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNetTutar.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colNetTutar.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colNetTutar.AppearanceHeader.Options.UseBackColor = true;
            this.colNetTutar.AppearanceHeader.Options.UseForeColor = true;
            this.colNetTutar.AppearanceHeader.Options.UseTextOptions = true;
            this.colNetTutar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNetTutar.Caption = "Net Satis Tutari";
            this.colNetTutar.DisplayFormat.FormatString = "c2";
            this.colNetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colNetTutar.FieldName = "NetTutar";
            this.colNetTutar.Name = "colNetTutar";
            this.colNetTutar.OptionsColumn.AllowEdit = false;
            this.colNetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetTutar", "Satış Toplamı : {0:C2}")});
            this.colNetTutar.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colNetTutar.Visible = true;
            this.colNetTutar.VisibleIndex = 11;
            this.colNetTutar.Width = 97;
            // 
            // colKarOran
            // 
            this.colKarOran.AppearanceCell.Options.UseTextOptions = true;
            this.colKarOran.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKarOran.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colKarOran.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colKarOran.AppearanceHeader.Options.UseBackColor = true;
            this.colKarOran.AppearanceHeader.Options.UseForeColor = true;
            this.colKarOran.AppearanceHeader.Options.UseTextOptions = true;
            this.colKarOran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKarOran.Caption = "Kâr Oranı";
            this.colKarOran.DisplayFormat.FormatString = "n2";
            this.colKarOran.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKarOran.FieldName = "karOran";
            this.colKarOran.Name = "colKarOran";
            this.colKarOran.OptionsColumn.AllowEdit = false;
            this.colKarOran.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "karOran", "Kâr Ortalaması : {0:N2}")});
            this.colKarOran.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colKarOran.Visible = true;
            this.colKarOran.VisibleIndex = 13;
            this.colKarOran.Width = 144;
            // 
            // colKarTutari
            // 
            this.colKarTutari.AppearanceCell.Options.UseTextOptions = true;
            this.colKarTutari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKarTutari.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colKarTutari.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colKarTutari.AppearanceHeader.Options.UseBackColor = true;
            this.colKarTutari.AppearanceHeader.Options.UseForeColor = true;
            this.colKarTutari.AppearanceHeader.Options.UseTextOptions = true;
            this.colKarTutari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colKarTutari.Caption = "Kâr Tutarı";
            this.colKarTutari.DisplayFormat.FormatString = "c2";
            this.colKarTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKarTutari.FieldName = "KarTutari";
            this.colKarTutari.Name = "colKarTutari";
            this.colKarTutari.OptionsColumn.AllowEdit = false;
            this.colKarTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colKarTutari", "Kâr Tutarı : {0:C2}")});
            this.colKarTutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colKarTutari.Visible = true;
            this.colKarTutari.VisibleIndex = 12;
            this.colKarTutari.Width = 113;
            // 
            // colKategori
            // 
            this.colKategori.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colKategori.AppearanceHeader.Options.UseBackColor = true;
            this.colKategori.Caption = "Kategori";
            this.colKategori.FieldName = "KategoriAdi";
            this.colKategori.Name = "colKategori";
            this.colKategori.Visible = true;
            this.colKategori.VisibleIndex = 3;
            // 
            // colAnaGrup
            // 
            this.colAnaGrup.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colAnaGrup.AppearanceHeader.Options.UseBackColor = true;
            this.colAnaGrup.Caption = "AnaGrup";
            this.colAnaGrup.FieldName = "AnaGrupAdi";
            this.colAnaGrup.Name = "colAnaGrup";
            this.colAnaGrup.Visible = true;
            this.colAnaGrup.VisibleIndex = 4;
            // 
            // colAltGrup
            // 
            this.colAltGrup.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colAltGrup.AppearanceHeader.Options.UseBackColor = true;
            this.colAltGrup.Caption = "AltGrup";
            this.colAltGrup.FieldName = "AltGrupAdi";
            this.colAltGrup.Name = "colAltGrup";
            this.colAltGrup.Visible = true;
            this.colAltGrup.VisibleIndex = 5;
            // 
            // colMarka
            // 
            this.colMarka.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colMarka.AppearanceHeader.Options.UseBackColor = true;
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "Stok.Marka";
            this.colMarka.Name = "colMarka";
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 6;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridContStokHareket;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.calcKarOran);
            this.groupControl1.Controls.Add(this.calcToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 508);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1167, 48);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(587, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 28);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Kâr Tutarı :";
            // 
            // calcToplam
            // 
            this.calcToplam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcToplam.Location = new System.Drawing.Point(705, 8);
            this.calcToplam.MenuManager = this.barManager1;
            this.calcToplam.Name = "calcToplam";
            this.calcToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcToplam.Properties.Appearance.Options.UseFont = true;
            this.calcToplam.Properties.Appearance.Options.UseTextOptions = true;
            this.calcToplam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.calcToplam.Properties.AutoHeight = false;
            this.calcToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcToplam.Properties.DisplayFormat.FormatString = "C2";
            this.calcToplam.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcToplam.Properties.EditFormat.FormatString = "C2";
            this.calcToplam.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcToplam.Properties.ReadOnly = true;
            this.calcToplam.Properties.ShowCloseButton = true;
            this.calcToplam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.calcToplam.Size = new System.Drawing.Size(170, 28);
            this.calcToplam.TabIndex = 8;
            // 
            // calcKarOran
            // 
            this.calcKarOran.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calcKarOran.Location = new System.Drawing.Point(997, 8);
            this.calcKarOran.Name = "calcKarOran";
            this.calcKarOran.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calcKarOran.Properties.Appearance.Options.UseFont = true;
            this.calcKarOran.Properties.Appearance.Options.UseTextOptions = true;
            this.calcKarOran.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.calcKarOran.Properties.AutoHeight = false;
            this.calcKarOran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcKarOran.Properties.DisplayFormat.FormatString = "n2";
            this.calcKarOran.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcKarOran.Properties.EditFormat.FormatString = "n2";
            this.calcKarOran.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcKarOran.Properties.ReadOnly = true;
            this.calcKarOran.Properties.ShowCloseButton = true;
            this.calcKarOran.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.calcKarOran.Size = new System.Drawing.Size(165, 28);
            this.calcKarOran.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(879, 8);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 28);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Kâr Tutarı :";
            // 
            // frmKarZaraAlisFiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 556);
            this.Controls.Add(this.gridContStokHareket);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.ShowIcon = false;
            this.Name = "frmKarZaraAlisFiyat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kâr Zarar Durumu";
            this.Load += new System.EventHandler(this.frmKarZaraAlisFiyat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridContStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calcToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcKarOran.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraGrid.GridControl gridContStokHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridStokHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimOrani;
        private DevExpress.XtraGrid.Columns.GridColumn colDepoId;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colStok;
        private DevExpress.XtraGrid.Columns.GridColumn colDepo;
        private DevExpress.XtraGrid.Columns.GridColumn colKdvToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAlisFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn ColAlisToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colNetTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colKarOran;
        private DevExpress.XtraGrid.Columns.GridColumn colKarTutari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnWord;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colKategori;
        private DevExpress.XtraGrid.Columns.GridColumn colAnaGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colAltGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CalcEdit calcToplam;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CalcEdit calcKarOran;
    }
}