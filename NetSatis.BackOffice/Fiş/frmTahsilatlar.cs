using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmTahsilatlar : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal=new KasaHareketDAL();
        


        public frmTahsilatlar()
        {
            InitializeComponent();
        }

        private void frmTahsilatlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            context=new NetSatisContext();
            gridContFisler.DataSource = fisDal.Listelemeler(context,"Tahsilat Fişi");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
          Listele();
        }

      

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (gridFisler.RowCount != 0)
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                    fisDal.Delete(context, c => c.FisKodu == secilen);
                    kasaHareketDal.Delete(context, c => c.FisKodu == secilen);
                    fisDal.Save(context);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }

    
      
        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form=new frmFisIslem(null,e.Item.Caption);
            form.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (gridFisler.RowCount != 0)
            {
                string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
                frmFisIslem form = new frmFisIslem(secilen, fisturu);
                form.Show();
            }
            else
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }

        private void gridFisler_DoubleClick(object sender, EventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
            frmFisIslem form = new frmFisIslem(secilen, fisturu);
            form.Show();
        }
    }
}
