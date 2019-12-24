namespace NetSatis.Reports.Fatura_ve_Fiş
{
    partial class rptTeklif
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.FirmaAdi = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIndirimTutari = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.lblGenelToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblKdvToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAraToplam = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.lblCariAdi = new DevExpress.XtraReports.UI.XRLabel();
            this.lblAdres = new DevExpress.XtraReports.UI.XRLabel();
            this.lblIkametgah = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTarih = new DevExpress.XtraReports.UI.XRLabel();
            this.lblVergiNo = new DevExpress.XtraReports.UI.XRLabel();
            this.lblVergiDairesi = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
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
            this.dataSEtler1 = new NetSatis.Reports.DataSEtler();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSEtler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 254F;
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel11,
            this.xrLabel12});
            this.TopMargin.Dpi = 254F;
            this.TopMargin.HeightF = 211F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.FirmaAdi, "Text", "")});
            this.xrLabel11.Dpi = 254F;
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(413.8669F, 38.42918F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(1201.266F, 76.9408F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Cari Adı :";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.Description = "FirmaAdı";
            this.FirmaAdi.Name = "FirmaAdi";
            // 
            // xrLabel12
            // 
            this.xrLabel12.Dpi = 254F;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(413.8669F, 131.0334F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(1201.266F, 76.39165F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Teklif Formu";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 254F;
            this.BottomMargin.HeightF = 132F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.lblIndirimTutari,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.lblGenelToplam,
            this.lblKdvToplam,
            this.lblAraToplam});
            this.PageFooter.Dpi = 254F;
            this.PageFooter.HeightF = 259.0833F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Dpi = 254F;
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(1202.422F, 69.40662F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "İndirim Tutarı";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // lblIndirimTutari
            // 
            this.lblIndirimTutari.Dpi = 254F;
            this.lblIndirimTutari.LocationFloat = new DevExpress.Utils.PointFloat(1596.651F, 69.40662F);
            this.lblIndirimTutari.Name = "lblIndirimTutari";
            this.lblIndirimTutari.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIndirimTutari.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.lblIndirimTutari.StylePriority.UseTextAlignment = false;
            this.lblIndirimTutari.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Dpi = 254F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(1202.422F, 186.2467F);
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
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(1202.422F, 127.8265F);
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
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(1202.422F, 10.98673F);
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
            this.lblGenelToplam.LocationFloat = new DevExpress.Utils.PointFloat(1596.651F, 186.2467F);
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
            this.lblKdvToplam.LocationFloat = new DevExpress.Utils.PointFloat(1596.651F, 127.8265F);
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
            this.lblAraToplam.LocationFloat = new DevExpress.Utils.PointFloat(1596.651F, 10.98673F);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAraToplam.SizeF = new System.Drawing.SizeF(362.9434F, 58.42F);
            this.lblAraToplam.StylePriority.UseTextAlignment = false;
            this.lblAraToplam.Text = "AraToplam";
            this.lblAraToplam.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.lblCariAdi,
            this.lblAdres,
            this.lblIkametgah,
            this.lblTarih,
            this.lblVergiNo,
            this.lblVergiDairesi,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10});
            this.PageHeader.Dpi = 254F;
            this.PageHeader.HeightF = 542F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Dpi = 254F;
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(14.50001F, 487.7605F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1936F, 47.62494F);
            this.xrTable2.StylePriority.UseBorderDashStyle = false;
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell8});
            this.xrTableRow2.Dpi = 254F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Dpi = 254F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "StokKodu";
            this.xrTableCell2.Weight = 0.91748847831636515D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Dpi = 254F;
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.Text = "Stok Adı";
            this.xrTableCell3.Weight = 2.9347169003900015D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Dpi = 254F;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Birimi";
            this.xrTableCell4.Weight = 0.4916687566163333D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Dpi = 254F;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Miktarı";
            this.xrTableCell5.Weight = 0.43877916100865466D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Dpi = 254F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Fiyatı";
            this.xrTableCell6.Weight = 0.79898906609003084D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Dpi = 254F;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "İsk";
            this.xrTableCell1.Weight = 0.37561545534231194D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Dpi = 254F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Kdv";
            this.xrTableCell7.Weight = 0.31584053479824881D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Dpi = 254F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Tutar";
            this.xrTableCell8.Weight = 0.62392568371372614D;
            // 
            // lblCariAdi
            // 
            this.lblCariAdi.Dpi = 254F;
            this.lblCariAdi.LocationFloat = new DevExpress.Utils.PointFloat(298.4781F, 34.88571F);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblCariAdi.SizeF = new System.Drawing.SizeF(788.4584F, 111.3366F);
            this.lblCariAdi.Text = "CariAdi";
            // 
            // lblAdres
            // 
            this.lblAdres.Dpi = 254F;
            this.lblAdres.LocationFloat = new DevExpress.Utils.PointFloat(298.4781F, 146.2223F);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblAdres.SizeF = new System.Drawing.SizeF(788.4584F, 95.46172F);
            this.lblAdres.Text = "Adres";
            // 
            // lblIkametgah
            // 
            this.lblIkametgah.Dpi = 254F;
            this.lblIkametgah.LocationFloat = new DevExpress.Utils.PointFloat(298.4781F, 241.6841F);
            this.lblIkametgah.Name = "lblIkametgah";
            this.lblIkametgah.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblIkametgah.SizeF = new System.Drawing.SizeF(788.4584F, 58.42001F);
            this.lblIkametgah.Text = "[Semt] \\ [Ilce] \\ [Il]";
            // 
            // lblTarih
            // 
            this.lblTarih.Dpi = 254F;
            this.lblTarih.LocationFloat = new DevExpress.Utils.PointFloat(298.4781F, 300.104F);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblTarih.SizeF = new System.Drawing.SizeF(788.4584F, 58.41995F);
            this.lblTarih.Text = "Tarih";
            // 
            // lblVergiNo
            // 
            this.lblVergiNo.Dpi = 254F;
            this.lblVergiNo.LocationFloat = new DevExpress.Utils.PointFloat(298.4781F, 416.9442F);
            this.lblVergiNo.Name = "lblVergiNo";
            this.lblVergiNo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblVergiNo.SizeF = new System.Drawing.SizeF(788.4584F, 58.41998F);
            // 
            // lblVergiDairesi
            // 
            this.lblVergiDairesi.Dpi = 254F;
            this.lblVergiDairesi.LocationFloat = new DevExpress.Utils.PointFloat(298.4781F, 358.5243F);
            this.lblVergiDairesi.Name = "lblVergiDairesi";
            this.lblVergiDairesi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.lblVergiDairesi.SizeF = new System.Drawing.SizeF(788.4584F, 58.42001F);
            // 
            // xrLabel5
            // 
            this.xrLabel5.Dpi = 254F;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 34.88579F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(227.5417F, 58.41999F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Cari Adı :";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel6
            // 
            this.xrLabel6.Dpi = 254F;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 146.2224F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(227.5417F, 84.87836F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Adres :";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Dpi = 254F;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 241.6841F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(227.5417F, 58.42007F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Semt/İl/İlçe :";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Dpi = 254F;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 302.7498F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(227.5417F, 55.77423F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Tarih :";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Dpi = 254F;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 361.1701F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(227.5417F, 55.7742F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Vergi Dairesi :";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Dpi = 254F;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(25.00001F, 419.59F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(227.5417F, 55.77426F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Vergi No :";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataMember = "FaturaKalemler";
            this.DetailReport.DataSource = this.dataSEtler1;
            this.DetailReport.Dpi = 254F;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail1.Dpi = 254F;
            this.Detail1.HeightF = 37.04167F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable1
            // 
            this.xrTable1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.xrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.xrTable1.Dpi = 254F;
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 7.5F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(14.5F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1936F, 35F);
            this.xrTable1.StylePriority.UseBorderDashStyle = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
            this.colStokKodu.StylePriority.UseTextAlignment = false;
            this.colStokKodu.Text = "colStokKodu";
            this.colStokKodu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.colStokKodu.Weight = 0.86930639127412135D;
            // 
            // colStokAdi
            // 
            this.colStokAdi.Dpi = 254F;
            this.colStokAdi.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.colStokAdi.Name = "colStokAdi";
            this.colStokAdi.StylePriority.UseFont = false;
            this.colStokAdi.StylePriority.UseTextAlignment = false;
            this.colStokAdi.Text = "colStokAdi";
            this.colStokAdi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.colStokAdi.Weight = 2.8559911200766939D;
            // 
            // colBirim
            // 
            this.colBirim.Dpi = 254F;
            this.colBirim.Name = "colBirim";
            this.colBirim.Text = "colBirim";
            this.colBirim.Weight = 0.47547167406315044D;
            // 
            // colMiktar
            // 
            this.colMiktar.Dpi = 254F;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.Text = "colMiktar";
            this.colMiktar.Weight = 0.42432352520144456D;
            // 
            // colBirimFiyati
            // 
            this.colBirimFiyati.Dpi = 254F;
            this.colBirimFiyati.Name = "colBirimFiyati";
            this.colBirimFiyati.Text = "colBirimFiyati";
            this.colBirimFiyati.Weight = 0.77266678457243876D;
            // 
            // colIskonto
            // 
            this.colIskonto.Dpi = 254F;
            this.colIskonto.Name = "colIskonto";
            this.colIskonto.Weight = 0.36324108763574686D;
            // 
            // colKdv
            // 
            this.colKdv.Dpi = 254F;
            this.colKdv.Name = "colKdv";
            this.colKdv.Text = "colKdv";
            this.colKdv.Weight = 0.30543532254832556D;
            // 
            // colToplamTutar
            // 
            this.colToplamTutar.Dpi = 254F;
            this.colToplamTutar.Name = "colToplamTutar";
            this.colToplamTutar.StylePriority.UseTextAlignment = false;
            this.colToplamTutar.Text = "colToplamTutar";
            this.colToplamTutar.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.colToplamTutar.Weight = 0.60337109396930377D;
            // 
            // dataSEtler1
            // 
            this.dataSEtler1.DataSetName = "DataSEtler";
            this.dataSEtler1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptTeklif
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter,
            this.PageHeader,
            this.DetailReport});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.dataSEtler1});
            this.DataMember = "FaturaBilgiler";
            this.DataSource = this.dataSEtler1;
            this.Dpi = 254F;
            this.Margins = new System.Drawing.Printing.Margins(58, 77, 211, 132);
            this.PageHeight = 2970;
            this.PageWidth = 2100;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.FirmaAdi});
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
            this.ShowPrintMarginsWarning = false;
            this.SnapGridSize = 25F;
            this.Version = "17.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSEtler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.Parameters.Parameter FirmaAdi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel lblCariAdi;
        private DevExpress.XtraReports.UI.XRLabel lblAdres;
        private DevExpress.XtraReports.UI.XRLabel lblIkametgah;
        private DevExpress.XtraReports.UI.XRLabel lblTarih;
        private DevExpress.XtraReports.UI.XRLabel lblVergiNo;
        private DevExpress.XtraReports.UI.XRLabel lblVergiDairesi;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel lblIndirimTutari;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel lblGenelToplam;
        private DevExpress.XtraReports.UI.XRLabel lblKdvToplam;
        private DevExpress.XtraReports.UI.XRLabel lblAraToplam;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell colStokKodu;
        private DevExpress.XtraReports.UI.XRTableCell colStokAdi;
        private DevExpress.XtraReports.UI.XRTableCell colBirim;
        private DevExpress.XtraReports.UI.XRTableCell colMiktar;
        private DevExpress.XtraReports.UI.XRTableCell colBirimFiyati;
        private DevExpress.XtraReports.UI.XRTableCell colIskonto;
        private DevExpress.XtraReports.UI.XRTableCell colKdv;
        private DevExpress.XtraReports.UI.XRTableCell colToplamTutar;
        private DataSEtler dataSEtler1;
    }
}
