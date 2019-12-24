using DevExpress.DataAccess.ObjectBinding;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.Reports.Fatura_ve_Fiş
{
    public partial class rptTahsilat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptTahsilat(string fisKodu)
        {
            InitializeComponent();
            CariDAL cariDal = new CariDAL();
            FisDAL fisDal = new FisDAL();
            NetSatisContext context = new NetSatisContext();
            ObjectDataSource cariBakiyeDataSource = new ObjectDataSource { DataSource = cariDal.GetCariler(context) };


            var fisBilgi = fisDal.Fatura(context, fisKodu);


            //blCariAdı.DataBindings.Add("Text", cariEntity, "CariAdi");
            ////fatura başlık
            //lblCariKodu.DataBindings.Add("Text", fisBilgi, "CariKodu");
            lblCariAdi.DataBindings.Add("Text", fisBilgi, "CariAdi");
            colFisKodu.DataBindings.Add("Text", fisBilgi, "FisKodu");
            colFisTuru.DataBindings.Add("Text", fisBilgi, "FisTuru");
            colAlinan.DataBindings.Add("Text", fisBilgi, "ToplamTutar", "{0:C2}");
            colTarih.DataBindings.Add("Text", fisBilgi, "Tarih", "{0:dd.MM.yyyy}");
            //this.DataSource = cariBakiyeDataSource;
            colBakiye.DataBindings.Add("Text", cariBakiyeDataSource, "Bakiye", "{0:C2}");


        }
    }
}