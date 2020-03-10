using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Ödeme_Türü
{
    public partial class frmOdemeTuruIslem : Form
    {
        NetSatisContext context=new NetSatisContext();
        OdemeTuruDAL odemeTuruDal=new OdemeTuruDAL();private OdemeTuru _entity;

        public frmOdemeTuruIslem(OdemeTuru entity)
        {
            InitializeComponent();
            _entity = entity;
            txtOdemeTuruKodu.DataBindings.Add("Text", _entity, "OdemeTuruKodu");
            txtOdemeTuruAdi.DataBindings.Add("Text", _entity, "OdemeTuruAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama");

        }

        private void frmOdemeTuruIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (odemeTuruDal.AddOrUpdate(context, _entity))
            {
                odemeTuruDal.Save(context);
                this.Close();
            }
        }

        private void frmOdemeTuruIslem_KeyDown(object sender, KeyEventArgs e)
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
        }
    }
}
