using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Kasa_Hareketleri
{
    public partial class frmTarihKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        KasaDAL kasaDal = new KasaDAL();
        public frmTarihKasaHareket(int kasaId,DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();

            gridContKasaHareket.DataSource = kasaDal.OdemeTuruToplamListeleTarih(context,kasaId,baslangic,bitis);
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTarihKasaHareket_KeyDown(object sender, KeyEventArgs e)
        {
              if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void gridKasaHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
             if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            link.Component = gridContKasaHareket;

            link.Landscape = true;
            link.Landscape = true;
            link.Margins.Left = 3;
            link.Margins.Right = 3;
            link.Margins.Top = 6;
            link.Margins.Bottom = 3;
            link.ShowPreview();
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridKasaHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridKasaHareket.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
    }
}