using System;
using System.Windows.Forms;
namespace NetSatis.FrontOffice
{
    public partial class frmMaliyet : DevExpress.XtraEditors.XtraForm
    {
        public frmMaliyet()
        {
            InitializeComponent();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmMaliyet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmMaliyet_Load(object sender, EventArgs e)
        {
            lblMaliyet.Text = frmFrontOffice.GidenBilgi.ToString();
        }
    }
}