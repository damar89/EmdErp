using DevExpress.XtraEditors.Mask;
using NetSatis.BackOffice.Extensions;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Linq;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmStokAnaliz : DevExpress.XtraEditors.XtraForm
    {
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        NetSatisContext context = new NetSatisContext();
        int stokid = 0;
        public frmStokAnaliz()
        {
            InitializeComponent();
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }

        private void dtpBaslangic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                dtpBaslangic.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            }
        }

        private void dtpBitis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (e.Button.Index == 1)
            {

                dtpBitis.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (stokid != 0)
            {
                gridContStokHareket.DataSource = stokHareketDal.GetAll2(context, c => c.StokId == stokid);

            }

        }

        private void btnStokGetir_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec(ref this.context, txtStokAdi.EditValue.GetString(), false);
            form.ShowDialog();
            if (form.secildi)
            {
                //Buradan
                var enti = form.secilen.First();
                stokid = enti.Id;
                txtStokAdi.EditValue = enti.StokAdi;
                txtKod.EditValue = enti.StokKodu;

            }
        }
    }
}