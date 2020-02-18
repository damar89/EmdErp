namespace NetSatis.BackOffice.Cari
{
    partial class frmCariHareketStok
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariHareketStok));
            this.gridContCariHareket = new DevExpress.XtraGrid.GridControl();
            this.gridCariHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSatirTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirimTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDipIskonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpBitis = new DevExpress.XtraEditors.DateEdit();
            this.dtpBaslangic = new DevExpress.XtraEditors.DateEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnCariEkstreDokumu = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridContCariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // gridContCariHareket
            // 
            this.gridContCariHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContCariHareket.Location = new System.Drawing.Point(0, 35);
            this.gridContCariHareket.MainView = this.gridCariHareket;
            this.gridContCariHareket.Name = "gridContCariHareket";
            this.gridContCariHareket.Size = new System.Drawing.Size(1243, 431);
            this.gridContCariHareket.TabIndex = 2;
            this.gridContCariHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCariHareket});
            // 
            // gridCariHareket
            // 
            this.gridCariHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colTarih,
            this.colFisTuru,
            this.colToplamTutar,
            this.colAciklama,
            this.colUrunAdi,
            this.colMiktar,
            this.colBirim,
            this.colSatirTutari,
            this.colIndirimTutar,
            this.colDipIskonto});
            this.gridCariHareket.CustomizationFormBounds = new System.Drawing.Rectangle(725, 209, 210, 172);
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "Contains([Durum], \'A\')";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "Contains([Durum], \'B\')";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "Contains([Durum], \'K\')";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.gridCariHareket.FormatRules.Add(gridFormatRule1);
            this.gridCariHareket.FormatRules.Add(gridFormatRule2);
            this.gridCariHareket.FormatRules.Add(gridFormatRule3);
            this.gridCariHareket.GridControl = this.gridContCariHareket;
            this.gridCariHareket.GroupCount = 1;
            this.gridCariHareket.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FisTutari", this.colSatirTutari, "FişTutarı = {0:C2}")});
            this.gridCariHareket.Name = "gridCariHareket";
            this.gridCariHareket.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridCariHareket.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridCariHareket.OptionsMenu.ShowSplitItem = false;
            this.gridCariHareket.OptionsPrint.PrintDetails = true;
            this.gridCariHareket.OptionsPrint.RtfReportHeader = resources.GetString("gridCariHareket.OptionsPrint.RtfReportHeader");
            this.gridCariHareket.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCariHareket.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            this.gridCariHareket.OptionsView.ShowFooter = true;
            this.gridCariHareket.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFisKodu, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTarih, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridCariHareket.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridCariHareket_PopupMenuShowing);
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
            this.colFisKodu.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colFisKodu.AppearanceHeader.Options.UseBackColor = true;
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 111;
            // 
            // colTarih
            // 
            this.colTarih.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colTarih.AppearanceHeader.Options.UseBackColor = true;
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "IslemTarihi";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 117;
            // 
            // colFisTuru
            // 
            this.colFisTuru.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colFisTuru.AppearanceHeader.Options.UseBackColor = true;
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "IslemTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 130;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colToplamTutar.AppearanceHeader.Options.UseBackColor = true;
            this.colToplamTutar.Caption = "Birim Fiyat";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "BirimFiyat";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 5;
            this.colToplamTutar.Width = 95;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Width = 53;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colUrunAdi.AppearanceHeader.Options.UseBackColor = true;
            this.colUrunAdi.Caption = "Ürün Adi";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 2;
            this.colUrunAdi.Width = 275;
            // 
            // colMiktar
            // 
            this.colMiktar.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colMiktar.AppearanceHeader.Options.UseBackColor = true;
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "n2";
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 4;
            this.colMiktar.Width = 107;
            // 
            // colBirim
            // 
            this.colBirim.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colBirim.AppearanceHeader.Options.UseBackColor = true;
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Birim";
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 3;
            this.colBirim.Width = 136;
            // 
            // colSatirTutari
            // 
            this.colSatirTutari.AppearanceCell.Options.UseTextOptions = true;
            this.colSatirTutari.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSatirTutari.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colSatirTutari.AppearanceHeader.Options.UseBackColor = true;
            this.colSatirTutari.AppearanceHeader.Options.UseTextOptions = true;
            this.colSatirTutari.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSatirTutari.Caption = "Tutar";
            this.colSatirTutari.DisplayFormat.FormatString = "c2";
            this.colSatirTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSatirTutari.FieldName = "FisTutari";
            this.colSatirTutari.Name = "colSatirTutari";
            this.colSatirTutari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "FisTutari", "C2")});
            this.colSatirTutari.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colSatirTutari.Visible = true;
            this.colSatirTutari.VisibleIndex = 8;
            this.colSatirTutari.Width = 180;
            // 
            // colIndirimTutar
            // 
            this.colIndirimTutar.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colIndirimTutar.AppearanceHeader.Options.UseBackColor = true;
            this.colIndirimTutar.Caption = "IndirimTutar";
            this.colIndirimTutar.DisplayFormat.FormatString = "c2";
            this.colIndirimTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirimTutar.FieldName = "IndirimTutari";
            this.colIndirimTutar.Name = "colIndirimTutar";
            this.colIndirimTutar.Visible = true;
            this.colIndirimTutar.VisibleIndex = 6;
            this.colIndirimTutar.Width = 79;
            // 
            // colDipIskonto
            // 
            this.colDipIskonto.AppearanceHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.colDipIskonto.AppearanceHeader.Options.UseBackColor = true;
            this.colDipIskonto.Caption = "Dip İskonto";
            this.colDipIskonto.DisplayFormat.FormatString = "c2";
            this.colDipIskonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDipIskonto.FieldName = "DipIndirim";
            this.colDipIskonto.Name = "colDipIskonto";
            this.colDipIskonto.Visible = true;
            this.colDipIskonto.VisibleIndex = 7;
            this.colDipIskonto.Width = 106;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dtpBitis);
            this.groupControl1.Controls.Add(this.dtpBaslangic);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnCariEkstreDokumu);
            this.groupControl1.Controls.Add(this.btnAra);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 466);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1243, 57);
            this.groupControl1.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(546, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Bitiş :";
            this.labelControl2.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(321, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Başlangıç :";
            this.labelControl1.Visible = false;
            // 
            // dtpBitis
            // 
            this.dtpBitis.EditValue = null;
            this.dtpBitis.Location = new System.Drawing.Point(581, 23);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtpBitis.Properties.AutoHeight = false;
            this.dtpBitis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBitis.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dtpBitis.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBitis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBitis.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBitis.Size = new System.Drawing.Size(147, 29);
            this.dtpBitis.TabIndex = 9;
            this.dtpBitis.Visible = false;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.EditValue = null;
            this.dtpBaslangic.Location = new System.Drawing.Point(378, 23);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtpBaslangic.Properties.AutoHeight = false;
            this.dtpBaslangic.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpBaslangic.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.dtpBaslangic.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dtpBaslangic.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtpBaslangic.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dtpBaslangic.Size = new System.Drawing.Size(150, 29);
            this.dtpBaslangic.TabIndex = 10;
            this.dtpBaslangic.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKapat.ImageOptions.SvgImage")));
            this.btnKapat.Location = new System.Drawing.Point(1153, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnCariEkstreDokumu
            // 
            this.btnCariEkstreDokumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCariEkstreDokumu.ImageOptions.ImageIndex = 2;
            this.btnCariEkstreDokumu.Location = new System.Drawing.Point(192, 23);
            this.btnCariEkstreDokumu.Name = "btnCariEkstreDokumu";
            this.btnCariEkstreDokumu.Size = new System.Drawing.Size(114, 31);
            this.btnCariEkstreDokumu.TabIndex = 5;
            this.btnCariEkstreDokumu.Text = "Cari Ekstre Dökümü";
            this.btnCariEkstreDokumu.Visible = false;
            this.btnCariEkstreDokumu.Click += new System.EventHandler(this.btnCariEkstreDokumu_Click);
            // 
            // btnAra
            // 
            this.btnAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAra.ImageOptions.ImageIndex = 2;
            this.btnAra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAra.ImageOptions.SvgImage")));
            this.btnAra.Location = new System.Drawing.Point(101, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(85, 31);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuncelle.ImageOptions.ImageIndex = 1;
            this.btnGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGuncelle.ImageOptions.SvgImage")));
            this.btnGuncelle.Location = new System.Drawing.Point(9, 24);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(85, 31);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.BackColor = System.Drawing.Color.White;
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaslik.Appearance.Options.UseBackColor = true;
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
            this.lblBaslik.Size = new System.Drawing.Size(1243, 35);
            this.lblBaslik.TabIndex = 8;
            this.lblBaslik.Text = "Cari Hareketleri";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yazdır Önizle";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1243, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 523);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1243, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 523);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1243, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 523);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(180, 120);
            // 
            // frmCariHareketStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 523);
            this.Controls.Add(this.gridContCariHareket);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmCariHareketStok";
            this.ShowIcon = false;
            this.Text = "Cari Ekstre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCariHareketStok_FormClosing);
            this.Load += new System.EventHandler(this.frmCariHareketStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridContCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBitis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpBaslangic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridContCariHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCariHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnCariEkstreDokumu;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        public DevExpress.XtraEditors.DateEdit dtpBitis;
        public DevExpress.XtraEditors.DateEdit dtpBaslangic;
        private DevExpress.XtraGrid.Columns.GridColumn colSatirTutari;
        private System.Windows.Forms.PrintDialog printDialog1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirimTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colDipIskonto;
    }
}