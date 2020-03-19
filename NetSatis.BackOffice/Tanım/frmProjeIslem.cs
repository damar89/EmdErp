using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{

    public partial class frmProjeIslem : Form
    {
        private Entities.Tables.Proje _entity;
        private ProjeDAL projeDal=new ProjeDAL();
        private NetSatisContext context=new NetSatisContext();
        public bool Kaydedildi = false;
        public frmProjeIslem(Entities.Tables.Proje entity)

        {
            InitializeComponent();
            _entity = entity;
            txtProjeKodu.DataBindings.Add("Text", _entity, "Kod");
            txtDepoAdi.DataBindings.Add("Text", _entity, "ProjeAdi");
         

        }
      

        private void frmProjeIslem_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (projeDal.AddOrUpdate(context, _entity))
            {
                projeDal.Save(context);
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProjeIslem_KeyDown(object sender, KeyEventArgs e)
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
