using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;

namespace NetSatis.Reports.Fatura_ve_Fiş
{
    public partial class rptProformaFatura : DevExpress.XtraReports.UI.XtraReport
    {

        public rptProformaFatura()
        {
            InitializeComponent();
            //NetSatisContext context = new NetSatisContext();
            //StokHareketDAL stokHareketDal = new StokHareketDAL();

            //FisDAL fisDal = new FisDAL();


            //Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fisKodu);

            //ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetAll(context, c => c.FisKodu == fisKodu) };

            ////fatura başlık

            //lblCariAdi.Text = fisBilgi.Cari.FaturaUnvani;
            //lblAdres.Text = fisBilgi.Cari.Adres;
            //lblTarih.Text = fisBilgi.Tarih.ToString();
            //lblVergiDairesi.Text = fisBilgi.Cari.VergiDairesi;
            //lblVergiNo.Text = fisBilgi.Cari.VergiNo;


            // lblIkametgah.Text =  fisBilgi.Cari.Ilce + "-" + fisBilgi.Cari.Il;
            ////fatura ürünler
            //this.DataSource = stokHareketDataSource;
            ////colBarkodu.DataBindings.Add("Text", this.DataSource, "Stok.Barkodu");
            //colStokKodu.DataBindings.Add("Text", this.DataSource, "Stok.StokKodu");
            //colStokAdi.DataBindings.Add("Text", this.DataSource, "Stok.StokAdi");
            //colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar", "{0:N2}");
            //colBirim.DataBindings.Add("Text", this.DataSource, "Stok.Birim");
            //colIskonto.DataBindings.Add("Text", this.DataSource, "IndirimOrani");
            //colBirimFiyati.DataBindings.Add("Text", this.DataSource, "BirimFiyati", "{0:C2}");
            //colKdv.DataBindings.Add("Text", this.DataSource, "Kdv");


            //// KDV siz Fiyat
            //// [BirimFiyati] / (ToDecimal([Kdv]) / 100 + 1)//hesaplamalar
            //if (fisBilgi.KDVDahil)
            //{
            //    CalculatedField calcKdvSizBF = new CalculatedField();
            //    this.CalculatedFields.Add(calcKdvSizBF);
            //    calcKdvSizBF.Name = "KdvSizBirimFiyati";
            //    calcKdvSizBF.Expression = "[BirimFiyati] / (ToDecimal([Kdv]) / 100 + 1)";
            //}



            //CalculatedField calcIndirimTutari = new CalculatedField();
            //this.CalculatedFields.Add(calcIndirimTutari);
            //calcIndirimTutari.Name = "IndirimTutari";
            //if (fisBilgi.KDVDahil)
            //{
            //    calcIndirimTutari.Expression = "([KdvSizBirimFiyati]*[Miktar])/100*[IndirimOrani]";
            //}
            //else
            //{
            //    calcIndirimTutari.Expression = "([BirimFiyati]*[Miktar])/100*[IndirimOrani]";
            //}


            //CalculatedField calcKdvToplam = new CalculatedField();
            //this.CalculatedFields.Add(calcKdvToplam);
            //calcKdvToplam.Name = "KdvTutari";
            //if (fisBilgi.KDVDahil)
            //{
            //    calcKdvToplam.Expression = "([KdvSizBirimFiyati]*[Miktar]-[IndirimTutari]) / 100* [Kdv]";
            //}
            //else
            //{
            //    calcKdvToplam.Expression = "([BirimFiyati]*[Miktar]-[IndirimTutari]) / 100* [Kdv]";
            //}



            //CalculatedField calcTutar = new CalculatedField();
            //this.CalculatedFields.Add(calcTutar);
            //calcTutar.Name = "Tutar";
            //if (fisBilgi.KDVDahil)
            //{
            //    calcTutar.Expression = "[KdvSizBirimFiyati]*[Miktar]";
            //}
            //else
            //{
            //    calcTutar.Expression = "[BirimFiyati]*[Miktar]";
            //}


            //CalculatedField calcKdvliTutar = new CalculatedField();
            //this.CalculatedFields.Add(calcKdvliTutar);
            //calcKdvliTutar.Name = "KdvliTutar";
            //if (fisBilgi.KDVDahil)
            //{
            //    calcKdvliTutar.Expression = "([KdvSizBirimFiyati]*[Miktar])-[IndirimTutari]+[KdvTutari]";
            //}
            //else
            //{
            //    calcKdvliTutar.Expression = "([BirimFiyati]*[Miktar])-[IndirimTutari]+[KdvTutari]";
            //}


            //colToplamTutar.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            //XRSummary sumAraToplam = new XRSummary();
            //sumAraToplam.Func = SummaryFunc.Sum;
            //sumAraToplam.Running = SummaryRunning.Page;
            //sumAraToplam.FormatString = "{0:C2}";

            //XRSummary sumKdvToplam = new XRSummary();
            //sumKdvToplam.Func = SummaryFunc.Sum;
            //sumKdvToplam.Running = SummaryRunning.Page;
            //sumKdvToplam.FormatString = "{0:C2}";

            //XRSummary sumGenelToplam = new XRSummary();
            //sumGenelToplam.Func = SummaryFunc.Sum;
            //sumGenelToplam.Running = SummaryRunning.Page;
            //sumGenelToplam.FormatString = "{0:C2}";

            //XRSummary sumIndirimToplam = new XRSummary();
            //sumIndirimToplam.Func = SummaryFunc.Sum;
            //sumIndirimToplam.Running = SummaryRunning.Page;
            //sumIndirimToplam.FormatString = "{0:C2}";

            //lblAraToplam.DataBindings.Add("Text", null, "Tutar");
            //lblKdvToplam.DataBindings.Add("Text", null, "KdvTutari");
            //lblGenelToplam.DataBindings.Add("Text", null, "KdvliTutar");
            //lblIndirimTutari.DataBindings.Add("Text", null, "IndirimTutari");

            //lblAraToplam.Summary = sumAraToplam;
            //lblKdvToplam.Summary = sumKdvToplam;
            //lblGenelToplam.Summary = sumGenelToplam;
            //lblIndirimTutari.Summary = sumIndirimToplam;
        }

    }
}
