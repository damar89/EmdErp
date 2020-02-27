using System;
using System.Linq;
using DevExpress.XtraEditors.Mask;
using NetSatis.Entities;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariStokHareket : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        Entities.Tables.Cari seciliCari;
        public frmCariStokHareket()
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
            //var stokHareketleri = context.StokHareketleri.Where(x => x.Stok == seciliCari.Id);
            if (seciliCari == null)
            {
                System.Windows.Forms.MessageBox.Show("Lütfen Cari Seçiniz!", "Cari seçiniz", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                txtKod.PerformClick(txtKod.Properties.Buttons[0]);
                return;
            }
            var predStk = PredicateBuilder.True<Entities.Tables.StokHareket>();
            var predFis = PredicateBuilder.True<Entities.Tables.Fis>();
            if (seciliCari != null && seciliCari.Id != 0)
                predFis = predFis.And(x => x.CariId == seciliCari.Id);
            if (!string.IsNullOrEmpty(dtpBaslangic.Text) && !string.IsNullOrEmpty(dtpBitis.Text))
                predStk = predStk.And(x => x.Tarih >= dtpBaslangic.DateTime && x.Tarih <= dtpBitis.DateTime);
            else if (!string.IsNullOrEmpty(dtpBaslangic.Text))
                predStk = predStk.And(x => x.Tarih >= dtpBaslangic.DateTime);
            else if (!string.IsNullOrEmpty(dtpBitis.Text))
                predStk = predStk.And(x => x.Tarih <= dtpBitis.DateTime);

            var res = (from sh in context.StokHareketleri.Where(predStk)
                       join f in context.Fisler.Where(predFis) on sh.FisKodu equals f.FisKodu
                       join c in context.Cariler on f.CariId equals c.Id
                       select new
                       {
                           f.FisTuru,
                           sh.Hareket,
                           sh.Depo.DepoAdi,
                           sh.Tarih,
                           c.CariAdi,
                           sh.Stok.Birim,
                           sh.Miktar,
                           sh.BirimFiyati,
                           sh.Kdv,
                           sh.IndirimOrani,
                           sh.IndirimTutar,
                           sh.DipIskontoPayi,
                           sh.ToplamTutar
                       }).ToList();

            gridContStokHareket.DataSource = res;
            gridStokHareket.RefreshData();

        }

        private void txtKod_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            frmCariSec form = new frmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                if (form.secilen.Count == 0)
                    return;
                seciliCari = form.secilen.FirstOrDefault();
                Yerlestir();
            }
        }

        void Yerlestir()
        {

            if (seciliCari == null)
            {
                txtCariAdi.Text =
                txtKod.Text = null;
                return;
            }
            txtCariAdi.Text = seciliCari.CariAdi;
            txtKod.Text = seciliCari.CariKodu;
        }
        private void txtCariAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCariAdi.Text))
                return;

            var res = context.Cariler.FirstOrDefault(x => x.CariAdi.StartsWith(txtCariAdi.Text) || x.CariKodu.StartsWith(txtCariAdi.Text));
            if (res != null)
            {
                seciliCari = res;
                Yerlestir();
            }
        }

        private void txtCariAdi_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                txtCariAdi.PerformClick(txtCariAdi.Properties.Buttons[0]);
            }
        }

        private void frmCariStokHareket_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode==System.Windows.Forms.Keys.F3)
            {
                btnGoster.PerformClick();
            }
        }
    }
}