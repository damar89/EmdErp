using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Fatura_ve_Fiş;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmTahsilatListesi : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();


        public frmTahsilatListesi(DateTime baslangic, DateTime bitis)
        {
            InitializeComponent();
            gridContFisler.DataSource = fisDal.Listelemeler2(context, "Toptan Satış Faturası", "Tahsilat Fişi", "Alış İade Faturası", baslangic, bitis);
        }

        private void frmSatisrpr_Load(object sender, EventArgs e)
        {
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
            catch (Exception)
            {

                MessageBox.Show("Seçili fiş bulunamadı.");
            }

        }



        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Item.Caption);
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
                    frmFisIslem form = new frmFisIslem(secilen, fisturu);
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
            frmFisIslem form = new frmFisIslem(secilen, fisturu);
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
                frmFisIslem form = new frmFisIslem(secilen, null);
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
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            rptKooperatif f = new rptKooperatif();
            f.LoadLayout(SettingsTool.AyarOku(SettingsTool.Ayarlar.MustahsilDizayn_DosyaYolu5));
            NetSatisContext context = new NetSatisContext();

            FisDAL fisDal = new FisDAL();
            f.Fis_Bilgileri.DataSource = fisDal.KooperatifFisi(context, secilen);
            f.Fis_Kalemleri.DataSource = fisDal.KooperatifFisiKalemleri(context, secilen);

            f.ShowPreview();

        }
        private void btnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToXlsx(save.FileName + ".xlsx");
            }
        }

        private void btnPdf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToPdf(save.FileName + ".pdf");
            }
        }

        private void btnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {

                gridFisler.ExportToPdf(save.FileName + ".docx");
            }
        }

        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
