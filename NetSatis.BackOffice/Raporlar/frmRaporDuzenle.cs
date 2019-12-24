using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

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