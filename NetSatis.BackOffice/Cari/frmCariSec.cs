using DevExpress.XtraGrid;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariSec : Form
    {
        CariDAL cariDal = new CariDAL();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.Cari> secilen = new List<Entities.Tables.Cari>();
        public bool secildi = false;

        private int sec;
        string DosyaYolu = $@"{Application.StartupPath}\Gorunum\CariSecSavedLayout.xml";
        public frmCariSec(bool cokluSecim = false)
        {
            InitializeComponent();
            if (cokluSecim)
            {
                lblUyari.Visible = true;
                gridView1.OptionsSelection.MultiSelect = true;

            }

            gridControl1.DataSource = cariDal.GetCariler(context);
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                    secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));

                }

                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Cari Seçimi Yapılmadı");
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCariSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                btnKapat.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnSec.PerformClick();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.FocusedRowHandle != GridControl.InvalidRowHandle)
                    if (gridView1.GetSelectedRows().Length != 0)
                    {
                        foreach (var row in gridView1.GetSelectedRows())
                        {
                            string carikodu = gridView1.GetRowCellValue(row, colCariKodu).ToString();
                            secilen.Add(context.Cariler.SingleOrDefault(c => c.CariKodu == carikodu));

                        }

                        secildi = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cari Seçimi Yapılmadı");
                    }
            }
            catch (Exception)
            {

                throw;
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

        private void btnHareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {
                    sec = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId)); string secilenAd = gridView1.GetFocusedRowCellValue(colCariAdi).ToString();
                    frmCariHareket form = new frmCariHareket(Convert.ToInt32(sec));
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seçili Cari Bulunamadı");
                }
            }
            catch (Exception)
            {

                throw;
            }
         
        }

        private void frmCariSec_Load(object sender, EventArgs e)
        {
            if (File.Exists(DosyaYolu)) gridControl1.MainView.RestoreLayoutFromXml(DosyaYolu);
        }

        private void brnCariDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridView1.RowCount != 0)
                {

                    sec = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                    frmCariIslem form = new frmCariIslem(cariDal.GetByFilter(context, c => c.Id == sec));
                    form.ShowDialog();
                    if (form.saved)
                    {
                        gridControl1.DataSource = cariDal.GetCariler(context);
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView1.ClearColumnsFilter();
            if (Directory.Exists($@"{Application.StartupPath}\Gorunum\"))
                gridControl1.MainView.SaveLayoutToXml(DosyaYolu);
        }
    }
}

