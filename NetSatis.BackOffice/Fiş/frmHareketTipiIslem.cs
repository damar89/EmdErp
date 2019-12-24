using System;


namespace NetSatis.BackOffice.Fiş
{
    public partial class frmHareketTipiIslem : DevExpress.XtraEditors.XtraForm
    {
        public bool Kaydedildi = false;
        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();
        public frmHareketTipiIslem()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            eislem.HareketTipiOlustur(txtKodu.Text, txtAdi.Text);
        }
    }
}