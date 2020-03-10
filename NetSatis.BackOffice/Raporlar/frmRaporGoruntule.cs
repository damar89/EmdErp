using DevExpress.XtraReports.UI;
using System;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmRaporGoruntule : DevExpress.XtraEditors.XtraForm
    {
        public frmRaporGoruntule(XtraReport rapor)
        {
            InitializeComponent();
            documentViewer1.DocumentSource = rapor;
        }

        private void frmRaporGoruntule_Load(object sender, EventArgs e)
        {

        }
    }
}
