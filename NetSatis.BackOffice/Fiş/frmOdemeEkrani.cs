using NetSatis.BackOffice.Kasa;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmOdemeEkrani : Form
    {
        NetSatisContext context = new NetSatisContext();
        public KasaHareket entity;
        private Nullable<decimal> gelenTutar;
        private Entities.Tables.Kasa _kasaBilgi;
        private OdemeTuru _odemeTuruBilgi;
        //MasrafDAL masrafDal = new MasrafDAL();

        public frmOdemeEkrani(int odemeTuruId, Nullable<decimal> odenmesiGerekenTutar = null , int userId = 0)
        {
            InitializeComponent();
            int user = userId;
            if (userId == 0)
            {
                user = frmAnaMenu.UserId;
            }
            int kasaid = Convert.ToInt32(context.Kullanicilar.Where(x => x.Id == user).FirstOrDefault().KasaId);
           
            int kasaId =kasaid;
            _kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);
            _odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);

            txtOdemeTuru.Text = _odemeTuruBilgi.OdemeTuruAdi;
            //lookMasraf.Properties.DataSource = masrafDal.GetAll(context);
            txtKasaKodu.Text = _kasaBilgi.KasaKodu;
            txtKasaAdi.Text = _kasaBilgi.KasaAdi;

            if (odenmesiGerekenTutar != null)
            {
                gelenTutar = odenmesiGerekenTutar.Value;
            }
            else
            {
                calcTutar.Properties.Buttons[1].Visible = false;
            }

        }

        private void frmOdemeEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnKasaSec_Click(object sender, EventArgs e)
        {
            frmKasaSec form = new frmKasaSec();
            form.ShowDialog();
            if (form.secildi)
            {
                _kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == form.entity.Id);
                txtKasaKodu.Text = form.entity.KasaKodu;
                txtKasaAdi.Text = form.entity.KasaAdi;
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string message = null;
            int error = 0;

            if (txtKasaAdi.Text == "")
            {
                message += "Kasa Bilgileri Boş Bırakılamaz.." + System.Environment.NewLine;
                error++;

            }

            if (calcTutar.Value <= 0)
            {
                message += "Tutar 0 veya 0 değerinden Küçük Olamaz.." + System.Environment.NewLine;
                error++;

            }
            if (calcTutar.Value > gelenTutar && gelenTutar != null)
            {
                message += "Eklenen tutar ödenmesi gereken tutardan büyük olamaz." + System.Environment.NewLine;
                error++;
            };

            if (error != 0)
            {
                MessageBox.Show(message);
                return;
            }


            entity = new KasaHareket();

            entity.OdemeTuruId = _odemeTuruBilgi.Id;
            entity.KasaId = _kasaBilgi.Id;
            
            entity.Tutar = calcTutar.Value;
            entity.Tarih = DateTime.Now;
            entity.Aciklama = txtAciklama.Text;
            this.Close();

        }

        private void calcTutar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                calcTutar.Value = gelenTutar.Value;
            }
        }

        private void frmOdemeEkrani_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt == true && e.KeyCode == Keys.K)
            {
                btnKaydet.PerformClick();
            }
            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void frmOdemeEkrani_Shown(object sender, EventArgs e)
        {
            calcTutar.Focus();
            
        }
    }
}
