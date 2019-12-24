using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Ödeme_Türü
{
    public partial class frmOdemeTuruHareket : Form
    {
        NetSatisContext context=new NetSatisContext();
        OdemeTuruDAL odemeTuruDal=new OdemeTuruDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        private int _odemeTuruId;

        public frmOdemeTuruHareket(int odemeTuruId)
        {
            InitializeComponent();
            _odemeTuruId = odemeTuruId;
            var odemeTuruBilgi = context.OdemeTurleri.SingleOrDefault(c => c.Id == odemeTuruId);
            lblBaslik.Text = odemeTuruBilgi.OdemeTuruKodu + " - " + odemeTuruBilgi.OdemeTuruAdi + "  Hareketleri ";

        }

        private void frmOdemeTuruHareket_Load(object sender, EventArgs e)
        {Listele();

        }

        void Listele()
        {
            gridContKasaHareket.DataSource = kasaHareketDal.GetAll(context, c => c.OdemeTuruId == _odemeTuruId);
            gridContKasaBakiye.DataSource = odemeTuruDal.KasaToplamListele(context, _odemeTuruId);
            gridContGenelToplam.DataSource = odemeTuruDal.GenelToplamListele(context, _odemeTuruId);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            gridKasaHareket.OptionsView.ShowAutoFilterRow=false?true:false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
