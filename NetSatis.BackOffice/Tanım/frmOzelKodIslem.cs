using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{

    public partial class frmOzelKodIslem : Form
    {
        private Entities.Tables.OzelKod _entity;
        private OzelKodDAL ozelkodDal=new OzelKodDAL();
        private NetSatisContext context=new NetSatisContext();
        public bool Kaydedildi = false;
        public frmOzelKodIslem(Entities.Tables.OzelKod entity)

        {
            InitializeComponent();
            _entity = entity;
            txtOzelKodu.DataBindings.Add("Text", _entity, "Kod");
            txtAdi.DataBindings.Add("Text", _entity, "OzelKodAdi");
         

        }
      

        private void frmOzelKodIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (ozelkodDal.AddOrUpdate(context, _entity))
            {
                ozelkodDal.Save(context);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOzelKodIslem_KeyDown(object sender, KeyEventArgs e)
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
