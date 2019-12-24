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
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmTarihliRapor : DevExpress.XtraEditors.XtraForm
    {
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public frmTarihliRapor()
        {
            InitializeComponent();
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            frmGenelSatisRapor form = new frmGenelSatisRapor(dtBaslangic,dtBitis);
            form.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}