using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Depo
{
    public partial class frmDepoHareket : Form
    {
        NetSatisContext context=new NetSatisContext();
        StokHareketDAL stokHareketDal=new StokHareketDAL();
        private int _depoId;
        public frmDepoHareket(int depoId)
        {
            InitializeComponent();
            _depoId = depoId;
            var depo = context.Depolar.SingleOrDefault(c => c.Id == _depoId);
            lblBaslik.Text = depo.DepoKodu + " - " + depo.DepoAdi + " Depo Hareketleri ";
        }

        private void frmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            gridContHareket.DataSource = stokHareketDal.GetAll(context, c => c.DepoId == _depoId);
            gridContDepoStok.DataSource = stokHareketDal.DepoStokListele(context,_depoId);
            gridContIstatistik.DataSource = stokHareketDal.DepoIstatistlikListele(context, _depoId);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void frmDepoHareket_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Escape)
            {

                btnKapat.PerformClick();
            }
        }
    }
}
