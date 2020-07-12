using DevExpress.XtraEditors.Mask;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using NetSatis.BackOffice.Fiş;
using NetSatis.EDonusum;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Cari;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariHareket : Form
    {

        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        CariDAL cariDal = new CariDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
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

        private void btnBilgiFisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridCariHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.BilgiFisi(secilen);
        }

        private void btnFatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridCariHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(secilen);
        }

        private void btnTahsilat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridCariHareket.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.TahsilatFisi(secilen);
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridCariHareket.RowCount != 0)
                {
                    if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(gridCariHareket.GetFocusedRowCellValue(colId).ToString());
                        string secilen = gridCariHareket.GetFocusedRowCellValue(colFisKodu).ToString();
                        string fisTuru = gridCariHareket.GetFocusedRowCellValue(colFisTuru).ToString();
                        string faturaFisKodu = context.Fisler.FirstOrDefault(x => x.FisKodu == secilen).FaturaFisKodu;
                        if (!String.IsNullOrEmpty(faturaFisKodu) && (fisTuru == "Satış İrsaliyesi" || fisTuru == "Alış İrsaliyesi"))
                        {
                            MessageBox.Show("Faturalandırılmış irsaliyeleri silemezsiniz.");
                            return;
                        }
                        else
                        {
                            bool carietkilesin = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_CariEtkilesin));
                            bool stoketkilesin = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_StoguEtkilesin));
                            var list = context.Fisler.Where(x => x.FaturaFisKodu == secilen).ToList();
                            string[] ids = new string[list.Count];
                            int i = 0;
                            foreach (var item in list)
                            {
                                ids[i] = item.FisKodu;
                                i++;
                            }
                            var stoklist = context.StokHareketleri.Where(x => ids.Contains(x.FisKodu)).ToList();
                            list.ForEach(a => a.FaturaFisKodu = "");
                            list.ForEach(a => a.CariIrsaliye = carietkilesin ? "1" : "0");
                            list.ForEach(a => a.StokIrsaliye = stoketkilesin ? "1" : "0");
                            stoklist.ForEach(a => a.StokIrsaliye = stoketkilesin ? "1" : "0");
                            context.SaveChanges();
                            fisDal.Delete(context, c => c.FisKodu == secilen);
                            kasaHareketDal.Delete(context, c => c.FisKodu == secilen);
                            stokHareketDal.Delete(context, c => c.FisKodu == secilen);

                            fisDal.Save(context);
                            NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();
                            eislem.MasterSil(id);
                          
                            MessageBox.Show("Fiş başarıyla silindi.");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }
    }
}
