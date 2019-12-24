using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Mapping;
using NetSatis.Entities.Tables;

namespace NetSatisAdmin
{
    public partial class frmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KullaniciDAL kullaniciDal = new KullaniciDAL();
        private string secilen;
       
        public frmKullanicilar()
        {
            InitializeComponent();
            Guncelle();
        }

        private void Guncelle()
        {
            gridControl1.DataSource = kullaniciDal.GetAll(context);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciIslem form = new frmKullaniciIslem(new Kullanici());
            form.ShowDialog();
        }

        private void frmKullanicilar_Load(object sender, EventArgs e)
        {
            frmKullaniciGiris form=new frmKullaniciGiris();
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colKullaniciAdi).ToString();
            frmKullaniciIslem form = new frmKullaniciIslem(kullaniciDal.GetByFilter(context, c => c.KullaniciAdi == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                Guncelle();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmOflineLisans frm=new frmOflineLisans();
            frm.Show();
        }
    }
}
