using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using NetSatis.BackOffice.Fiş;
using NetSatis.BackOffice.Raporlar;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Reports.Cari;
using System;
using System.IO;
using System.Windows.Forms;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmCari : Form
    {
        private NetSatisContext context = new NetSatisContext();
        private CariDAL cariDal = new CariDAL();
        private Nullable<int> secilen = null;
        FisDAL fisDal = new FisDAL();
     
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\CariListeSavedLayout.xml";
        public frmCari()
        {
            InitializeComponent();
          
        }
        private void frmCari_Load(object sender, EventArgs e)
        {
            GetAll();
            lblBorc.Text = Convert.ToString(colAlacak.SummaryItem.SummaryValue);
            lblAlacak.Text = Convert.ToString(colBorc.SummaryItem.SummaryValue);
            gridControl1.ForceInitialize();
            if (File.Exists(DosyaYolu)) gridControl1.MainView.RestoreLayoutFromXml(DosyaYolu);
        }
        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KasaHareketDAL dal = new KasaHareketDAL();
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    var hareket = dal.GetAll(context, c => c.CariId == secilen);
                    if (hareket.Count > 0)
                    {
                        MessageBox.Show("Hareket görmüş bir cari silinemez.");
                        return;
                    }
                    cariDal.Delete(context, c => c.Id == secilen);
                    cariDal.Save(context);
                    GetAll();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili bir Cari bulunamadı. ");
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmCariIslem form = new frmCariIslem(new Entities.Tables.Cari());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    frmCariIslem form = new frmCariIslem(cariDal.GetByFilter(context, c => c.Id == secilen));
                    form.ShowDialog();
                    if (form.saved)
                    {
                     
                    }
                }
                else
                {
                    MessageBox.Show("Seçili Cari Bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Cari Bulunamadı");
            }
        }
        private void btnKopyala_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
                    cariEntity = cariDal.GetByFilter(context, c => c.Id == secilen);
                    frmCariIslem form = new frmCariIslem(cariEntity, true);
                    form.ShowDialog();
                    if (form.saved)
                    {
                        GetAll();
                    }
                }
                else
                {
                    MessageBox.Show("Seçili Cari Bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Cari Bulunamadı");
            }
        }
        private void btnCariHareket_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
                    frmCariHareket form = new frmCariHareket(Convert.ToInt32(secilen));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Cari Bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Cari Bulunamadı");
            }
        }
        private void btnDisaAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptCariBakiye report = new rptCariBakiye();
            frmRaporGoruntule form = new frmRaporGoruntule(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition; popupMenu1.ShowPopup(p2);
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                frmCariIslem form = new frmCariIslem(cariDal.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
                if (form.saved)
                {
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void btnCariKopyalaHizli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
                cariEntity = cariDal.GetByFilter(context, c => c.Id == secilen);
                frmCariIslem form = new frmCariIslem(cariEntity, true);
                form.ShowDialog();
                if (form.saved)
                {
                    GetAll();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        private void btnCariHareketHizli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
                frmCariHareket form = new frmCariHareket(Convert.ToInt32(secilen));
                form.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Entities.Tables.Cari cariEntity = new Entities.Tables.Cari();
                cariEntity = cariDal.GetByFilter(context, c => c.Id == secilen);
                string tur = e.Item.Caption;
                frmFisIslem form = new frmFisIslem(null, tur,true,cariEntity);
                form.Show();
            }
            else
            {
                MessageBox.Show("Seçili Cari bulunamadı.");
            }
        }
        private void frmCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.Y)
            {
                btnEkle.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                btnDuzenle.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnGuncelle.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.S)
            {
                btnSil.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.H)
            {
                btnCariHareket.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.C)
            {
                btnKopyala.PerformClick();
            }
        }
        private void frmCari_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            int kayitsayisi; // kayıt sayısını tutacak değişkenimiz
            kayitsayisi = Convert.ToInt32(gridView1.RowCount);
            lblKayitSayisi.Text = kayitsayisi.ToString();
        }
        private void btnCariStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
                frmCariHareketStok form = new frmCariHareketStok(Convert.ToInt32(secilen));
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili Cari Bulunamadı");
            }
        }
        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView view = gridView1;
            view.ActiveFilter.Add(view.Columns["HesapBakiye"],
              new ColumnFilterInfo("[HesapBakiye] Like 'B%'"));
        }
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView view = gridView1;
            view.ActiveFilter.Add(view.Columns["HesapBakiye"],
              new ColumnFilterInfo("[HesapBakiye] Like 'A%'"));
        }
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
            gridControl1.MainView.SaveLayoutToXml(DosyaYolu);
        }
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ActiveFilter.Clear();
            //ColumnView view = gridView1;
            //view.ActiveFilter.Add(view.Columns["HesapBakiye"],
            //  new ColumnFilterInfo("[HesapBakiye] Like '%'"+"[Durum] like '%'"));
        }
        string filtreyeCevir(string filtre)
        {
            filtre = filtre.Replace(' ', '%');
            if (filtre[filtre.Length - 1] != '%')
            {
                filtre += '%';
            }
            if (filtre[0] != '%')
            {
                filtre = '%' + filtre;
            }
            return filtre;
        }
        private void txtcCariAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("CariAdi"), new OperandValue(filtreyeCevir(txtcCariAdi.Text)), BinaryOperatorType.Like);
            }
        }
        private void txtCariKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("CariKodu"), new OperandValue(filtreyeCevir(txtCariKodu.Text)), BinaryOperatorType.Like);
            }
        }
        private void txtcCariAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("CariAdi"), new OperandValue(filtreyeCevir(txtcCariAdi.Text)), BinaryOperatorType.Like);
        }
        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("CariKodu"), new OperandValue(filtreyeCevir(txtCariKodu.Text)), BinaryOperatorType.Like);
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView view = gridView1;
            view.ActiveFilter.Add(view.Columns["Durum"],
              new ColumnFilterInfo("[Durum]=true"));
        }

        private void btnPasifCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ColumnView view = gridView1;

            view.ActiveFilter.Clear();
            view.ActiveFilter.Add(view.Columns["Durum"],
              new ColumnFilterInfo("[Durum]=false"));
            //ColumnView view = gridView1;
            //view.ActiveFilter.Add(view.Columns["Durum"],
            //  new ColumnFilterInfo("False"));
        }
    }
}
