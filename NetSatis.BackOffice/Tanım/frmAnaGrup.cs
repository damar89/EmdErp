using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmAnaGrup : Form

    {
        AnaGrupDAL anagrupDal = new AnaGrupDAL();
        NetSatisContext context = new NetSatisContext();
        public bool Kaydedildi = false;
        private Entities.Tables.AnaGrup _entity;
        bool guncelle = false;
        public frmAnaGrup(Entities.Tables.AnaGrup entity)
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

            txtAnaGrupKodu.DataBindings.Add("Text", _entity, "Kod");
            txtAnaGrupAdi.DataBindings.Add("Text", _entity, "AnaGrupAdi");

        }

        private void frmAnaGrup_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (anagrupDal.AddOrUpdate(context, _entity))
            {
                anagrupDal.Save(context);
                Kaydedildi = true;

                this.Close();
            }
        }

        private void frmAnaGrup_KeyDown(object sender, KeyEventArgs e)
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
