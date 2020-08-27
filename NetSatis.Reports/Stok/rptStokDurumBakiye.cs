using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.Reports.Stok
{
    public partial class rptStokDurumBakiye : DevExpress.XtraReports.UI.XtraReport
    {
        public rptStokDurumBakiye()
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            StokDAL stokDal = new StokDAL();
            ObjectDataSource stokDataSource = new ObjectDataSource { DataSource = stokDal.StokListele(context, false) };
            this.DataSource = stokDataSource;

            colStokKodu.DataBindings.Add("Text", this.DataSource, "StokKodu");
            colStokAdi.DataBindings.Add("Text", this.DataSource, "StokAdi");
            colBirim.DataBindings.Add("Text", this.DataSource, "Birim");

            if (((NetSatis.Entities.Tables.Stok)stokDataSource.DataSource).AlisFiyati3 != null && ((NetSatis.Entities.Tables.Stok)stokDataSource.DataSource).AlisFiyati3 != 0)
                colAlisFiyati.DataBindings.Add("Text", this.DataSource, "AlisFiyati3");
            else if (((NetSatis.Entities.Tables.Stok)stokDataSource.DataSource).AlisFiyati2 != null && ((NetSatis.Entities.Tables.Stok)stokDataSource.DataSource).AlisFiyati2 != 0)
                colAlisFiyati.DataBindings.Add("Text", this.DataSource, "AlisFiyati2");
            else if (((NetSatis.Entities.Tables.Stok)stokDataSource.DataSource).AlisFiyati1 != null && ((NetSatis.Entities.Tables.Stok)stokDataSource.DataSource).AlisFiyati1 != 0)
                colAlisFiyati.DataBindings.Add("Text", this.DataSource, "AlisFiyati1");

            //colAlisFiyati.DataBindings.Add("Text", this.DataSource, "AlisFiyati3"?? "AlisFiyati2"?? "AlisFiyati1");

            colSatisFiyat.DataBindings.Add("Text", this.DataSource, "SatisFiyati1");
            colMevcutStok.DataBindings.Add("Text", this.DataSource, "MevcutStok");

            CalculatedField calcTutar = new CalculatedField();
            this.CalculatedFields.Add(calcTutar);
            calcTutar.Name = "Tutar";
            calcTutar.Expression = "[MevcutStok]*[AlisFiyati1]";

            colBakiye.DataBindings.Add("Text", null, "Tutar", "{0:C2}");

            CalculatedField calcTutar2 = new CalculatedField();
            this.CalculatedFields.Add(calcTutar2);
            calcTutar2.Name = "Tutar2";
            calcTutar2.Expression = "[MevcutStok]*[SatisFiyati1]";

            colBakiye2.DataBindings.Add("Text", null, "Tutar2", "{0:C2}");

            XRSummary sumStokToplam = new XRSummary();
            sumStokToplam.Func = SummaryFunc.Sum;
            sumStokToplam.Running = SummaryRunning.Group;
            sumStokToplam.FormatString = "{0:C2}";

            XRSummary sumStokToplam2 = new XRSummary();
            sumStokToplam2.Func = SummaryFunc.Sum;
            sumStokToplam2.Running = SummaryRunning.Group;
            sumStokToplam2.FormatString = "{0:C2}";

            lblToplamBakiye.DataBindings.Add("Text", null, "Tutar");
            lblToplamBakiye.Summary = sumStokToplam;

            lblToplamBakiye2.DataBindings.Add("Text", null, "Tutar2");
            lblToplamBakiye2.Summary = sumStokToplam2;
        }

    }
}
