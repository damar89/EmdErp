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
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using DevExpress.XtraPrinting;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmGenelAlisRapor : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();


        public frmGenelAlisRapor(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            gridContStokHareket.DataSource = stokHareketDal.AlisListele(context,"Stok Giriş", baslangic, bitis);
        }

        private void frmGenelAlisRapor_Load(object sender, EventArgs e)
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
            link.ShowPreview();
        }

        private void frmGenelAlisRapor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                btnKapat.PerformClick();
            }
        }
    }
}
