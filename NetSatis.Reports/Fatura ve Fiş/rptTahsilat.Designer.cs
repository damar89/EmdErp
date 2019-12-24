namespace NetSatis.Reports.Fatura_ve_Fiş
{
    partial class rptTahsilat
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colFisKodu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colFisTuru = new DevExpress.XtraReports.UI.XRTableCell();
            this.colTarih = new DevExpress.XtraReports.UI.XRTableCell();
            this.colAlinan = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.colBakiye = new DevExpress.XtraReports.UI.XRLabel();
            this.FirmaAdi = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 42.33333F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnWidth;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Dpi = 254F;
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(47.45832F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(675.8126F, 42.33333F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colFisKodu,
            this.colFisTuru,
            this.colTarih,
            this.colAlinan});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colFisKodu
            // 
            this.colFisKodu.CanGrow = false;
            this.colFisKodu.Dpi = 254F;
            this.colFisKodu.Name = "colFisKodu";
            this.colFisKodu.StylePriority.UseTextAlignment = false;
            this.colFisKodu.Text = "colFisKodu";
            this.colFisKodu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.colFisKodu.Weight = 1.723595427021053D;
            // 
            // colFisTuru
            // 
            this.colFisTuru.CanGrow = false;
            this.colFisTuru.Dpi = 254F;
            this.colFisTuru.Name = "colFisTuru";
            this.colFisTuru.StylePriority.UseTextAlignment = false;
            this.colFisTuru.Text = "colFisTuru";
            this.colFisTuru.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.colFisTuru.Weight = 1.6872652985492169D;
            // 
            // colTarih
            // 
            this.colTarih.CanGrow = false;
            this.colTarih.Dpi = 254F;
            this.colTarih.Name = "colTarih";
            this.colTarih.StylePriority.UseFont = false;
            this.colTarih.StylePriority.UseTextAlignment = false;
            this.colTarih.Text = "01.01.1999";
            this.colTarih.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colTarih.Weight = 1.6577798061809379D;
            // 
            // colAlinan
            // 
            this.colAlinan.CanGrow = false;
            this.colAlinan.Dpi = 254F;
            this.colAlinan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.colAlinan.Name = "colAlinan";
            this.colAlinan.StylePriority.UseFont = false;
            this.colAlinan.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:c2}";
            this.colAlinan.Summary = xrSummary1;
            this.colAlinan.Text = "colAlinan";
            this.colAlinan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.colAlinan.Weight = 1.5088384140027795D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.lblCariAdi,
            this.xrLabel3,
            this.xrLabel1,
            this.xrPageInfo1});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 291.9167F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?FirmaAdi")});
            this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(120.7424F, 24.78834F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(582.0834F, 58.42001F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "FİRMA ADI";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Dpi = 254F;
            this.lblCariAdi.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(334.5479F, 156.1044F);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(436.4521F, 58.42F);
            this.lblCariAdi.StylePriority.UseFont = false;
            this.lblCariAdi.StylePriority.UseTextAlignment = false;
            this.lblCariAdi.Text = "lblCariAdi";
            this.lblCariAdi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(50.25329F, 156.1044F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(271.1494F, 58.42004F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Ödeme Yapan Cari :";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(190.9924F, 83.20834F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(470.9584F, 58.42F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Tahsilat Makbuzu";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Dpi = 254F;
            this.xrPageInfo1.Font = new System.Drawing.Font("Tahoma", 7.5F);
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(50.25329F, 233.4967F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(431.9176F, 58.42001F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrPageInfo1.TextFormatString = "Rapor Tarihi : {0}";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 49.39581F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Dpi = 254F;
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(47.45834F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(675.8125F, 49.08332F);
            this.xrTable2.StylePriority.UseBorderDashStyle = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell6});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Fiş Kodu";
            this.xrTableCell3.Weight = 0.869689290283126D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Fiş Türü";
            this.xrTableCell4.Weight = 0.87789412563299929D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "İşem Tarihi";
            this.xrTableCell1.Weight = 0.856960192235881D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Dpi = 254F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Tutar";
            this.xrTableCell6.Weight = 0.7143109468763621D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.colBakiye});
            this.ReportFooter.Dpi = 254F;
            this.ReportFooter.HeightF = 70.22916F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(165.7215F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(316.4494F, 58.42F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Kalan Bakiye :";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel5.Visible = false;
            // 
            // colBakiye
            // 
            this.colBakiye.Dpi = 254F;
            this.colBakiye.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.colBakiye.LocationFloat = new DevExpress.Utils.PointFloat(501.0521F, 0F);
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.colBakiye.SizeF = new System.Drawing.SizeF(222.2188F, 58.42F);
            this.colBakiye.StylePriority.UseFont = false;
            this.colBakiye.StylePriority.UseTextAlignment = false;
            this.colBakiye.Text = "colBakiye";
            this.colBakiye.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.colBakiye.TextFormatString = "{0:c2}";
            this.colBakiye.Visible = false;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.Description = "FirmaAdi";
            this.FirmaAdi.Name = "FirmaAdi";
            // 
            // rptTahsilat
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.ReportFooter});
            this.DesignerOptions.ShowExportWarnings = false;
            this.DesignerOptions.ShowPrintingWarnings = false;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(1, 3, 292, 25);
            this.PageWidth = 800;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FirmaAdi});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.RollPaper = true;
            this.ShowPrintMarginsWarning = false;
            this.SnapGridSize = 25F;
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colFisKodu;
        private DevExpress.XtraReports.UI.XRTableCell colFisTuru;
        private DevExpress.XtraReports.UI.XRTableCell colTarih;
        private DevExpress.XtraReports.UI.XRTableCell colAlinan;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel colBakiye;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.Parameters.Parameter FirmaAdi;
    }
}
