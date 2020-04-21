using DevExpress.XtraEditors.Mask;
using NetSatis.BackOffice.Stok_Hareketleri;
using NetSatis.Entities.Data_Access;
using System;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmTarihliStokSatis : DevExpress.XtraEditors.XtraForm
    {
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public frmTarihliStokSatis()
        {
            InitializeComponent();
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
                //dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);
            frmStokSatis form = new frmStokSatis(dtBaslangic, dtBitis);
            form.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBaslangic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                 dtpBaslangic.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day , 0,0,0);
            }
        }

        private void dtpBitis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
            if (e.Button.Index == 1)
            {

                dtpBitis.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day , 23,59,59);
            }
        }
    }
}