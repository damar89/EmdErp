using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Utils.Raporlama;
using System.IO;

namespace NetSatis.Utils
{
    public partial class FrmDashboard : XtraForm
    {
        string DizaynIsmi = string.Empty;
        DizaynTipi dizaynTipi; 
        RaporTasarimlari _raporTasarimlari = new RaporTasarimlari();

        RaporlamaDAL raporDal=new RaporlamaDAL();
        NetSatisContext context=new NetSatisContext();
        public FrmDashboard(object datasource, DizaynTipi _dizaynTipi, bool Yazdir = true, int DesingID = 0)
        {
            InitializeComponent();
            dizaynTipi = _dizaynTipi;
#pragma warning disable CS0618 // 'Dashboard.AddDataSource(string, object)' is obsolete: 'The Dashboard.AddDataSource method is obsolete now. Use the Dashboard.DataSources.Add method instead.'
            dashboardDesigner1.Dashboard.AddDataSource(dizaynTipi.ToString(), datasource);
#pragma warning restore CS0618 // 'Dashboard.AddDataSource(string, object)' is obsolete: 'The Dashboard.AddDataSource method is obsolete now. Use the Dashboard.DataSources.Add method instead.'

            if (Yazdir)
            {
                raporTasarimlari = raporDal.GetByFilter(context,x => x.Id == DesingID);

            }
        }
        public RaporTasarimlari raporTasarimlari
        {
            get
            {
                MemoryStream memoryStream = new MemoryStream();
                dashboardDesigner1.SaveDashboardLayout(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);
                var str = memoryStream.ToArray();
                memoryStream.Close();
                _raporTasarimlari.Dizayn = str;
                _raporTasarimlari.DizaynIsmi = DizaynIsmi;
                _raporTasarimlari.DizaynTipi = dizaynTipi.ToString();
                return _raporTasarimlari;
            }
            set
            {
                _raporTasarimlari = value;
                DizaynIsmi = _raporTasarimlari.DizaynIsmi;

                MemoryStream memoryStream = new MemoryStream(_raporTasarimlari.Dizayn);
                memoryStream.Seek(0, SeekOrigin.Begin);
                dashboardDesigner1.LoadDashboardLayout(memoryStream);
                memoryStream.Close();

            }
        }
    }
}
