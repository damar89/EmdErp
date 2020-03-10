using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatisAdmin
{
    public partial class frmParolaHatirlat : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context=new NetSatisContext();
        KullaniciDAL kullaniciDal=new KullaniciDAL();
        private Kullanici _entity;

        public frmParolaHatirlat(string kullaniciAdi)
        {
            InitializeComponent();
            _entity = context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == kullaniciAdi);
            txtHatirlatmaSorusu.Text = _entity.HatirlatmaSorusu;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (_entity.Cevap==txtCevap.Text&&txtParola.Text==txtParolaTekrari.Text)
            {
                _entity.Parola = txtParola.Text;
                kullaniciDal.AddOrUpdate(context, _entity);
                context.SaveChanges();
                MessageBox.Show("Parolanız başarılı bir şekilde değiştirildi.");
                this.Close();
                
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}