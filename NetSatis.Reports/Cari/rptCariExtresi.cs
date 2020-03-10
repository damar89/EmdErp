using DevExpress.DataAccess.ObjectBinding;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;

namespace NetSatis.Reports.Cari
{
    public partial class rptCariExtresi : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCariExtresi(int CariID, DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            CariDAL cariDal = new CariDAL();
            var cariEntity = cariDal.GetByFilter(context, c => c.Id == CariID);
            ObjectDataSource cariEkstreDataSource = new ObjectDataSource { DataSource = cariDal.CariFisAyrinti(context, CariID, baslangic, bitis) };
            List<GenelToplam> cariBakiyeDataSource = (List<GenelToplam>) cariDal.CariGenelToplam(context, CariID);
            this.DataSource = cariEkstreDataSource;
            lblCariKodu.DataBindings.Add("Text", cariEntity, "CariKodu");
            lblCariAdı.DataBindings.Add("Text", cariEntity, "CariAdi");
            
            colFisKodu.DataBindings.Add("Text", this.DataSource, "FisKodu");
            colFisTuru.DataBindings.Add("Text", this.DataSource, "FisTuru");
            colBelgeNo.DataBindings.Add("Text", this.DataSource, "BelgeNo");            
            colTarih.DataBindings.Add("Text", this.DataSource, "Tarih", "{0:dd.MM.yyyy}");
            colVadeTarihi.DataBindings.Add("Text", this.DataSource, "VadeTarihi", "{0:dd.MM.yyyy}");
            colToplamTutar.DataBindings.Add("Text", this.DataSource, "ToplamTutar", "{0:C2}");
            colOdenen.DataBindings.Add("Text", this.DataSource, "Odenen", "{0:C2}");            
            colAktif.DataBindings.Add("Text", this.DataSource, "AktifTutar", "{0:C2}");

            lblBaslangic.Text = baslangic.ToShortDateString();
            lblBitis.Text = bitis.ToShortDateString();

            colAlacak.DataBindings.Add("Text", cariBakiyeDataSource[0], "Bilgi");
            colAlacakTutar.DataBindings.Add("Text", cariBakiyeDataSource[0], "Tutar", "{0:C2}");
            colBorc.DataBindings.Add("Text", cariBakiyeDataSource[1], "Bilgi");
            colBorcTutar.DataBindings.Add("Text", cariBakiyeDataSource[1], "Tutar", "{0:C2}");
            colBakiye.DataBindings.Add("Text", cariBakiyeDataSource[2], "Bilgi");
            colBakiyeTutar.DataBindings.Add("Text", cariBakiyeDataSource[2], "Tutar", "{0:C2}");
            
            

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
