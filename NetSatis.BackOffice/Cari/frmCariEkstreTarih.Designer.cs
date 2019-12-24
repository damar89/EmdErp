namespace NetSatis.BackOffice.Cari
{
    partial class frmCariEkstreTarih
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
            this.colDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.gridContCariHareket = new DevExpress.XtraGrid.GridControl();
            this.gridCariHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFisTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBelgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlasiyerAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoOrani3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIskontoTutari3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKalanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAktifTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVadeTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdf = new DevExpress.XtraBars.BarButtonItem();
            this.btnYazdir = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContCariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colDurum
            // 
            this.colDurum.AppearanceCell.Options.UseTextOptions = true;
            this.colDurum.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDurum.Caption = "Durum";
            this.colDurum.FieldName = "Durum";
            this.colDurum.Name = "colDurum";
            this.colDurum.OptionsColumn.AllowEdit = false;
            this.colDurum.Visible = true;
            this.colDurum.VisibleIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 542);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(936, 57);
            this.groupControl1.TabIndex = 7;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.ImageIndex = 0;
            this.btnKapat.Location = new System.Drawing.Point(846, 23);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(85, 31);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // gridContCariHareket
            // 
            this.gridContCariHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContCariHareket.Location = new System.Drawing.Point(0, 0);
            this.gridContCariHareket.MainView = this.gridCariHareket;
            this.gridContCariHareket.Name = "gridContCariHareket";
            this.gridContCariHareket.Size = new System.Drawing.Size(936, 542);
            this.gridContCariHareket.TabIndex = 8;
            this.gridContCariHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridCariHareket});
            // 
            // gridCariHareket
            // 
            this.gridCariHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colFisKodu,
            this.colFisTuru,
            this.colBelgeNo,
            this.colTarih,
            this.colSaat,
            this.colPlasiyerKodu,
            this.colPlasiyerAdi,
            this.colIskontoOrani1,
            this.colIskontoOrani2,
            this.colIskontoOrani3,
            this.colIskontoTutari1,
            this.colIskontoTutari2,
            this.colIskontoTutari3,
            this.colToplamTutar,
            this.colAciklama,
            this.colDurum,
            this.colOdenen,
            this.colKalanTutar,
            this.colAktifTutar,
            this.colVadeTarihi});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.colDurum;
            gridFormatRule1.ColumnApplyTo = this.colDurum;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression1.Expression = "Contains([Durum], \'A\')";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.colDurum;
            gridFormatRule2.ColumnApplyTo = this.colDurum;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression2.Expression = "Contains([Durum], \'B\')";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.colDurum;
            gridFormatRule3.ColumnApplyTo = this.colDurum;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
            formatConditionRuleExpression3.Expression = "Contains([Durum], \'K\')";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            this.gridCariHareket.FormatRules.Add(gridFormatRule1);
            this.gridCariHareket.FormatRules.Add(gridFormatRule2);
            this.gridCariHareket.FormatRules.Add(gridFormatRule3);
            this.gridCariHareket.GridControl = this.gridContCariHareket;
            this.gridCariHareket.Name = "gridCariHareket";
            this.gridCariHareket.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridCariHareket.OptionsPrint.EnableAppearanceOddRow = true;
            this.gridCariHareket.OptionsPrint.PrintFilterInfo = true;
            this.gridCariHareket.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridCariHareket.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridCariHareket.OptionsView.ShowAutoFilterRow = true;
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
            this.colFisKodu.Caption = "Fiş Kodu";
            this.colFisKodu.FieldName = "FisKodu";
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.OptionsColumn.AllowEdit = false;
            this.colFisKodu.Visible = true;
            this.colFisKodu.VisibleIndex = 0;
            this.colFisKodu.Width = 85;
            // 
            // colFisTuru
            // 
            this.colFisTuru.Caption = "Fiş Türü";
            this.colFisTuru.FieldName = "FisTuru";
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.OptionsColumn.AllowEdit = false;
            this.colFisTuru.Visible = true;
            this.colFisTuru.VisibleIndex = 1;
            this.colFisTuru.Width = 161;
            // 
            // colBelgeNo
            // 
            this.colBelgeNo.Caption = "Belge No";
            this.colBelgeNo.FieldName = "BelgeNo";
            this.colBelgeNo.Name = "colBelgeNo";
            this.colBelgeNo.OptionsColumn.AllowEdit = false;
            this.colBelgeNo.Visible = true;
            this.colBelgeNo.VisibleIndex = 2;
            this.colBelgeNo.Width = 59;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsFilter.AllowFilter = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 3;
            this.colTarih.Width = 77;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "t";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 5;
            this.colSaat.Width = 77;
            // 
            // colPlasiyerKodu
            // 
            this.colPlasiyerKodu.Caption = "Pasiyer Kodu";
            this.colPlasiyerKodu.FieldName = "PlasiyerKodu";
            this.colPlasiyerKodu.Name = "colPlasiyerKodu";
            this.colPlasiyerKodu.OptionsColumn.AllowEdit = false;
            // 
            // colPlasiyerAdi
            // 
            this.colPlasiyerAdi.Caption = "Pasiyer Adı";
            this.colPlasiyerAdi.FieldName = "PlasiyerAdi";
            this.colPlasiyerAdi.Name = "colPlasiyerAdi";
            this.colPlasiyerAdi.OptionsColumn.AllowEdit = false;
            // 
            // colIskontoOrani1
            // 
            this.colIskontoOrani1.Caption = "İskonto Oranı";
            this.colIskontoOrani1.FieldName = "IskontoOrani1";
            this.colIskontoOrani1.Name = "colIskontoOrani1";
            this.colIskontoOrani1.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani1.Visible = true;
            this.colIskontoOrani1.VisibleIndex = 7;
            this.colIskontoOrani1.Width = 77;
            // 
            // colIskontoOrani2
            // 
            this.colIskontoOrani2.FieldName = "IskontoOrani2";
            this.colIskontoOrani2.Name = "colIskontoOrani2";
            this.colIskontoOrani2.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoOrani3
            // 
            this.colIskontoOrani3.FieldName = "IskontoOrani3";
            this.colIskontoOrani3.Name = "colIskontoOrani3";
            this.colIskontoOrani3.OptionsColumn.AllowEdit = false;
            this.colIskontoOrani3.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoTutari1
            // 
            this.colIskontoTutari1.Caption = "İskonto Tutarı";
            this.colIskontoTutari1.DisplayFormat.FormatString = "C2";
            this.colIskontoTutari1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIskontoTutari1.FieldName = "IskontoTutari1";
            this.colIskontoTutari1.Name = "colIskontoTutari1";
            this.colIskontoTutari1.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari1.Visible = true;
            this.colIskontoTutari1.VisibleIndex = 8;
            this.colIskontoTutari1.Width = 77;
            // 
            // colIskontoTutari2
            // 
            this.colIskontoTutari2.FieldName = "IskontoTutari2";
            this.colIskontoTutari2.Name = "colIskontoTutari2";
            this.colIskontoTutari2.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari2.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colIskontoTutari3
            // 
            this.colIskontoTutari3.FieldName = "IskontoTutari3";
            this.colIskontoTutari3.Name = "colIskontoTutari3";
            this.colIskontoTutari3.OptionsColumn.AllowEdit = false;
            this.colIskontoTutari3.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Caption = "Toplam Tutar";
            this.colToplamTutar.DisplayFormat.FormatString = "C2";
            this.colToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplamTutar.FieldName = "ToplamTutar";
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.OptionsColumn.AllowEdit = false;
            this.colToplamTutar.Visible = true;
            this.colToplamTutar.VisibleIndex = 9;
            this.colToplamTutar.Width = 77;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 6;
            // 
            // colOdenen
            // 
            this.colOdenen.Caption = "Ödenen Tutar";
            this.colOdenen.DisplayFormat.FormatString = "C2";
            this.colOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdenen.FieldName = "Odenen";
            this.colOdenen.Name = "colOdenen";
            this.colOdenen.OptionsColumn.AllowEdit = false;
            this.colOdenen.Visible = true;
            this.colOdenen.VisibleIndex = 10;
            this.colOdenen.Width = 77;
            // 
            // colKalanTutar
            // 
            this.colKalanTutar.Caption = "Kalan Tutar";
            this.colKalanTutar.DisplayFormat.FormatString = "C2";
            this.colKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colKalanTutar.FieldName = "KalanOdeme";
            this.colKalanTutar.Name = "colKalanTutar";
            this.colKalanTutar.OptionsColumn.AllowEdit = false;
            this.colKalanTutar.Visible = true;
            this.colKalanTutar.VisibleIndex = 11;
            this.colKalanTutar.Width = 87;
            // 
            // colAktifTutar
            // 
            this.colAktifTutar.Caption = "Aktif Bakiye";
            this.colAktifTutar.DisplayFormat.FormatString = "C2";
            this.colAktifTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAktifTutar.FieldName = "AktifTutar";
            this.colAktifTutar.Name = "colAktifTutar";
            this.colAktifTutar.OptionsColumn.AllowEdit = false;
            this.colAktifTutar.Visible = true;
            this.colAktifTutar.VisibleIndex = 13;
            // 
            // colVadeTarihi
            // 
            this.colVadeTarihi.Caption = "Vade Tarihi";
            this.colVadeTarihi.DisplayFormat.FormatString = "d";
            this.colVadeTarihi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colVadeTarihi.FieldName = "VadeTarihi";
            this.colVadeTarihi.Name = "colVadeTarihi";
            this.colVadeTarihi.OptionsColumn.AllowEdit = false;
            this.colVadeTarihi.Visible = true;
            this.colVadeTarihi.VisibleIndex = 4;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYazdir)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Dışa Aktar";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdf)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnExcel
            // 
            this.btnExcel.Caption = "Excel";
            this.btnExcel.Id = 2;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcel_ItemClick);
            // 
            // btnPdf
            // 
            this.btnPdf.Caption = "Pdf";
            this.btnPdf.Id = 3;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPdf_ItemClick);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Caption = "Yazdır";
            this.btnYazdir.Id = 4;
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYazdir_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.btnExcel,
            this.btnPdf,
            this.btnYazdir});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(936, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 599);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(936, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 599);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(936, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 599);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // frmCariEkstreTarih
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 599);
            this.Controls.Add(this.gridContCariHareket);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariEkstreTarih";
            this.ShowIcon = false;
            this.Text = "Cari Hesap Ekstresi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCariEkstreTarih_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCariHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraGrid.GridControl gridContCariHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridCariHareket;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colFisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colFisTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colBelgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colPlasiyerAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani1;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani2;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoOrani3;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari1;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari2;
        private DevExpress.XtraGrid.Columns.GridColumn colIskontoTutari3;
        private DevExpress.XtraGrid.Columns.GridColumn colToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn colKalanTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colAktifTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colVadeTarihi;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnExcel;
        private DevExpress.XtraBars.BarButtonItem btnPdf;
        private DevExpress.XtraBars.BarButtonItem btnYazdir;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}