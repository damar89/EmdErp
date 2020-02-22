namespace NetSatis.Reports.Cari
{
    partial class rptCariBakiye
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
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colCariKodu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colCariAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colIl = new DevExpress.XtraReports.UI.XRTableCell();
            this.colIlce = new DevExpress.XtraReports.UI.XRTableCell();
            this.colAlacak = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBorc = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBakiye = new DevExpress.XtraReports.UI.XRTableCell();
            this.colDurum = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.lblDurum = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 16.66667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(796F, 14.99999F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colCariKodu,
            this.colCariAdi,
            this.colIl,
            this.colIlce,
            this.colAlacak,
            this.colBorc,
            this.colBakiye,
            this.colDurum});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colCariKodu
            // 
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Text = "colCariKodu";
            this.colCariKodu.Weight = 1.0104166412353517D;
            // 
            // colCariAdi
            // 
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Text = "colCariAdi";
            this.colCariAdi.Weight = 2.0520836008372143D;
            // 
            // colIl
            // 
            this.colIl.Name = "colIl";
            this.colIl.StylePriority.UseTextAlignment = false;
            this.colIl.Text = "colIl";
            this.colIl.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colIl.Weight = 0.8854162489025843D;
            // 
            // colIlce
            // 
            this.colIlce.Name = "colIlce";
            this.colIlce.StylePriority.UseTextAlignment = false;
            this.colIlce.Text = "colIlce";
            this.colIlce.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colIlce.Weight = 0.80208343736575727D;
            // 
            // colAlacak
            // 
            this.colAlacak.Name = "colAlacak";
            this.colAlacak.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:c2}";
            this.colAlacak.Summary = xrSummary1;
            this.colAlacak.Text = "colAlacak";
            this.colAlacak.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colAlacak.Weight = 0.8029000035878725D;
            // 
            // colBorc
            // 
            this.colBorc.Name = "colBorc";
            this.colBorc.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0:c2}";
            this.colBorc.Summary = xrSummary2;
            this.colBorc.Text = "colBorc";
            this.colBorc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colBorc.Weight = 0.801700050358294D;
            // 
            // colBakiye
            // 
            this.colBakiye.Name = "colBakiye";
            this.colBakiye.StylePriority.UseTextAlignment = false;
            xrSummary3.FormatString = "{0:c2}";
            this.colBakiye.Summary = xrSummary3;
            this.colBakiye.Text = "colBakiye";
            this.colBakiye.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colBakiye.Weight = 0.80539984361513961D;
            // 
            // colDurum
            // 
            this.colDurum.Name = "colDurum";
            this.colDurum.StylePriority.UseTextAlignment = false;
            this.colDurum.Text = "colDurum";
            this.colDurum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.colDurum.Weight = 0.80000090352615372D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrLabel1});
            this.TopMargin.HeightF = 61F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPageInfo2
            // 
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 34.25F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(195.8333F, 16.74999F);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrPageInfo2.TextFormatString = "Rapor Tarihi : {0}";
            // 
            // xrLabel1
            // 
            this.xrLabel1.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(796F, 23F);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Cari Bakiye Durum Raporu";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.ReportHeader.HeightF = 29.16667F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.LightGray;
            this.xrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(795.9999F, 25F);
            this.xrTable2.StylePriority.UseBackColor = false;
            this.xrTable2.StylePriority.UseBorderDashStyle = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Cari Kodu";
            this.xrTableCell1.Weight = 1.0104166412353517D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Cari Adı";
            this.xrTableCell2.Weight = 2.0520834666199281D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "İl";
            this.xrTableCell4.Weight = 0.88541656046816053D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "İlçe";
            this.xrTableCell5.Weight = 0.802082822221867D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Alacağı";
            this.xrTableCell6.Weight = 0.8028999328224129D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Borcu";
            this.xrTableCell7.Weight = 0.80169998767208217D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Bakiye";
            this.xrTableCell8.Weight = 0.80539986585268575D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Durum";
            this.xrTableCell9.Weight = 0.79999886530840425D;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.BackColor = System.Drawing.Color.LightGray;
            this.lblGenelToplam.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(672.9167F, 0F);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblGenelToplam.SizeF = new System.Drawing.SizeF(123.0832F, 23F);
            this.lblGenelToplam.StylePriority.UseBackColor = false;
            this.lblGenelToplam.StylePriority.UseFont = false;
            this.lblGenelToplam.StylePriority.UseTextAlignment = false;
            this.lblGenelToplam.Text = "lblGenelToplam";
            this.lblGenelToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.lblGenelToplam.Visible = false;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDurum,
            this.xrLabel2,
            this.lblGenelToplam});
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // lblDurum
            // 
            this.lblDurum.BackColor = System.Drawing.Color.LightGray;
            this.lblDurum.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDurum.LocationFloat = new DevExpress.Utils.PointFloat(672.9167F, 22.99999F);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblDurum.SizeF = new System.Drawing.SizeF(123.0832F, 23F);
            this.lblDurum.StylePriority.UseBackColor = false;
            this.lblDurum.StylePriority.UseFont = false;
            this.lblDurum.StylePriority.UseTextAlignment = false;
            this.lblDurum.Text = "lblDurum";
            this.lblDurum.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.lblDurum.Visible = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.BackColor = System.Drawing.Color.LightGray;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(529.1667F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(123.0832F, 23F);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.Text = "Toplam Bakiye :";
            this.xrLabel2.Visible = false;
            // 
            // rptCariBakiye
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupFooter1});
            this.Margins = new System.Drawing.Printing.Margins(15, 16, 61, 100);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colCariKodu;
        private DevExpress.XtraReports.UI.XRTableCell colCariAdi;
        private DevExpress.XtraReports.UI.XRTableCell colIl;
        private DevExpress.XtraReports.UI.XRTableCell colIlce;
        private DevExpress.XtraReports.UI.XRTableCell colAlacak;
        private DevExpress.XtraReports.UI.XRTableCell colBorc;
        private DevExpress.XtraReports.UI.XRTableCell colBakiye;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRTableCell colDurum;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRLabel lblDurum;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
