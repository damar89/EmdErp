namespace NetSatis.Reports.Fatura_ve_Fiş
{
    partial class rptFatura
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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.colStokKodu = new DevExpress.XtraReports.UI.XRTableCell();
            this.colStokAdi = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirim = new DevExpress.XtraReports.UI.XRTableCell();
            this.colMiktar = new DevExpress.XtraReports.UI.XRTableCell();
            this.colBirimFiyati = new DevExpress.XtraReports.UI.XRTableCell();
            this.colIskonto = new DevExpress.XtraReports.UI.XRTableCell();
            this.colKdv = new DevExpress.XtraReports.UI.XRTableCell();
            this.colToplamTutar = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIndirimTutari = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblYaziyla = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lblVergiDairesi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblVergiNo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTarih = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIkametgah = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.Dpi = 254F;
            this.Detail.HeightF = 44.64584F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Dpi = 254F;
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 7.5F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(25F, 2.645834F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1961F, 35F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.colStokKodu,
            this.colStokAdi,
            this.colBirim,
            this.colMiktar,
            this.colBirimFiyati,
            this.colIskonto,
            this.colKdv,
            this.colToplamTutar});
            this.xrTableRow1.Dpi = 254F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // colStokKodu
            // 
            this.colStokKodu.Dpi = 254F;
            this.colStokKodu.Name = "colStokKodu";
            this.colStokKodu.Text = "colStokKodu";
            this.colStokKodu.Weight = 0.86930639127412135D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Dpi = 254F;
            this.colStokAdi.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.StylePriority.UseFont = false;
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.Weight = 2.8467189842684366D;
            // 
            // colBirim
            // 
            this.colBirim.Dpi = 254F;
            this.colBirim.Name = "colBirim";
            this.colBirim.StylePriority.UseTextAlignment = false;
            this.colBirim.Text = "colBirim";
            this.colBirim.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colBirim.Weight = 0.55186763660050309D;
            // 
            // colMiktar
            // 
            this.colMiktar.Dpi = 254F;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.StylePriority.UseTextAlignment = false;
            this.colMiktar.Text = "colMiktar";
            this.colMiktar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colMiktar.Weight = 0.49571909183324481D;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Dpi = 254F;
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.StylePriority.UseTextAlignment = false;
            this.colBirimFiyati.Text = "colBirimFiyati";
            this.colBirimFiyati.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colBirimFiyati.Weight = 0.53354970384171307D;
            // 
            // colIskonto
            // 
            this.colIskonto.Dpi = 254F;
            this.colIskonto.Name = "colIskonto";
            this.colIskonto.StylePriority.UseTextAlignment = false;
            this.colIskonto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colIskonto.Weight = 0.4059358032297663D;
            // 
            // colKdv
            // 
            this.colKdv.Dpi = 254F;
            this.colKdv.Name = "colKdv";
            this.colKdv.StylePriority.UseTextAlignment = false;
            this.colKdv.Text = "colKdv";
            this.colKdv.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colKdv.Weight = 0.46360671707569656D;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Dpi = 254F;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.StylePriority.UseTextAlignment = false;
            this.colToplamTutar.Text = "colToplamTutar";
            this.colToplamTutar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colToplamTutar.Weight = 0.58923137730427777D;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 185F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 254F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.lblIndirimTutari,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.lblGenelToplam,
            this.lblKdvToplam,
            this.lblAraToplam,
            this.xrLabel4,
            this.lblYaziyla});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 240.5625F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(1228.828F, 58.42F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "İndirim Tutarı";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblIndirimTutari
            // 
            this.lblIndirimTutari.Dpi = 254F;
            this.lblIndirimTutari.LocationFloat = new DevExpress.Utils.PointFloat(1623.057F, 58.42F);
            this.lblIndirimTutari.Name = "lblIndirimTutari";
            this.lblIndirimTutari.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIndirimTutari.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.lblIndirimTutari.StylePriority.UseTextAlignment = false;
            this.lblIndirimTutari.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1228.828F, 175.2599F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "GenelToplam :";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Dpi = 254F;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(1228.828F, 116.8398F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(362.9434F, 58.42001F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "KdvToplam :";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Dpi = 254F;
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1228.828F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "AraToplam :";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Dpi = 254F;
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(1623.057F, 175.2599F);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblGenelToplam.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.lblGenelToplam.StylePriority.UseTextAlignment = false;
            this.lblGenelToplam.Text = "GenelToplam";
            this.lblGenelToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblKdvToplam
            // 
            this.lblKdvToplam.Dpi = 254F;
            this.lblKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(1623.057F, 116.84F);
            this.lblKdvToplam.Name = "lblKdvToplam";
            this.lblKdvToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblKdvToplam.SizeF = new System.Drawing.SizeF(362.9434F, 58.42001F);
            this.lblKdvToplam.StylePriority.UseTextAlignment = false;
            this.lblKdvToplam.Text = "KdvToplam";
            this.lblKdvToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.Dpi = 254F;
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(1623.057F, 0F);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.lblAraToplam.StylePriority.UseTextAlignment = false;
            this.lblAraToplam.Text = "AraToplam";
            this.lblAraToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 101.58F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(132.2917F, 58.41999F);
            this.xrLabel4.Text = "Yalnız :";
            // 
            // lblYaziyla
            // 
            this.lblYaziyla.Dpi = 254F;
            this.lblYaziyla.LocationFloat = new DevExpress.Utils.PointFloat(190.1876F, 101.58F);
            this.lblYaziyla.Name = "lblYaziyla";
            this.lblYaziyla.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblYaziyla.SizeF = new System.Drawing.SizeF(812.2709F, 58.41999F);
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblVergiDairesi,
            this.lblVergiNo,
            this.lblTarih,
            this.lblIkametgah,
            this.lblAdres,
            this.lblCariAdi});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 483.7917F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.Dpi = 254F;
            this.lblVergiDairesi.LocationFloat = new DevExpress.Utils.PointFloat(35.58342F, 341.1011F);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblVergiDairesi.SizeF = new System.Drawing.SizeF(788.4584F, 58.42001F);
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.Dpi = 254F;
            this.lblVergiNo.LocationFloat = new DevExpress.Utils.PointFloat(35.58342F, 399.5208F);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblVergiNo.SizeF = new System.Drawing.SizeF(788.4584F, 58.41998F);
            // 
            // lblTarih
            // 
            this.lblTarih.Dpi = 254F;
            this.lblTarih.LocationFloat = new DevExpress.Utils.PointFloat(35.58342F, 282.681F);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTarih.SizeF = new System.Drawing.SizeF(788.4584F, 58.41995F);
            this.lblTarih.Text = "Tarih";
            // 
            // lblIkametgah
            // 
            this.lblIkametgah.Dpi = 254F;
            this.lblIkametgah.LocationFloat = new DevExpress.Utils.PointFloat(35.58342F, 224.2609F);
            this.lblIkametgah.Name = "lblIkametgah";
            this.lblIkametgah.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIkametgah.SizeF = new System.Drawing.SizeF(788.4584F, 58.42001F);
            this.lblIkametgah.Text = "[Semt] \\ [Ilce] \\ [Il]";
            // 
            // lblAdres
            // 
            this.lblAdres.Dpi = 254F;
            this.lblAdres.LocationFloat = new DevExpress.Utils.PointFloat(35.58342F, 128.7991F);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAdres.SizeF = new System.Drawing.SizeF(788.4584F, 95.46172F);
            this.lblAdres.Text = "Adres";
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Dpi = 254F;
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(35.5834F, 17.46252F);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(788.4584F, 111.3366F);
            this.lblCariAdi.Text = "CariAdi";
            // 
            // rptFatura
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader});
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(40, 74, 185, 254);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.SnapGridSize = 25F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRLabel lblTarih;
        private DevExpress.XtraReports.UI.XRLabel lblIkametgah;
        private DevExpress.XtraReports.UI.XRLabel lblAdres;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.XRLabel lblVergiDairesi;
        private DevExpress.XtraReports.UI.XRLabel lblVergiNo;
        private DevExpress.XtraReports.UI.XRTableCell colStokKodu;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyati;
        private DevExpress.XtraReports.UI.XRTableCell colKdv;
        private DevExpress.XtraReports.UI.XRTableCell colToplamTutar;
        private DevExpress.XtraReports.UI.XRTableCell colBirim;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel lblKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRTableCell colIskonto;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel lblIndirimTutari;
        private DevExpress.XtraReports.UI.XRLabel lblYaziyla;
    }
}
