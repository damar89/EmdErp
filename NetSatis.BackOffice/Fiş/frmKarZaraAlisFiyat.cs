using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmKarZaraAlisFiyat : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();

        public frmKarZaraAlisFiyat(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            gridContStokHareket.DataSource = stokHareketDal.StokSatisListeletTarih(context, "Stok Çıkış", baslangic, bitis);
        }

        private void gridStokHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToXlsx(save.FileName + ".xlsx");
            }

        }

        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToDocx(save.FileName + ".docs");
            }
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
    }
}