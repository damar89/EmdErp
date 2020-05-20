using DevExpress.DataAccess.ObjectBinding;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.IO;
using System.Linq;

namespace NetSatis.Reports.Fatura_ve_Fiş
{
    public partial class rptTahsilat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTahsilat()
        {
            InitializeComponent();
           /* CariDAL cariDal = new CariDAL();
            KasaHareketDAL kasahareket = new KasaHareketDAL();
            FisDAL fisDal = new FisDAL();
            NetSatisContext context = new NetSatisContext();
            ObjectDataSource cariBakiyeDataSource = new ObjectDataSource { DataSource = cariDal.GetCariler(context) };
            Fis fisBilgi = fisDal.GetByFilter(context, c => c.FisKodu == fisKodu);
            var bakiye = cariDal.cariBakiyesi(context, Convert.ToInt32(fisBilgi.CariId))?.Bakiye;
         
            //blCariAdı.DataBindings.Add("Text", cariEntity, "CariAdi");a
            ////fatura başlık
            //lblCariKodu.DataBindings.Add("Text", fisBilgi, "CariKodu");
            lblCariAdi.DataBindings.Add("Text", fisBilgi, "CariAdi");
            colFisKodu.DataBindings.Add("Text", fisBilgi, "FisKodu");
            colFisTuru.DataBindings.Add("Text", fisBilgi, "FisTuru");
            colAlinan.DataBindings.Add("Text", fisBilgi, "ToplamTutar", "{0:C2}");
            colTarih.DataBindings.Add("Text", fisBilgi, "Tarih", "{0:dd.MM.yyyy}");
            //this.DataSource = cariBakiyeDataSource;
            colBakiye.Text = bakiye.Value.ToString("c2");
            //colBakiye.DataBindings.Add("Text", bakiye, "Bakiye", "{0:C2}");*/


        }
    }
}