using DevExpress.XtraReports.UI;
using DevExpress.XtraWizard;
using NetSatis.BackOffice.Stok;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmEtiketOlustur : DevExpress.XtraEditors.XtraForm
    {
        private XtraReport rapor = new XtraReport();
        NetSatisContext context = new NetSatisContext();
        BarkodEtiketDAL barkodEtiketDal = new BarkodEtiketDAL();
        List<Entities.Tables.Stok> stokEntity = new List<Entities.Tables.Stok>();
        public frmEtiketOlustur()
        {
            InitializeComponent();
            gridControl1.DataSource = stokEntity;
            gridControl1.DataSource = context.BarkodEtiketOlustur.Local.ToBindingList();

        }

        private int mmToPixel(int mm)
        {
            return Convert.ToInt32(mm * 3.7795275591);
             
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            //rapor.DataSource = stokEntity;
            //rapor.ReportUnit = ReportUnit.TenthsOfAMillimeter;
            //rapor.Height = mmToPixel(Convert.ToInt32(txtMarginDikey.Value));
            //rapor.Width = mmToPixel(Convert.ToInt32(txtMarginYatay.Value));
            //rapor.Margins.Top = mmToPixel(Convert.ToInt32(txtMarginUst.Value));
            //rapor.Margins.Bottom = mmToPixel(Convert.ToInt32(txtMarginAlt.Value));
            //rapor.Margins.Left = mmToPixel(Convert.ToInt32(txtMarginSol.Value));
            //rapor.Margins.Right = mmToPixel(Convert.ToInt32(txtMarginSag.Value));
            //rapor.RollPaper = checkRulo.Checked;

            //DetailBand detail = new DetailBand();
            //detail.MultiColumn.Layout = ColumnLayout.AcrossThenDown;
            //detail.MultiColumn.Mode = MultiColumnMode.UseColumnWidth;
            //detail.MultiColumn.ColumnWidth = mmToPixel(Convert.ToInt32(txtUzunluk.Value));
            //detail.Height = mmToPixel(Convert.ToInt32(txtGenislik.Value));
            //detail.MultiColumn.ColumnSpacing = Convert.ToInt32(txtAraBosluk.Value);

            //rapor.Bands.Add(detail);
            //frmRaporDuzenle form = new frmRaporDuzenle(rapor);
            //form.WindowState = FormWindowState.Maximized;
            //form.Show();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            frmStokSec form = new frmStokSec(true);
            form.ShowDialog();
            if (form.secildi)
            {
                foreach (var itemStok in form.secilen)
                {
                    stokEntity.Add(itemStok);
                }
            }
            gridView1.RefreshData();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
            gridView1.RefreshData();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == completionWizardPage1 && e.Direction == Direction.Forward && gridView1.RowCount == 0)
            {
                MessageBox.Show("Listeye Ürün Eklenmedi");
                e.Cancel = true;
            }
        }

        private void wizardControl1_Click(object sender, EventArgs e)
        {

        }
    }
}