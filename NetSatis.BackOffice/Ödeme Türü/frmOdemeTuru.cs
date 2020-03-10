using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Ödeme_Türü
{
    public partial class frmOdemeTuru : Form
    {
        NetSatisContext context = new NetSatisContext();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();
        private int secilen;

        public frmOdemeTuru()
        {
            InitializeComponent();
        }

        private void frmOdemeTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            gridContOdemeTuru.DataSource = odemeTuruDal.OdemeTuruListele(context);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colId));
                odemeTuruDal.Delete(context, c => c.Id == secilen);
                odemeTuruDal.Save(context);
                Listele();

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOdemeTuruIslem form = new frmOdemeTuruIslem(new OdemeTuru());
            form.ShowDialog();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colId));
            frmOdemeTuruIslem form = new frmOdemeTuruIslem(odemeTuruDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridOdemeTuru.GetFocusedRowCellValue(colId));
            frmOdemeTuruHareket form = new frmOdemeTuruHareket(secilen);
            form.ShowDialog();
        }

        private void frmOdemeTuru_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
                   if (e.Alt == true && e.KeyCode == Keys.Y)
            {
                btnEkle.PerformClick();
            }
            
            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                btnDuzenle.PerformClick();
            }
            
            if ( e.KeyCode == Keys.F5)
            {
                btnGuncelle.PerformClick();
            }
            
            if (e.Alt == true && e.KeyCode == Keys.S)
            {
                btnSil.PerformClick();
            }
             if (e.Alt == true && e.KeyCode == Keys.H)
            {
                btnSil.PerformClick();
            }
        }
    }
}
