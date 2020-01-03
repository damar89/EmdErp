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
        int hareketid = 0;

        public frmHareketTipiIslem(int id, string kod, string aciklama)
        {
            hareketid = id;
            InitializeComponent();
            txtAdi.Text = aciklama;
            txtKodu.Text = kod;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (hareketid != 0)
            {
                eislem.HareketTipiDuzenle(hareketid, txtKodu.Text, txtAdi.Text);

            }
            else
            {
                eislem.HareketTipiOlustur(txtKodu.Text, txtAdi.Text);

            }
            this.Close();
        }
    }
}