using DevExpress.XtraReports.UserDesigner;
using System;
using System.ComponentModel.Design;

namespace NetSatis.Reports.Dizayn
{
    public partial class frmFaturaDizayn : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaDizayn()
        {
            InitializeComponent();
        }

        private void frmFaturaDizayn_Activated(object sender, EventArgs e)
        {

        }

        private void reportDesigner1_AnyDocumentActivated(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            XRDesignPanel panel = this.reportDesigner1.ActiveDesignPanel;
            IDesignerHost host = panel.GetService(typeof(IDesignerHost)) as IDesignerHost;
            if (e.Document.Caption.Equals("rptStokEnvanter"))
            {
                host.Container.Add(new StokEnvanterData());
            }
            if (e.Document.Caption.Equals("rptFaturaBarkodlu") || e.Document.Caption.Equals("rptSiparis") || e.Document.Caption.Equals("rptIrsaliye") || e.Document.Caption.Equals("rptTeklif") || e.Document.Caption.Equals("rptProformaFatura") || e.Document.Caption.Equals("rptBilgi"))
            {
                host.Container.Add(new DataSEtler());
            }


        }
    }
}