using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Cari;
using DevExpress.XtraPrinting;
using System.IO;

namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariHareketStok : DevExpress.XtraEditors.XtraForm
    {
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\CariStokSavedLayout.xml";
        CariDAL cariDal = new CariDAL();
        NetSatisContext context = new NetSatisContext();
        private int _cariId;
        public frmCariHareketStok(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            var cariEntity = cariDal.GetByFilter(context, c => c.Id == _cariId);
            lblBaslik.Text = cariEntity.CariKodu + " - " + cariEntity.CariAdi + "  Hareketleri ";
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
        }

        private void frmCariHareketStok_Load(object sender, EventArgs e)
        {
            Guncelle();
            if (File.Exists(DosyaYolu)) gridContCariHareket.MainView.RestoreLayoutFromXml(DosyaYolu);
        }
        private void Guncelle()
        {
            //gridContFisToplam.DataSource = cariDal.CariFisGenelToplam(context, _cariId);
            //gridContBakiye.DataSource = cariDal.CariGenelToplam(context, _cariId);
            gridContCariHareket.DataSource = cariDal.CariFisAyrintiStok(context, _cariId,DateTime.MinValue, DateTime.MaxValue);
            
            }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (gridCariHareket.OptionsView.ShowAutoFilterRow == true)
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridCariHareket.OptionsView.ShowAutoFilterRow = true;
            }
        }

        private void btnCariEkstreDokumu_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            rptCariExtresiStok rpr = new rptCariExtresiStok(_cariId,dtBaslangic,dtBitis);
            rpr.ShowPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            rptCariExtresiStok rpr = new rptCariExtresiStok(_cariId, dtBaslangic, dtBitis);
            rpr.ShowPreview();
        }

        private void frmCariHareketStok_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridCariHareket.ClearColumnsFilter();
            gridContCariHareket.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void gridCariHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            link.Component = gridContCariHareket;
         
            link.Landscape = true;
            link.Margins.Left=3;
            link.Margins.Right=3;
            link.Margins.Top=6;
            link.Margins.Bottom=3;
        
            link.ShowPreview();
        }
    }
}