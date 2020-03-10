using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmKategoriler : Form
    {
        NetSatisContext context = new NetSatisContext();
        KategoriDAL kategoriDal = new KategoriDAL();

        private KategoriTuru _kategoriTuru;
        public Kategori _entity;
        public bool secildi = false;
        public frmKategoriler(KategoriTuru kategoriTuru)
        {
            InitializeComponent();
            _kategoriTuru = kategoriTuru;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridContKategoriler.DataSource = kategoriDal.GetAll(context);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        public enum KategoriTuru
        {

            Kategori


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridKategoriler.GetFocusedRowCellValue(colId));
                kategoriDal.Delete(context, c => c.Id == secilen);
                kategoriDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKategori form = new frmKategori(new Entities.Tables.Kategori());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridKategoriler.GetFocusedRowCellValue(colId));
            frmKategori form = new frmKategori(kategoriDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }



        private void gridKategoriler_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridKategoriler.RowCount != 0)
                {
                    int secilen = Convert.ToInt32(gridKategoriler.GetFocusedRowCellValue(colId));
                    _entity = context.Kategoriler.Where(c => c.Id == secilen).SingleOrDefault();
                    secildi = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Seçim Yapınız.");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
