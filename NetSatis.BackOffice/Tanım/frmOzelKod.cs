using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmOzelKod : Form
    {
        NetSatisContext context=new NetSatisContext();
        OzelKodDAL ozelkodDal=new OzelKodDAL();

        
        public frmOzelKod()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOzelKod_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridContDepolar.DataSource = ozelkodDal.StokListele(context);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

     

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                int  secilen =Convert.ToInt32(gridDepolar.GetFocusedRowCellValue(colId));
                ozelkodDal.Delete(context, c => c.Id == secilen);
                ozelkodDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmOzelKodIslem form=new frmOzelKodIslem(new Entities.Tables.OzelKod());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int  secilen =Convert.ToInt32(gridDepolar.GetFocusedRowCellValue(colId));
            frmOzelKodIslem form=new frmOzelKodIslem(ozelkodDal.GetByFilter(context,c=>c.Id==secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
         
        }
    }
}
