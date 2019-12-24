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

namespace NetSatisAdmin
{
    public partial class frmEtkinlestirme : DevExpress.XtraEditors.XtraForm
    {
        public frmEtkinlestirme()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            using (frmGenerate frm=new frmGenerate())
            {
                frm.ShowDialog();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            using (frmRegistration frm=new frmRegistration())
            {
                frm.ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (frmLisansBilgileri frm=new frmLisansBilgileri())
            {
                frm.ShowDialog();
            }
        }
    }
}