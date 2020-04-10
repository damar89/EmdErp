using DevExpress.XtraEditors.Mask;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmTarihliDetay : DevExpress.XtraEditors.XtraForm
    {

        FisDAL fisDal = new FisDAL();
        KategoriDAL kategoriDal = new KategoriDAL();
        AnaGrupDAL anagrupDal = new AnaGrupDAL();
        AltGrupDAL altgrupDal = new AltGrupDAL();
        StokDAL stokDal = new StokDAL();
        NetSatisContext context = new NetSatisContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public frmTarihliDetay()
        {
            InitializeComponent();
            lokKategori.Properties.DataSource = kategoriDal.GetAll(context);
            lookAnaGrup.Properties.DataSource = anagrupDal.GetAll(context);
            lookAltGrup.Properties.DataSource = altgrupDal.GetAll(context);
            lookMarka.Properties.DataSource = stokDal.StokListele(context);
            lookUretici.Properties.DataSource = stokDal.StokListele(context);

            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);
            frmDetayHareket form = new frmDetayHareket(dtBaslangic, dtBitis);
            form.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBaslangic_Properties_Click(object sender, EventArgs e)
        {

        }

        private void dtpBaslangic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            }
        }

        private void dtpBitis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            }
        }


    }
}