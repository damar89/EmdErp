using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using DevExpress.XtraPrinting;
using NetSatis.Reports.Fatura_ve_Fiş;

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
            gridContStokHareket.DataSource = stokHareketDal.GenelIadeListele(context, "Satış İade Faturası", baslangic, bitis);


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
