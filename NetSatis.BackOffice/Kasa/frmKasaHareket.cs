using System;
using System.Linq;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Kasa
{
    public partial class frmKasaHareket : Form
    {
        KasaDAL kasaDal = new KasaDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        NetSatisContext context = new NetSatisContext();
        private int _kasaId;
        public frmKasaHareket(int kasaId)
        {
            InitializeComponent();

            _kasaId = kasaId;
            var kasaBilgi = context.Kasalar.SingleOrDefault(c => c.Id == kasaId);

            lblBaslik.Text = kasaBilgi.KasaKodu + " - " + kasaBilgi.KasaAdi + " Kasa Hareketleri ";
          
        }

        private void frmKasaHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            gridContKasaHareket.DataSource = kasaHareketDal.GetAll(context, c => c.KasaId == _kasaId);
            gridContOdemeTuruToplam.DataSource = kasaDal.OdemeTuruToplamListele(context, _kasaId);
            gridContGenelToplam.DataSource = kasaDal.GenelToplamListele(context, _kasaId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridKasaHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridKasaHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKasaHareket_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void btnKasaRaporu_Click(object sender, EventArgs e)
        {
           
        }
    }
}
