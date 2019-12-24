using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Kasa
{
    public partial class frmKasaIslem : Form

    {
        KasaDAL kasaDal = new KasaDAL();
        NetSatisContext context = new NetSatisContext();
        public bool Kaydedildi = false;
        private Entities.Tables.Kasa _entity;
        public frmKasaIslem(Entities.Tables.Kasa entity)
        {
            InitializeComponent();
            _entity = entity;
            txtKasaKodu.DataBindings.Add("Text", _entity, "KasaKodu");
            txtKasaAdi.DataBindings.Add("Text", _entity, "KasaAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");
        }

        private void frmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kasaDal.AddOrUpdate(context, _entity))
            {
                kasaDal.Save(context);
                Kaydedildi = true;
               
                this.Close();
            }
        }

        private void frmKasaIslem_KeyDown(object sender, KeyEventArgs e)
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
