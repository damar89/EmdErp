using System;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmTarihliMasraf : DevExpress.XtraEditors.XtraForm
    {
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public frmTarihliMasraf()
        {
            InitializeComponent();
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
                dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);
            frmMasrafListesi form = new frmMasrafListesi(dtBaslangic, dtBitis);
            form.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}