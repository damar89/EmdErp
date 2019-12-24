using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
namespace NetSatis.BackOffice.Kasa
{
    public partial class frmKasa : Form
    {
        KasaDAL kasaDal = new KasaDAL();
        CariDAL cariDal = new CariDAL();
        NetSatisContext context = new NetSatisContext();
        private int secilen;
        public frmKasa()
        {
            InitializeComponent();
        }
        public void Guncelle()
        {
            gridContKasalar.DataSource = kasaDal.KasaListele(context);
        }
        private void frmKasa_Load(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            Guncelle();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKasaIslem form = new frmKasaIslem(new Entities.Tables.Kasa());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colId));
            frmKasaIslem form = new frmKasaIslem(kasaDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilen = Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colId));
                kasaDal.Delete(context, c => c.Id == secilen);
                kasaDal.Save(context);
                Guncelle();
            }
        }
        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(layoutView1.GetFocusedRowCellValue(colId));
            string secilenAd = layoutView1.GetFocusedRowCellValue(colKasaAdi).ToString();
            frmKasaHareket form = new frmKasaHareket(secilen);
            form.ShowDialog();
        }
        private void frmKasa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
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
