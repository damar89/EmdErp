using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmKategori : Form

    {
        KategoriDAL kategoriDal = new KategoriDAL();
        NetSatisContext context = new NetSatisContext();
        public bool Kaydedildi = false;
        private Entities.Tables.Kategori _entity;
        bool guncelle = false;
        public frmKategori(Entities.Tables.Kategori entity)
        {
            InitializeComponent();
            _entity = entity;
            if (entity.Id != 0)
            {
                guncelle = true;
            }
            if (guncelle == true)
            {
                _entity.GuncellemeTarihi = Convert.ToDateTime(DateTime.Now);
            }
            else
            {
                _entity.KayitTarihi = Convert.ToDateTime(DateTime.Now);
            }

            txtKategoriKodu.DataBindings.Add("Text", _entity, "Kod");
            txtKategoriAdi.DataBindings.Add("Text", _entity, "KategoriAdi");

        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kategoriDal.AddOrUpdate(context, _entity))
            {
                kategoriDal.Save(context);
                Kaydedildi = true;

                this.Close();
            }
        }

        private void frmKategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                this.Close();
            }
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
        }
    }
}
