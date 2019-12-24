using System;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Stok_Hareketleri
{
    public partial class frmStokSatis : Form

    {
        NetSatisContext context = new NetSatisContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\StokSatissSavedLayout.xml";
        public frmStokSatis(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            gridContStokHareket.DataSource = stokHareketDal.StokSatisListeletTarih(context, "Stok Çıkış", baslangic, bitis);
        }





        private void frmStokSatis_Load(object sender, EventArgs e)
        {

            gridContStokHareket.ForceInitialize();

            if (File.Exists(DosyaYolu)) gridContStokHareket.MainView.RestoreLayoutFromXml(DosyaYolu);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void repoSeriNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string veri = Convert.ToString(gridStokHareket.GetFocusedRowCellValue(colSeriNo));
            frmSeriNoGir form = new frmSeriNoGir(veri);

            form.ShowDialog();

        }

        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            frmFisIslem form = new frmFisIslem(gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();

        }

        private void frmStokSatis_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            (gridContStokHareket.MainView as GridView).Columns["FisKodu"].Visible = false;
            (gridContStokHareket.MainView as GridView).Columns["Tarih"].Visible = false;
            (gridContStokHareket.MainView as GridView).Columns["Birim"].Visible = false;
            (gridContStokHareket.MainView as GridView).Columns["IndirimOrani"].Visible = false;
            (gridContStokHareket.MainView as GridView).Columns["colIndirimTutar"].Visible = false;
            (gridContStokHareket.MainView as GridView).Columns["Aciklama"].Visible = false;
            //(gridContStokHareket.MainView as GridView).Columns["StokAdi"].Visible = false;




            link.Component = gridContStokHareket;

            link.Landscape = false;
            link.ShowPreview();
            (gridContStokHareket.MainView as GridView).Columns["FisKodu"].Visible = true;
            (gridContStokHareket.MainView as GridView).Columns["Tarih"].Visible = true;
            (gridContStokHareket.MainView as GridView).Columns["Birim"].Visible = true;
            (gridContStokHareket.MainView as GridView).Columns["IndirimOrani"].Visible = true;
            (gridContStokHareket.MainView as GridView).Columns["colIndirimTutar"].Visible = true;
            (gridContStokHareket.MainView as GridView).Columns["Aciklama"].Visible = true;
            //(gridContStokHareket.MainView as GridView).Columns["StokAdi"].Visible = true;
            //(gridContStokHareket.MainView as GridView).Columns["StokAdi"].Visible = true;
            //(gridContStokHareket.MainView as GridView).Columns["StokAdi"].Visible = true;

        }

        private void gridStokHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void frmStokSatis_FormClosing(object sender, FormClosingEventArgs e)
        {

            gridStokHareket.ClearColumnsFilter();
            //if (!File.Exists(DosyaYolu)) File.Create(DosyaYolu);
            gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void btnFisYazici_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gridStokHareket_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
  
        }
    }
}
