using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmAltGrup : Form

    {
        AltGrupDAL altgrupDal = new AltGrupDAL();
        NetSatisContext context = new NetSatisContext();
        public bool Kaydedildi = false;
        private Entities.Tables.AltGrup _entity;
        bool guncelle = false;
        public frmAltGrup(Entities.Tables.AltGrup entity)
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

            txtAltGrupKodu.DataBindings.Add("Text", _entity, "Kod");
            txtAltGrupAdi.DataBindings.Add("Text", _entity, "AltGrupAdi");

        }

        private void frmAltGrup_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (altgrupDal.AddOrUpdate(context, _entity))
            {
                altgrupDal.Save(context);
                Kaydedildi = true;

                this.Close();
            }
        }

        private void frmAltGrup_KeyDown(object sender, KeyEventArgs e)
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
