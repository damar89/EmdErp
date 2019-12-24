using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
namespace NetSatis.BackOffice.Cari
{
    public partial class frmCariBakiye : DevExpress.XtraEditors.XtraForm
    {
        private NetSatisContext context = new NetSatisContext();
        private CariDAL cariDal = new CariDAL();
        private Nullable<int> secilen = null;
        FisDAL fisDal = new FisDAL();
        public frmCariBakiye()
        {
            InitializeComponent();
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetAll()
        {
            gridControl1.DataSource = cariDal.GetCariler(context);
        }
        private void frmCariBakiye_Load(object sender, EventArgs e)
        {
            GetAll();
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
            secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmCariIslem form = new frmCariIslem(cariDal.GetByFilter(context, c => c.Id == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }
        private void btnCariEkstre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        private void frmCariBakiye_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnKapat.PerformClick();
            }
        }
    }
}