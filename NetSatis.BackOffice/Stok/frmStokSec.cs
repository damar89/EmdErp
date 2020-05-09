using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using NetSatis.Entities;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
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
    public partial class frmStokSec : DevExpress.XtraEditors.XtraForm, INotifyPropertyChanged
    {
        StokDAL stokDal = new StokDAL();
        NetSatisContext context;
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool secildi = false;
        private int sec;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\StokSec_SavedLayout.xml";

        private List<Entities.Tables.Stok> TumStoklar { get; set; }

        public frmStokSec(bool cokluSecim = false)
        {
            InitializeComponent();
            this.context = new NetSatisContext();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;
            }
        }

        public frmStokSec(ref NetSatisContext _context, string aramaMetni, bool useRef = true)
        {
            InitializeComponent();
            if (useRef)
            {
                this.context = _context;
            }
            else
            {
                this.context = new NetSatisContext();
            }
            txtAramaMetni.Text = aramaMetni;
        }

        public frmStokSec(ref NetSatisContext _context, bool cokluSecim = false)
        {
            InitializeComponent();
            this.context = _context;
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridStoklar.OptionsSelection.MultiSelect = true;

            }
        }
        private void frmStokSec_Load(object sender, EventArgs e)
        {

            if (File.Exists(DosyaYolu)) gridContStoklar.MainView.RestoreLayoutFromXml(DosyaYolu);

            TumStoklar = new List<Entities.Tables.Stok>();

            gridContStoklar.DataSource = TumStoklar;

            btnSorgula.PerformClick();
            txtAramaMetni.Focus();

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokKodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.FirstOrDefault(c => c.StokKodu == stokKodu));
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStokSec_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.Alt && e.KeyCode == Keys.Y)
                btnStokEkle.PerformClick();

            if (e.Alt && e.KeyCode == Keys.D)
                btnDuzenle.PerformClick();

            if (e.Alt && e.KeyCode == Keys.C)
                btnKopyala.PerformClick();
            if (e.Alt && e.KeyCode == Keys.H)
                btnHareketler.PerformClick();

            if (e.KeyCode == Keys.F4)
            {
                btnSorgula.PerformClick();
            }
            if (e.KeyCode == Keys.F5)
                btnTemizle.PerformClick();
        }

        private void gridStoklar_DoubleClick(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                
                    string stokKodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.FirstOrDefault(c => c.StokKodu == stokKodu));
                }

                secildi = true;
                this.Close();
            }
        }

        private void gridStoklar_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                var p2 = MousePosition;
                popupMenu1.ShowPopup(p2);
            }
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridStoklar.RowCount != 0)
                {
                    //burdaki context ile düzenleme yapsa dahi context yenilenmediği için fisislem veya başka bir yere stok eklemek istediğinde eski context ile stok ekleme işlemi yapmaya çalışıyor haliyle eski düzenlenmemiş veriyi çekecektir.
                    //ancak fisislem formu kapatılıp yeniden açılması gerekiyor. düzenle işlemini burdan yapması sağlı değil!
                    sec = Convert.ToInt32(gridStoklar.GetFocusedRowCellValue(colId));
                    var r = context.Stoklar.Include("Barkod").AsNoTracking().FirstOrDefault(x => x.Id == sec);
                    frmStokIslem form = new frmStokIslem(ref context, r);
                    form.ShowDialog();

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

        private void btnKopyala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridStoklar.RowCount != 0)
            {
                sec = Convert.ToInt32(gridStoklar.GetFocusedRowCellValue(colId));
                Entities.Tables.Stok stokEntity = new Entities.Tables.Stok();
                var r = context.Stoklar.Include("Barkod").FirstOrDefault(x => x.Id == sec);
                frmStokIslem form = new frmStokIslem(r, true);
                form.ShowDialog();
                if (form.saved)
                {
                    #region eski kod
                    //TumStoklar = stokDal.StokSec(context);
                    //OnPropertyChanged(nameof(TumStoklar)); 
                    #endregion
                    btnSorgula.PerformClick();
                }

            }
            else
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }

        private void btnStokEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokIslem form = new frmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnSorgula.PerformClick();

            #region eski kodlar
            //TumStoklar = stokDal.StokSec(context);
            //OnPropertyChanged(nameof(TumStoklar)); 
            #endregion
        }

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridStoklar.RowCount != 0)
            {
                sec = Convert.ToInt32(gridStoklar.GetFocusedRowCellValue(colId));
                frmStokHareket form = new frmStokHareket(sec); form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }

        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        async Task Sorgula(CancellationToken token)
        {

            if (token.IsCancellationRequested)
                return;
            TumStoklar.Clear();

            OnPropertyChanged(nameof(TumStoklar));
            gridStoklar.RefreshData();
            var pred = PredicateBuilder.True<Entities.Tables.Stok>();

            if (!string.IsNullOrEmpty(txtStokKodu.Text))
                pred = pred.And(x => x.StokKodu.Contains(txtStokKodu.Text));
            if (!string.IsNullOrEmpty(txtStokAdi.Text))
                pred = pred.And(x => x.StokAdi.Contains(txtStokAdi.Text));
            if (!string.IsNullOrEmpty(txtAramaMetni.Text))
            {
                foreach (string item in txtAramaMetni.Text.Split(' '))
                {
                    if (!string.IsNullOrEmpty(item))
                        pred = pred.And(x => x.StokAdi.Contains(item) || x.Barkod.Any(s => s.Barkodu.Contains(item)) || x.Barkodu.Contains(item) || x.StokKodu.Contains(item));
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
                gridStoklar.RefreshData();
                lblKayitSayisi.Text = TumStoklar.Count.ToString();
            }
        }

        private async void btnSorgula_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();
            tokenSource = new CancellationTokenSource();
            await Sorgula(tokenSource.Token);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            tokenSource.Cancel();
            tokenSource.Dispose();

            base.OnFormClosing(e);

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAramaMetni.Text =
                txtStokAdi.Text =
                txtStokKodu.Text = null;

            txtAramaMetni.Focus();
        }

        private void txtFilterClear(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var obj = sender as ButtonEdit;
            if (obj == null)
                return;
            obj.Text = null;
        }

        private void gridStoklar_ColumnFilterChanged(object sender, EventArgs e)
        {
            if (gridStoklar.FocusedColumn.FilterInfo.Value != null)
            {
                string filter = gridStoklar.FocusedColumn.FilterInfo.Value.ToString();
                filter = filter.Replace(' ', '%');
                if (filter[filter.Length - 1] != '%')
                {
                    filter += '%';
                }
                if (filter[0] != '%')
                {
                    filter = '%' + filter;
                }
                gridStoklar.FocusedColumn.FilterInfo = new ColumnFilterInfo("[" + gridStoklar.FocusedColumn.FieldName + "] LIKE '" + filter + "'");
            }
        }

        private void btnDizaynKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Directory.Exists($@"{Application.StartupPath}\Gorunum"))
                gridContStoklar.MainView.SaveLayoutToXml(DosyaYolu);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}