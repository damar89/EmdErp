using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmDetayHareket : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KasaDAL kasaDal = new KasaDAL();
        private Func<NetSatisContext, Expression<Func<Entities.Tables.Kasa, bool>>, List<Entities.Tables.Kasa>> getAll;
        private DateTime dtBaslangic;
        private DateTime dtBitis;

        public frmDetayHareket(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            gridContFisler.DataSource = fisDal.TumListelemeler(context, baslangic, bitis);
            //gridContKasaHareket.DataSource = kasaDal.OdemeTuruToplamListeleTarih(context,baslangic, bitis);
        }


        private void frmDetayHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            context = new NetSatisContext();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }



        private void btnFltKapat_Click(object sender, EventArgs e)
        {


        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {


        }



        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {


        }

        private void gridFisler_DoubleClick(object sender, EventArgs e)
        {


        }

        private void gridContFisler_Click(object sender, EventArgs e)
        {

        }

        private void frmDetayHareket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                btnKapat.PerformClick();
            }
        }

        private void gridFisler_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
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

                gridFisler.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridContFisler;
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

