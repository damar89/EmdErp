using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using NetSatis.BackOffice.Raporlar;
using NetSatis.Entities;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Stok;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSatis.BackOffice.Annotations;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmStok : DevExpress.XtraEditors.XtraForm, INotifyPropertyChanged
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

            if (File.Exists(DosyaYolu)) gridControl1.MainView.RestoreLayoutFromXml(DosyaYolu);
           

            TumStoklar = new List<Entities.Tables.Stok>();

            gridControl1.DataSource = TumStoklar;

            btnSorgula.PerformClick();


            gridView1.BestFitColumns();
            gridControl1.ForceInitialize();
            txtAramaMetni.Focus();
        }
        public void GetAll()
        {
            //gridControl1.DataSource = stokDal.StokAdiylaStokGetir(context);
            btnSorgula.PerformClick();
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
                    btnSorgula.PerformClick();
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
                btnSorgula.PerformClick();
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
                        btnSorgula.PerformClick();
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
                        btnSorgula.PerformClick();
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
            btnSorgula.PerformClick();
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
                    btnSorgula.PerformClick();
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
            if (e.KeyCode == Keys.F4)
                btnSorgula.PerformClick();
        }
        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            int kayitsayisi; // kayıt sayısını tutacak değişkenimiz
            kayitsayisi = Convert.ToInt32(gridView1.RowCount);
            layGroupStokSayisi.Value =Convert.ToDecimal(kayitsayisi);
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(save.FileName + ".xlsx");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();

            base.OnFormClosing(e);

        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if (save.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToPdf(save.FileName + ".pdf");
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
                gridView1.ExportToDocx(save.FileName + ".docx");
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

        private List<Entities.Tables.Stok> TumStoklar { get; set; }
        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        async Task Sorgula(CancellationToken token)
        {

            if (token.IsCancellationRequested)
                return;
            TumStoklar.Clear();
                OnPropertyChanged(nameof(TumStoklar));
                gridView1.RefreshData();
            var pred = PredicateBuilder.True<Entities.Tables.Stok>();

            if (!string.IsNullOrEmpty(txtAramaMetni.Text))
            {
                foreach (string item in txtAramaMetni.Text.Split(' '))
                {
                    if (!string.IsNullOrEmpty(item))
                        pred = pred.And(x => x.StokAdi.Contains(item) || x.StokKodu.Contains(item) || x.Marka.Contains(item) || x.Uretici.Contains(item) || x.Barkod.Any(s => s.Barkodu.Contains(item)) || x.Barkodu.Contains(item) );
                }
            }

            var take = 5000;
            var count = Math.Ceiling(
                Convert.ToDecimal(stokDal.StokKayitSayisi(context, pred) / Convert.ToDecimal(take)));
            if (token.IsCancellationRequested)
                return;
            for (int i = 0; i < count; i++)
            {
                if (token.IsCancellationRequested)
                    break;
                TumStoklar.AddRange(stokDal.StokAdiylaStokGetir(context, pred, take * i, take, noTracking: true));
                OnPropertyChanged(nameof(TumStoklar));
                await Task.Delay(100);
                gridView1.RefreshData();
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
                        gridControl1.DataSource = stokDal.StokAdiylaStokGetir(context);
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

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAramaMetni.Text =
                txtBarkodu.Text =
                         txtStokKodu.Text = null;

            txtAramaMetni.Focus();
        }

        private async void btnSorgula_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
            tokenSource = new CancellationTokenSource();
            await Sorgula(tokenSource.Token);


        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
