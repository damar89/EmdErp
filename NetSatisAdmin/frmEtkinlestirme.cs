using System;

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