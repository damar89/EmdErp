using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Columns;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Stok
{
    public partial class frmStokSec : DevExpress.XtraEditors.XtraForm
    {
        StokDAL stokDal = new StokDAL();
        NetSatisContext context;
        public List<Entities.Tables.Stok> secilen = new List<Entities.Tables.Stok>();
        public bool secildi = false;
        private int sec;
        string aramaMetni = "";
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

        public frmStokSec(ref NetSatisContext _context, string aramaMetni)
        {
            InitializeComponent();
            this.context = _context;
            this.aramaMetni = aramaMetni;
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

            if (aramaMetni != "")
            {
                gridContStoklar.DataSource = stokDal.StokAdiylaStokGetir(context, aramaMetni);

            }
            else
            {
                gridContStoklar.DataSource = stokDal.StokListele(context, true);
            }

            gridContStoklar.ForceInitialize();


            if (File.Exists(DosyaYolu)) gridContStoklar.MainView.RestoreLayoutFromXml(DosyaYolu);



        }

        private void frmStokSec_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
            try
            {
                if (e.KeyCode == Keys.Enter)
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
            }
            catch (Exception)
            {

                throw;
            }


            if (e.Alt == true && e.KeyCode == Keys.Y)
            {
                btnStokEkle.PerformClick();
            }

            if (e.Alt == true && e.KeyCode == Keys.D)
            {
                btnDuzenle.PerformClick();
            }

            if (e.KeyCode == Keys.F5)
            {
                btnGuncelle.PerformClick();
            }

            if (e.Alt == true && e.KeyCode == Keys.C)
            {
                btnKopyala.PerformClick();
            }
            if (e.Alt == true && e.KeyCode == Keys.H)
            {
                btnHareketler.PerformClick();
            }
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
                    frmStokIslem form = new frmStokIslem(stokDal.GetByFilter(context, c => c.Id == sec));
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
                stokEntity = stokDal.GetByFilter(context, c => c.Id == sec);
                frmStokIslem form = new frmStokIslem(stokEntity, true);
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
                string secilenAd = gridStoklar.GetFocusedRowCellValue(colId).ToString();
                frmStokHareket form = new frmStokHareket(sec); form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seçili Stok Bulunamadı");
            }
        }

        private void frmStokSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            gridStoklar.ClearColumnsFilter();
            gridContStoklar.MainView.SaveLayoutToXml(DosyaYolu);
        }

        private void gridStoklar_RowCountChanged(object sender, EventArgs e)
        {
            int kayitsayisi; // kayıt sayısını tutacak değişkenimiz
            kayitsayisi = Convert.ToInt32(gridStoklar.RowCount);
            lblKayitSayisi.Text = kayitsayisi.ToString();
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
        private void txtStokAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gridStoklar.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokAdi"), new OperandValue(filtreyeCevir(txtStokAdi.Text)), BinaryOperatorType.Like);
            }
        }

        private void txtStokKodu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                gridStoklar.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokKodu"), new OperandValue(filtreyeCevir(txtStokKodu.Text)), BinaryOperatorType.Like);
            }
        }

        private void txtStokAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridStoklar.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokAdi"), new OperandValue(filtreyeCevir(txtStokAdi.Text)), BinaryOperatorType.Like);
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridStoklar.ActiveFilterCriteria = new BinaryOperator(new OperandProperty("StokKodu"), new OperandValue(filtreyeCevir(txtStokKodu.Text)), BinaryOperatorType.Like);
        }
    }
}