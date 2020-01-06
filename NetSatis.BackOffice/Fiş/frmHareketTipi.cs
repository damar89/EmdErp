using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmHareketTipi : DevExpress.XtraEditors.XtraForm
    {
        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();

        public frmHareketTipi()
        {
            InitializeComponent();
            gridControl1.DataSource=eislem.HareketTipiListele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmHareketTipiIslem frm = new frmHareketTipiIslem();
            frm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource=eislem.HareketTipiListele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
           string kod = gridView1.GetFocusedRowCellValue("Kodu").ToString();
           string aciklama = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
           frmHareketTipiIslem frm = new frmHareketTipiIslem(id,kod,aciklama);
            frm.Show();
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("Id"));
            eislem.HareketTipiSil(id);
        }
    }
}