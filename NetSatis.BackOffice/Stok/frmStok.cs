using System;
using System.Windows.Forms;
using NetSatis.BackOffice.Raporlar;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Stok;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data.Filtering;
using System.Linq;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        StokDAL stokDal = new StokDAL();
        BarkodDAL barkodDal = new BarkodDAL();
        private int secilen;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\StokList_SavedLayout.xml";
        public frmStok()
        {
            InitializeComponent();
            RoleTool.RolleriYukle(this);
        }
        private void frmStok_Load(object sender, EventArgs e)
        {
            GetAll();
            gridControl1.ForceInitialize();
            if (File.Exists(DosyaYolu)) gridControl1.MainView.RestoreLayoutFromXml(DosyaYolu);
        }
        public void GetAll()
        {
            gridControl1.DataSource = stokDal.StokListele(context);
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seçili Olan Veriyi Silmek İstediğinize Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StokHareketDAL dal = new StokHareketDAL();
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    var hareket = dal.GetAll(context, c => c.StokId == secilen);
                    if (hareket.Count > 0)
                    {
                        MessageBox.Show("Hareket görmüş bir stok silinemez.");
                        return;
                    }
                    barkodDal.Delete(context, c => c.StokId == secilen);
                    barkodDal.Save(context); stokDal.Delete(context, c => c.Id == secilen);
                    stokDal.Save(context);
                    GetAll();
                    //secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    //stokDal.Delete(context, c => c.Id == secilen);
                    //stokDal.Save(context);
                    //GetAll();
                }
            }
            catch (Exception)
            {
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokIslem form = new frmStokIslem(new Entities.Tables.Stok());
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
                    frmStokIslem form = new frmStokIslem(stokDal.GetByFilter(context, c => c.Id == secilen));
                    form.ShowDialog();
                    if (form.saved)
                    {
                        GetAll();
                    }
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }
        private void btnKopyala_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
                    stokEntity = stokDal.GetByFilter(context, c => c.Id == secilen);
                    frmStokIslem form = new frmStokIslem(stokEntity, true);
                    form.ShowDialog();
                    if (form.saved)
                    {
                        GetAll();
                    }
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }
        private void btnStokHareket_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    string secilenAd = gridView1.GetFocusedRowCellValue(colId).ToString();
                    frmStokHareket form = new frmStokHareket(secilen);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }
        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
            }
        }
        private void btnStokEnvanter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptStokDurumu report = new rptStokDurumu();
            frmRaporGoruntule form = new frmRaporGoruntule(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        private void btnStokBakiye_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptStokDurumBakiye report = new rptStokDurumBakiye();
            frmRaporGoruntule form = new frmRaporGoruntule(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmStokIslem form = new frmStokIslem(stokDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }
        private void btnStokKopyalaHizli_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
                stokEntity = stokDal.GetByFilter(context, c => c.Id == secilen);
                frmStokIslem form = new frmStokIslem(stokEntity, true);
                form.ShowDialog();
                if (form.saved)
                {
                    GetAll();
                }
            }
            catch (Exception)
            {
            }
        }
        private void frmStok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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
                btnStokHareket.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.C)
            {
                btnKopyala.PerformClick();
            }
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            int kayitsayisi; // kayıt sayısını tutacak değişkenimiz
            kayitsayisi = Convert.ToInt32(gridView1.RowCount);
            lblKayitSayisi.Text = kayitsayisi.ToString();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".pdf");
            }
        }
        private void btnYazdir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridControl1;
            link.Landscape = true;
            link.ShowPreview();
        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".docx");
            }
        }
        private void btnDizayn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ClearColumnsFilter();
            gridControl1.MainView.SaveLayoutToXml(DosyaYolu);
        }
        private void gridView1_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridView1.FocusedColumn.FilterInfo.Value != null)
            {
                string filter = gridView1.FocusedColumn.FilterInfo.Value.ToString();
                filter = filter.Replace(' ', '%');
                if (filter[filter.Length - 1] != '%')
                {
                    filter += '%';
                }
                if (filter[0] != '%')
                {
                    filter = '%' + filter;
                }
                gridView1.FocusedColumn.FilterInfo = new ColumnFilterInfo("[" + gridView1.FocusedColumn.FieldName + "] LIKE '" + filter + "'");
            }
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
        private void txtStokKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtStokKodu.Text != "")
                {
                    gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokKodu"), new OperandValue(filtreyeCevir(txtStokKodu.Text)), BinaryOperatorType.Like);
                }
            }
        }
        private void txtBarkodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtBarkodu.Text != "")
                {
                    var barkod = context.Barkodlar.Where(x => x.Barkodu == txtBarkodu.Text).FirstOrDefault();
                    if (barkod != null)
                    {
                        gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokKodu"), new OperandValue(barkod.Stok.StokKodu), BinaryOperatorType.Like);
                    }
                    else
                    {
                        MessageBox.Show("Barkod bulunamadı.");
                    }

                    //gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("Barkodu"), new OperandValue(filtreyeCevir(txtBarkodu.Text)), BinaryOperatorType.Like);
                }
            }
        }
        private void txtStokAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txtStokAdi.Text != "")
                {
                    gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokAdi"), new OperandValue(filtreyeCevir(txtStokAdi.Text)), BinaryOperatorType.Like);
                }
            }
        }
        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtStokKodu.Text != "")
            {
                gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokKodu"), new OperandValue(filtreyeCevir(txtStokKodu.Text)), BinaryOperatorType.Like);
            }
        }
        private void txtStokAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtStokAdi.Text != "")
            {
                gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokAdi"), new OperandValue(filtreyeCevir(txtStokAdi.Text)), BinaryOperatorType.Like);
            }
        }
        private void txtBarkodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtBarkodu.Text != "")
            {
                gridView1.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("Barkodu"), new OperandValue(filtreyeCevir(txtBarkodu.Text)), BinaryOperatorType.Like);
            }
        }
        private void btnStokDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                if (gridView1.RowCount != 0)
                {
                    secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    frmStokIslem form = new frmStokIslem(stokDal.GetByFilter(context, c => c.Id == secilen));
                    form.ShowDialog();
                    if (form.saved)
                    {
                        gridControl1.DataSource = stokDal.StokListele(context);
                    }
                }
                else
                {
                    MessageBox.Show("Seçili Stok Bulunamadı");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
