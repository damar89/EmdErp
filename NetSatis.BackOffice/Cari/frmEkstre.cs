using DevExpress.XtraEditors.Mask;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Linq;
using System.Windows.Forms;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmEkstre : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        CariDAL cariDal = new CariDAL();
        private Nullable<int> secilen = null;
        Entities.Tables.Cari seciliCari;
        public frmEkstre()
        {
            InitializeComponent();
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            gridControl1.DataSource = cariDal.GetCariler(context);
        }
        private void btnCariEkstreDokumu_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);
            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
                    frmCariEkstreTarih form = new frmCariEkstreTarih(Convert.ToInt32(secilen), dtBaslangic, dtBitis);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Cari Bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
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
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmEkstre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
        }
        private void dtpBaslangic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = dtpBitis;
            }
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

        private void txtCariAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                txtCariAdi.PerformClick(txtCariAdi.Properties.Buttons[0]);
            }
        }
    }
}