using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;

namespace NetSatis.Reports.Cari
{
    public partial class rptCariExtresiStok : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCariExtresiStok(int CariID, DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            CariDAL cariDal = new CariDAL();
     
            var cariEntity = cariDal.GetByFilter(context, c => c.Id == CariID);

            ObjectDataSource cariEkstreDataSource = new ObjectDataSource { DataSource = cariDal.CariFisAyrintiStok(context, CariID,baslangic,bitis) };

            List<GenelToplam> cariBakiyeDataSource = (List<GenelToplam>)cariDal.CariGenelToplam(context, CariID, baslangic, bitis);
            List<GenelToplam> cariBakiyeDataSourceDev = (List<GenelToplam>)cariDal.CariGenelToplam(context, CariID);
             List<GenelToplam> cariBakiyeDurum = (List<GenelToplam>)cariDal.CariGenelToplam(context, CariID);

            cariBakiyeDataSourceDev[0].Tutar = cariBakiyeDataSourceDev[0].Tutar - cariBakiyeDataSource[0].Tutar;
            cariBakiyeDataSourceDev[1].Tutar = cariBakiyeDataSourceDev[1].Tutar - cariBakiyeDataSource[1].Tutar;

            cariBakiyeDataSourceDev[2].Tutar = cariBakiyeDataSourceDev[0].Tutar - cariBakiyeDataSourceDev[1].Tutar;
            cariBakiyeDurum[2].Tutar=cariBakiyeDataSource[2].Tutar+cariBakiyeDataSourceDev[2].Tutar;


           this.DataSource = cariEkstreDataSource;



            lblCariKodu.DataBindings.Add("Text", cariEntity, "CariKodu");
            lblCariAdı.DataBindings.Add("Text", cariEntity, "CariAdi");
            Adres.DataBindings.Add("Text", cariEntity, "Adres");
            lblIl.DataBindings.Add("Text", cariEntity, "Il");
            lblIlce.DataBindings.Add("Text", cariEntity, "Ilce");


            //colFisKodu.DataBindings.Add("Text", this.DataSource, "FisKodu");
            colFisTuru.DataBindings.Add("Text", this.DataSource, "IslemTuru");
            colBirim.DataBindings.Add("Text", this.DataSource, "Birim");
            colUrunAdi.DataBindings.Add("Text", this.DataSource, "UrunAdi");
            colAciklama.DataBindings.Add("Text", this.DataSource, "Aciklama");
            //colBelgeNo.DataBindings.Add("Text", this.DataSource, "BelgeNo");            
            colTarih.DataBindings.Add("Text", this.DataSource, "IslemTarihi", "{0:dd.MM.yyyy}");
            //colVadeTarihi.DataBindings.Add("Text", this.DataSource, "VadeTarihi", "{0:dd.MM.yyyy}");
            coltutar.DataBindings.Add("Text", this.DataSource, "SatirTutari", "{0:C2}");
            colFistutari.DataBindings.Add("Text", this.DataSource, "FisTutari", "{0:C2}");
            colBirimFiyat.DataBindings.Add("Text", this.DataSource, "BirimFiyat", "{0:C2}");
            colMiktar.DataBindings.Add("Text", this.DataSource, "Miktar", "{0:N2}");
            colBorsa.DataBindings.Add("Text", this.DataSource, "BorsaToplam", "{0:C2}");
            colZirai.DataBindings.Add("Text", this.DataSource, "ZiraiToplam", "{0:C2}");
            colBagkur.DataBindings.Add("Text", this.DataSource, "BagkurToplam", "{0:C2}");

            lblBaslangic.Text = baslangic.ToShortDateString();
            lblBitis.Text = bitis.ToShortDateString();

            CalculatedField calcBorcAlacak = new CalculatedField();
            this.CalculatedFields.Add(calcBorcAlacak);
            calcBorcAlacak.Name = "SonDurum";
            calcBorcAlacak.Expression = "Iif([colSonDurum] > 0, '(Alacaklı)', '(Borçlu)')"; 

            colDevAlacakTutar.DataBindings.Add("Text", cariBakiyeDataSourceDev[0], "Tutar", "{0:C2}");
            colAlacakTutar.DataBindings.Add("Text", cariBakiyeDataSource[0], "Tutar", "{0:C2}");

            colDevBorcTutar.DataBindings.Add("Text", cariBakiyeDataSourceDev[1], "Tutar", "{0:C2}");
            colBorcTutar.DataBindings.Add("Text", cariBakiyeDataSource[1], "Tutar", "{0:C2}");

            colDevBakiye.DataBindings.Add("Text", cariBakiyeDataSourceDev[2], "Tutar", "{0:C2}");
            colBakiyeTutar.DataBindings.Add("Text", cariBakiyeDataSource[2], "Tutar", "{0:C2}");
            colSonDurum.DataBindings.Add("Text", cariBakiyeDurum[2], "Tutar", "{0:C2}");

             lblDurum.DataBindings.Add("Text", null, "SonDurum");
        }

        private void xrTable3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrLabel1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTable4_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

        private void xrTable5_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }
    }
}
