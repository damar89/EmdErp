using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Cari;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors.Mask;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariHareket : Form
    {
        CariDAL cariDal = new CariDAL();
        NetSatisContext context = new NetSatisContext();
        private int _cariId;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\CariHareketSavedLayout.xml";
        public frmCariHareket(int cariId)
        {
            InitializeComponent();
            _cariId = cariId;
            var cariEntity = cariDal.GetByFilter(context, c => c.Id == _cariId);
            lblBaslik.Text = cariEntity.CariKodu + " - " + cariEntity.CariAdi + "  Hareketleri ";
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
        }
        private void frmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
            if (File.Exists(DosyaYolu)) gridContCariHareket.MainView.RestoreLayoutFromXml(DosyaYolu);
        }
        private void Guncelle()
        {
            gridContFisToplam.DataSource = cariDal.CariFisGenelToplam(context, _cariId);
            gridContBakiye.DataSource = cariDal.CariGenelToplam(context, _cariId);
            gridContCariHareket.DataSource = cariDal.CariFisAyrinti(context, _cariId);
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
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmCariHareket_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void btnCariEkstreDokumu_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);
            rptCariExtresi rpr = new rptCariExtresi(_cariId, dtBaslangic, dtBitis);
            rpr.ShowPreview();
        }
        private void gridCariHareket_DoubleClick(object sender, EventArgs e)
        {
            string secilen = gridCariHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            string fisturu = gridCariHareket.GetFocusedRowCellValue(colFisTuru).ToString();
            frmFisIslem form = new frmFisIslem(secilen,fisturu);
            form.ShowDialog();
        }
        private void frmCariHareket_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridCariHareket.ClearColumnsFilter();
            gridContCariHareket.MainView.SaveLayoutToXml(DosyaYolu);
        }
        private void gridCariHareket_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
            }
        }
        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridContCariHareket;
            link.Landscape = true;
            link.ShowPreview();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            //rptStokDetayli rpr = new rptStokDetayli(_cariId, dtBaslangic, dtBitis);
            //rpr.ShowPreview();
        }
        private void btnDetayliExtre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            rptCariExtresiStokDetayli rpr = new rptCariExtresiStokDetayli(_cariId, dtBaslangic, dtBitis);
            rpr.ShowPreview();
        }
    }
}
