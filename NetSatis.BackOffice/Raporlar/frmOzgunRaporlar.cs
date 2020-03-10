using DevExpress.DashboardCommon;
using System;
using System.Collections.Generic;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmOzgunRaporlar : DevExpress.XtraEditors.XtraForm
    {
        public frmOzgunRaporlar(List<object> veriListesi = null)
        {
            InitializeComponent();
            if (veriListesi != null)
            {
                foreach (var veri in veriListesi)
                {
                    DashboardObjectDataSource dataSource=new DashboardObjectDataSource();
                    dataSource.DataSource = veri;
                    dataSource.Fill();
                    dashboardDesigner1.Dashboard.DataSources.Add(dataSource);


                }

            }
        }

        private void frmOzgunRaporlar_Load(object sender, EventArgs e)
        {

        }
    }
}