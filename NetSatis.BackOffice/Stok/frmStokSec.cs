using DevExpress.XtraEditors;
using NetSatis.Entities;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        NetSatisContext context;
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool secildi = false;
        private int sec;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\StokSec_SavedLayout.xml";


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

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string stokKodu = gridStoklar.GetRowCellValue(row, colStokKodu).ToString();
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokKodu));
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

        private void frmStokSec_Load(object sender, EventArgs e)
        {

            Sorgula();

            if (File.Exists(DosyaYolu)) gridContStoklar.MainView.RestoreLayoutFromXml(DosyaYolu);


            gridContStoklar.Select();
        }

        private void frmStokSec_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (!e.Alt && e.KeyCode == Keys.Enter)
                gridStoklar_DoubleClick(null, null);

            if (e.Alt && e.KeyCode == Keys.Y)
                btnStokEkle.PerformClick();

            if (e.Alt && e.KeyCode == Keys.D)
                btnDuzenle.PerformClick();

            if (e.Alt && e.KeyCode == Keys.C)
                btnKopyala.PerformClick();
            if (e.Alt && e.KeyCode == Keys.H)
                btnHareketler.PerformClick();

            if (e.KeyCode == Keys.F4)
                Sorgula();
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
                    secilen.Add(context.Stoklar.SingleOrDefault(c => c.StokKodu == stokKodu));
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
                    sec = Convert.ToInt32(gridStoklar.GetFocusedRowCellValue(colId));
                    var r = context.Stoklar.Include("Barkod").FirstOrDefault(x => x.Id == sec);
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
                    gridContStoklar.DataSource = stokDal.StokSec(context);
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
            gridContStoklar.DataSource = stokDal.StokSec(context);
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

        private void frmStokSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Directory.Exists($@"{Application.StartupPath}\Gorunum"))
                gridContStoklar.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void gridStoklar_RowCountChanged(object sender, EventArgs e)
        {
            int kayitsayisi; // kayıt sayısını tutacak değişkenimiz
            kayitsayisi = Convert.ToInt32(gridStoklar.RowCount);
            lblKayitSayisi.Text = kayitsayisi.ToString();
        }

        void Sorgula()
        {
            var pred = PredicateBuilder.True<Entities.Tables.Stok>();

            if (!string.IsNullOrEmpty(txtStokKodu.Text))
            {
                pred = pred.And(x => x.StokKodu.Contains(txtStokKodu.Text));
            }
            if (!string.IsNullOrEmpty(txtStokAdi.Text))
            {
                pred = pred.And(x => x.StokAdi.Contains(txtStokAdi.Text));
            }
            if (!string.IsNullOrEmpty(txtAramaMetni.Text))
            {
                foreach (string item in txtAramaMetni.Text.Split(' '))
                {
                    if (!string.IsNullOrEmpty(item))
                        pred = pred.And(x => x.StokAdi.Contains(item) || x.Barkodu.Contains(item) || x.StokKodu.Contains(item));
                }

            }
            gridContStoklar.DataSource = stokDal.StokAdiylaStokGetir(context, pred);

            gridContStoklar.ForceInitialize();
            gridContStoklar.Select();

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            Sorgula();
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
    }
}