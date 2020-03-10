using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Depo
{

    public partial class frmDepoIslem : Form
    {
        private Entities.Tables.Depo _entity;
        private DepoDAL depoDal=new DepoDAL();
        private NetSatisContext context=new NetSatisContext();
        public bool Kaydedildi = false;
        public frmDepoIslem(Entities.Tables.Depo entity)

        {
            InitializeComponent();
            _entity = entity;
            txtDepoKodu.DataBindings.Add("Text", _entity, "DepoKodu");
            txtDepoAdi.DataBindings.Add("Text", _entity, "DepoAdi");
            txtYetkiliKodu.DataBindings.Add("Text", _entity, "YetkiliKodu");
            txtYetkiliAdi.DataBindings.Add("Text", _entity, "YetkiliAdi");
            txtTelefon.DataBindings.Add("Text", _entity, "Telefon");
            txtIl.DataBindings.Add("Text", _entity, "Il");
            txtIlce.DataBindings.Add("Text", _entity, "Ilce");
            txtSemt.DataBindings.Add("Text", _entity, "Semt");
            txtAdres.DataBindings.Add("Text", _entity, "Adres");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }
      

        private void frmDepoIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (depoDal.AddOrUpdate(context, _entity))
            {
                depoDal.Save(context);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepoIslem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                btnKapat.PerformClick();
            }
        }
    }
}
