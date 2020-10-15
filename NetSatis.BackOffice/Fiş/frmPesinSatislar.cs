using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.IO;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmPesinSatislar : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\PesSatis_SavedLayout.xml";

        public frmPesinSatislar(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            gridContStokHareket.DataSource = stokHareketDal.AlisListele(context, "Stok Giriş", baslangic, bitis);
        }

        private void frmPesinSatislar_Load(object sender, EventArgs e)
        {
            calcToplam.Text = Convert.ToString(colToplamTutar.SummaryItem.SummaryValue);
            if (File.Exists(DosyaYolu)) gridContStokHareket.MainView.RestoreLayoutFromXml(DosyaYolu);
        }





        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Item.Caption);
            form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void gridStokHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            link.Component = gridContStokHareket;

            link.Landscape = true;
            link.Landscape = true;
            link.Margins.Left = 3;
            link.Margins.Right = 3;
            link.Margins.Top = 6;
            link.Margins.Bottom = 3;
            link.ShowPreview();
        }

        private void frmPesinSatislar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                btnKapat.PerformClick();
            }
        }

        private void btnBilgiFisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDizayn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStokHareket.ClearColumnsFilter();
            gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void btnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(secilen);
        }

        private void btnBilgiFisi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.BilgiFisi(secilen);
        }
    }
}
