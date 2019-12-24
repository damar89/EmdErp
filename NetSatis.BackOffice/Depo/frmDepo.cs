using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Depo
{
    public partial class frmDepo : Form
    {
        NetSatisContext context=new NetSatisContext();
        DepoDAL depoDal=new DepoDAL();

        
        public frmDepo()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepo_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            gridContDepolar.DataSource = depoDal.GetAll(context);

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
                depoDal.Delete(context, c => c.Id == secilen);
                depoDal.Save(context);
                Listele();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmDepoIslem form=new frmDepoIslem(new Entities.Tables.Depo());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int  secilen =Convert.ToInt32(gridDepolar.GetFocusedRowCellValue(colId));
            frmDepoIslem form=new frmDepoIslem(depoDal.GetByFilter(context,c=>c.Id==secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void btnKasaHareket_Click(object sender, EventArgs e)
        {
          int  secilen =Convert.ToInt32(gridDepolar.GetFocusedRowCellValue(colId));
            string secilenAd = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
            frmDepoHareket form = new frmDepoHareket(secilen);
            form.ShowDialog();
        }
    }
}
