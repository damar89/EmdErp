using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

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
