using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.Reports.Cari
{
    public partial class rptCariBakiye : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCariBakiye()
        {
            InitializeComponent();
            NetSatisContext context = new NetSatisContext();
            CariDAL cariDal = new CariDAL();
            ObjectDataSource cariBakiyeDataSource = new ObjectDataSource { DataSource = cariDal.GetCariler(context) };
            this.DataSource = cariBakiyeDataSource;

            colCariKodu.DataBindings.Add("Text", this.DataSource, "CariKodu");
            colCariAdi.DataBindings.Add("Text", this.DataSource, "CariAdi");
            colIl.DataBindings.Add("Text", this.DataSource, "Il");
            colIlce.DataBindings.Add("Text", this.DataSource, "Ilce");
            colAlacak.DataBindings.Add("Text", this.DataSource, "Alacak");
            colBorc.DataBindings.Add("Text", this.DataSource, "Borc");
            colDurum.DataBindings.Add("Text", this.DataSource, "BakiyeDurum");
            
            CalculatedField calcBakiye = new CalculatedField();
            this.CalculatedFields.Add(calcBakiye);
            calcBakiye.Name = "Bakiye";
            calcBakiye.Expression = "[Alacak]-[Borc]";

            colBakiye.DataBindings.Add("Text", null, "Bakiye","{0:C2}");            

            XRSummary sumToplamTutar=new XRSummary();
            sumToplamTutar.Func = SummaryFunc.Sum;
            sumToplamTutar.Running = SummaryRunning.Group;
            sumToplamTutar.FormatString = "{0:C2}";

            #region Güncellenen Alan
            CalculatedField calcBorcAlacak = new CalculatedField();
            this.CalculatedFields.Add(calcBorcAlacak);
            calcBorcAlacak.Name = "SonDurum";
            calcBorcAlacak.Expression = "Iif([lblGenelToplam] > 0, 'Alacak Var', 'Borç Var')"; 
            #endregion

            lblGenelToplam.DataBindings.Add("Text", null, "Bakiye");
            lblGenelToplam.Summary = sumToplamTutar;

            lblDurum.DataBindings.Add("Text", null, "SonDurum");

           
        }

    }
}
