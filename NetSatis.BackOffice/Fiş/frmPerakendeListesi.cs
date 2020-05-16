using DevExpress.XtraPrinting;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Fatura_ve_Fiş;
using System;
using System.IO;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Fiş
{
    public partial class frmPerakendeListesi : Form
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();

        int user = 0;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\frmPerakendeListesi.xml";
        public frmPerakendeListesi(DateTime baslangic, DateTime bitis, int userId = 0)
        {
            user = userId;
            InitializeComponent();
            gridContFisler.DataSource = fisDal.PerakendeFis(context, "Perakende Satış Faturası", baslangic, bitis);
        }

        private void frmPerakendeListesi_Load(object sender, EventArgs e)
        {
            if (File.Exists(DosyaYolu)) gridContFisler.MainView.RestoreLayoutFromXml(DosyaYolu);
            Listele();
        }

        private void Listele()
        {
            context = new NetSatisContext();
            //gridContFisler.DataSource = fisDal.PerakendeFis(context, "Perakende Satış Faturası", DateTime.MinValue, DateTime.MaxValue);
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
            Listele();
        }



        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmFisIslem form=new frmFisIslem(null,e.Item.Caption);
            //form.Show();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
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

        private void gridFisler_DoubleClick(object sender, EventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            frmFisIslem form = new frmFisIslem(secilen, null);
            form.Show();
        }

        private void lblBaslik_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string secilen = gridFisler.GetFocusedRowCellValue(colFisKodu).ToString();
            FaturaHazirla f = new FaturaHazirla();
            f.FaturaHazirlama(secilen);
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());

            link.Component = gridContFisler;

            link.Landscape = true;
            link.ShowPreview();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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

        private void gridFisler_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
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
    }
}
