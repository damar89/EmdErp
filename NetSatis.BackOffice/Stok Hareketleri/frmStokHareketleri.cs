﻿using System;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Stok_Hareketleri
{
    public partial class frmStokHareketleri : Form

    {
        NetSatisContext context = new NetSatisContext();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\GenelHareketSavedLayout.xml";
        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        

        private void Listele()
        {
          gridContStokHareket.DataSource=  stokHareketDal.GetAll2(context);
            
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
            gridContStokHareket.ForceInitialize();

            if (File.Exists(DosyaYolu)) gridContStokHareket.MainView.RestoreLayoutFromXml(DosyaYolu);

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
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
            frmFisIslem form=new frmFisIslem(gridStokHareket.GetFocusedRowCellValue(colFisKodu).ToString());
            form.ShowDialog();

        }

        private void frmStokHareketleri_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            link.Component = gridContStokHareket;

            link.Landscape = true;
            link.ShowPreview();
        }

        private void gridStokHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void frmStokHareketleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridStokHareket.ClearColumnsFilter();
            //if (!File.Exists(DosyaYolu)) File.Create(DosyaYolu);
            gridContStokHareket.MainView.SaveLayoutToXml(DosyaYolu);
        }
    }
}
