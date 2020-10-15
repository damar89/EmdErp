using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmGenelIade : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();


        public frmGenelIade(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();

            context = new NetSatisContext();
            gridContStokHareket.DataSource = stokHareketDal.GenelIadeListele(context, "Perakende İade Faturası","Perakende İade İrsaliyesi", baslangic, bitis);


        }

        private void frmGenelIade_Load(object sender, EventArgs e)
        {

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

        private void gridStokHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridStokHareket.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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



        private void btnFaturayazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(secilen);
        }
    }
}
