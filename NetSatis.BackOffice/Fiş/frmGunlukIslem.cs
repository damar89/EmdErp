using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmGunlukIslem : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        OdemeTuruDAL odemeTuruDal = new OdemeTuruDAL();

        int user = 0;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\frmGunlukIslem.xml";
        public frmGunlukIslem(DateTime baslangic, DateTime bitis, int userId = 0)
        {
            user = userId;
            InitializeComponent();
            gridContFisler.DataSource = fisDal.GunlukListelemeler(context, "Perakende Satış Faturası", "Toptan Satış Faturası", "Perakende Satış İrsaliyesi", "Ödeme Fişi", "Tahsilat Fişi", "Masraf Fişi", "Pos Fatura","Perakende İade Faturası","Satış İade Faturası", baslangic, bitis);
        }

        private void frmGunlukIslem_Load(object sender, EventArgs e)
        {
            if (File.Exists(DosyaYolu)) gridContFisler.MainView.RestoreLayoutFromXml(DosyaYolu);

            Listele();

            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Kooperatif_Kooperatifmi)))
            {
                btnMustahsil.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnMustahsil.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }


        private void Listele()
        {
            context = new NetSatisContext();


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridFisler.RowCount != 0)
                {
                    if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(gridFisler.GetFocusedRowCellValue(colId).ToString());
                        string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                        string fisTuru = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
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
                            Listele();
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



        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Item.Caption, false, null, user);
            form.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridFisler.RowCount != 0)
                {
                    string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                    string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
                    frmFisIslem form = new frmFisIslem(secilen, fisturu, false, null, user);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Seçili fiş bulunamadı.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Seçili fiş bulunamadı.");
            }

        }

        private void gridFisler_DoubleClick(object sender, EventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();
            frmFisIslem form = new frmFisIslem(secilen, fisturu, false, null, user);
            form.Show();
        }

        private void gridFisler_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }

        private void btnFaturaYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(secilen);
        }

        private void btnFaturaduzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridFisler.RowCount != 0)
            {
                string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                string fisturu = gridFisler.GetFocusedRowCellValue(colFisTuru).ToString();

                frmFisIslem form = new frmFisIslem(secilen, fisturu, false, null, user);
                form.Show();
            }
            else
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }

        private void btnFtrSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridFisler.RowCount != 0)
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
                    fisDal.Delete(context, c => c.FisKodu == secilen);
                    kasaHareketDal.Delete(context, c => c.FisKodu == secilen);
                    stokHareketDal.Delete(context, c => c.FisKodu == secilen);
                    fisDal.Save(context);
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Seçili fiş bulunamadı.");
            }
        }

        private void btnFaturaGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Listele();
        }

        private void btnMustahsil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            rptKooperatif f = new rptKooperatif();
            f.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.MustahsilDizayn_DosyaYolu5));
            NetSatisContext context = new NetSatisContext();

            FisDAL fisDal = new FisDAL();
            f.Fis_Bilgileri.DataSource = fisDal.KooperatifFisi(context, secilen);
            f.Fis_Kalemleri.DataSource = fisDal.KooperatifFisiKalemleri(context, secilen);

            f.ShowPreview();*/

        }

        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToXls(save.FileName + ".xlsx");
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToDocx(save.FileName + ".docx");
            }
        }

        private void btnBilgiFisi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.BilgiFisi(secilen);
        }

        private void btnGorunumKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Directory.Exists($@"{Application.StartupPath}\Gorunum"))
                gridContFisler.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void btnTahsilat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.TahsilatFisi(secilen);
        }

        private void btnNakit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fisKodu = gridFisler.GetFocusedRowCellValue("FisKodu") as string;
            if (fisKodu == null)
                return;
            var fisKayit = kasaHareketDal.GetAll(context, x => x.FisKodu == fisKodu).FirstOrDefault();
            fisKayit.OdemeTuruId= 1;
            //fisKayit.OdemeTuru.OdemeTuruKodu = "001";
            //fisKayit.OdemeTuru.OdemeTuruAdi = "Nakit";

            kasaHareketDal.Save(context);  
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fisKodu = gridFisler.GetFocusedRowCellValue("FisKodu") as string;
            if (fisKodu == null)
                return;
            var fisKayit = kasaHareketDal.GetAll(context, x => x.FisKodu == fisKodu).FirstOrDefault();
            fisKayit.OdemeTuruId = 2;
            //fisKayit.OdemeTuru.OdemeTuruKodu = "001";
            //fisKayit.OdemeTuru.OdemeTuruAdi = "Nakit";

            kasaHareketDal.Save(context);
        }
    }
}
