using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using DevExpress.XtraPrinting;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariEkstreTarih : DevExpress.XtraEditors.XtraForm
    {
        CariDAL cariDal = new CariDAL();
        NetSatisContext context = new NetSatisContext();
        private int _cariId;
        public frmCariEkstreTarih(int cariId, DateTime baslangic, DateTime bitis)
        {
            _cariId = cariId;
            InitializeComponent();
            gridContCariHareket.DataSource = cariDal.CariFisAyrinti(context,cariId,baslangic,bitis);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gridCariHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }
        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridContCariHareket;
            link.Landscape = true;
            link.ShowPreview();
        }
        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridContCariHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridContCariHareket.ExportToPdf(save.FileName + ".pdf");
            }
        }
        private void frmCariEkstreTarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
        }
    }
}