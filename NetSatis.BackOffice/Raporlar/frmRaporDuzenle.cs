using DevExpress.XtraReports.UI;
using System;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmRaporDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporDuzenle(XtraReport rapor=null)
        {
            InitializeComponent();
            if(rapor!=null)
            {
                reportDesigner1.OpenReport(rapor);
            }
         
        }

        private void frmRaporDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}