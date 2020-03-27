using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmProje : Form
    {
        NetSatisContext context=new NetSatisContext();
        ProjeDAL projeDal=new ProjeDAL();

        
        public frmProje()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProje_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridContDepolar.DataSource = projeDal.StokListele(context);

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
                projeDal.Delete(context, c => c.Id == secilen);
                projeDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmProjeIslem form=new frmProjeIslem(new Entities.Tables.Proje());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int  secilen =Convert.ToInt32(gridDepolar.GetFocusedRowCellValue(colId));
            frmProjeIslem form=new frmProjeIslem(projeDal.GetByFilter(context,c=>c.Id==secilen));
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
