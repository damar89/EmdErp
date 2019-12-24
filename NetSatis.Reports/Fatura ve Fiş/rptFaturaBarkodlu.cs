using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System.Data;

namespace NetSatis.Reports.Fatura_ve_Fiş
{
    public partial class rptFaturaBarkodlu : DevExpress.XtraReports.UI.XtraReport
    {
        private string yaziyaCevir(decimal cevir)
        {
            string sTutar = cevir.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                

                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor.
                    grupDegeri = "YÜZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor.
                    grupDegeri = "BİN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "SIFIR Kr.";

            return yazi;
           
        }

       
        public rptFaturaBarkodlu()
        {
            
            InitializeComponent();
            #region Eskiler
            //NetSatisContext context = new NetSatisContext();
            //StokHareketDAL stokHareketDal = new StokHareketDAL();

            //FisDAL fisDal = new FisDAL();

            //Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fisKodu);

            //ObjectDataSource stokHareketDataSource = new ObjectDataSource { DataSource = stokHareketDal.GetAll(context, c => c.FisKodu == fisKodu) };

            //fatura başlık

            /*lblCariAdi.Text = fisBilgi.Cari.FaturaUnvani;
            lblAdres.Text = fisBilgi.Cari.Adres;
            lblTarih.Text = fisBilgi.Tarih.ToString();
            lblVergiDairesi.Text = fisBilgi.Cari.VergiDairesi;
            lblVergiNo.Text = fisBilgi.Cari.VergiNo;

            lblIkametgah.Text =  fisBilgi.Cari.Ilce + "-" + fisBilgi.Cari.Il;*/
            //fatura ürünler            
            /*this.DataSource = stokHareketDataSource;
            colBarkodu.DataBindings.Add("Text", this.DataSource, "Stok.Barkodu");
            colStokKodu.DataBindings.Add("Text", this.DataSource, "Stok.StokKodu");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "Stok.StokAdi");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar","{0:N2}");
            colBirim.DataBindings.Add("Text", this.DataSource, "Stok.Birim");
            colBirimFiyati.DataBindings.Add("Text", this.DataSource, "BirimFiyati","{0:C2}");
            colKdv.DataBindings.Add("Text", this.DataSource, "Kdv");
            colIskonto.DataBindings.Add("Text", this.DataSource, "IndirimOrani");*/
            // KDV siz Fiyat
            // [BirimFiyati] / (ToDecimal([Kdv]) / 100 + 1)
            //hesaplamalar
            /*if (fisBilgi.KDVDahil)
            {
                CalculatedField calcKdvSizBF = new CalculatedField();
                this.CalculatedFields.Add(calcKdvSizBF);
                calcKdvSizBF.Name = "KdvSizBirimFiyati";
                calcKdvSizBF.Expression = "[BirimFiyati] / (ToDecimal([Kdv]) / 100 + 1)";
            }*/



            /*CalculatedField calcIndirimTutari = new CalculatedField();
            this.CalculatedFields.Add(calcIndirimTutari);
            calcIndirimTutari.Name = "IndirimTutari";
            if (fisBilgi.KDVDahil)
            {
                calcIndirimTutari.Expression = "([KdvSizBirimFiyati]*[Miktar])/100*[IndirimOrani]";
            }
            else
            {
                calcIndirimTutari.Expression = "([BirimFiyati]*[Miktar])/100*[IndirimOrani]";
            }*/


            /*CalculatedField calcKdvToplam = new CalculatedField();
            this.CalculatedFields.Add(calcKdvToplam);
            calcKdvToplam.Name = "KdvTutari";
            if (fisBilgi.KDVDahil)
            {
                calcKdvToplam.Expression = "([KdvSizBirimFiyati]*[Miktar]-[IndirimTutari]) / 100* [Kdv]";
            }
            else
            {
                calcKdvToplam.Expression = "([BirimFiyati]*[Miktar]-[IndirimTutari]) / 100* [Kdv]";
            }*/



            /*CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            if (fisBilgi.KDVDahil)
            {
                calcTutar.Expression = "[KdvSizBirimFiyati]*[Miktar]";
            }
            else
            {
                calcTutar.Expression = "[BirimFiyati]*[Miktar]";
            }*/


            /*CalculatedField calcKdvliTutar = new CalculatedField();
            this.CalculatedFields.Add(calcKdvliTutar);
            calcKdvliTutar.Name = "KdvliTutar";
            if (fisBilgi.KDVDahil)
            {
                calcKdvliTutar.Expression = "([KdvSizBirimFiyati]*[Miktar])-[IndirimTutari]+[KdvTutari]";
            }
            else
            {
                calcKdvliTutar.Expression = "([BirimFiyati]*[Miktar])-[IndirimTutari]+[KdvTutari]";
            }*/


            //colToplamTutar.DataBindings.Add("Text", null, "Tutar","{0:C2}");

            /*XRSummary sumAraToplam = new XRSummary();
            sumAraToplam.Func = SummaryFunc.Sum;
            sumAraToplam.Running = SummaryRunning.Page;
            sumAraToplam.FormatString = "{0:C2}";

            XRSummary sumKdvToplam = new XRSummary();
            sumKdvToplam.Func = SummaryFunc.Sum;
            sumKdvToplam.Running = SummaryRunning.Page;
            sumKdvToplam.FormatString = "{0:C2}";

            XRSummary sumGenelToplam = new XRSummary();
            sumGenelToplam.Func = SummaryFunc.Sum;
            sumGenelToplam.Running = SummaryRunning.Page;
            sumGenelToplam.FormatString = "{0:C2}";

            XRSummary sumIndirimToplam = new XRSummary();
            sumIndirimToplam.Func = SummaryFunc.Sum;
            sumIndirimToplam.Running = SummaryRunning.Page;
            sumIndirimToplam.FormatString = "{0:C2}";

            lblAraToplam.DataBindings.Add("Text", null, "Tutar");
            lblKdvToplam.DataBindings.Add("Text", null, "KdvTutari");
            lblGenelToplam.DataBindings.Add("Text", null, "KdvliTutar");
            lblIndirimTutari.DataBindings.Add("Text", null, "IndirimTutari");

            lblAraToplam.Summary = sumAraToplam;
            lblKdvToplam.Summary = sumKdvToplam;
            lblGenelToplam.Summary = sumGenelToplam;
            lblIndirimTutari.Summary = sumIndirimToplam;            
            xrLabel5.Text = yaziyaCevir((decimal)fisBilgi.ToplamTutar);*/
            #endregion


        }

        private void rptFaturaBarkodlu_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
            
        }

        private void rptFaturaBarkodlu_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //    this.DataSource = DS.Tables["Kelime"];
            //    DetailReport.DataSource = DS.Tables["Fatura1"];
            //    DetailReport1.DataSource = DS.Tables["KDVLER"];
        }

        private void PageFooter_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ////PageFooter.PrintOn = PrintOnPages.NotWithReportFooter;
        }
    }
}
