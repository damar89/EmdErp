using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmStokHareket : Form
    {

        StokHareketDAL stokHareketDal = new StokHareketDAL();
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        private int _stokId;


        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\StokHareket_SavedLayout.xml";
        public frmStokHareket(int stokId)
        {
            InitializeComponent();

            _stokId = stokId;
            var stokBilgi = context.Stoklar.SingleOrDefault(c => c.Id == stokId);
            lblBaslik.Text = stokBilgi.StokKodu + " - " + stokBilgi.StokAdi + "  Hareketleri ";
        }

        private void frmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
            if (File.Exists(DosyaYolu)) gridContStokHareket.MainView.RestoreLayoutFromXml(DosyaYolu);
        }

        private void Guncelle()
        {
            gridContStokHareket.DataSource = stokHareketDal.GetAll2(context, c => c.StokId == _stokId);
            gridContGenelStok.DataSource = stokHareketDal.GetGenelStok(context, _stokId);
            gridContDepoStok.DataSource = stokHareketDal.GetDepoStok(context, _stokId);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridStokHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridStokHareket.OptionsView.ShowAutoFilterRow = true;
            }

        }

        private void frmStokHareket_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void gridStokHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
            }
        }

        private void btnFisDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridStokHareket_DoubleClick(object sender, EventArgs e)
        {
            //if (_fisentity.FisTuru != "Stok Devir Fişi" || _fisentity.FisTuru != "Sayım Fazlası Fişi" || _fisentity.FisTuru != "Sayım Eksiği Fişi" )
            //{
            string secilen = gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            string fisturu = gridStokHareket.GetFocusedRowCellValue(colFisTuru).ToString();
            frmFisIslem form = new frmFisIslem(secilen, fisturu);
            form.ShowDialog();

        }
        //else
        //{
        //    MessageBox.Show("Bu fişlerin düzenlenmesi bu ekrandan yapılamaz. Lütfen Fiş Listelerinden ilgili fişi Seçip düzenleme işlemlerinizi yapabilirsiniz.");

    

    private void frmStokHareket_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void btnDizayn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        gridStokHareket.ClearColumnsFilter();
        gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
    }
}
}
