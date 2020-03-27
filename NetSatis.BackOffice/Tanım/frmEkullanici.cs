using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;

namespace NetSatis.BackOffice.Tanım
{
    public partial class frmEkullanici : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        EkullaniciBilgileriDAL ekullaniciBilgileriDAL = new EkullaniciBilgileriDAL();
        public frmEkullanici()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmEkullanici_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = ekullaniciBilgileriDAL.StokListele(context);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            frmEkullaniciIslem form = new frmEkullaniciIslem(new Entities.Tables.eKullaniciBilgileri());
            form.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                frmEkullaniciIslem form = new frmEkullaniciIslem(ekullaniciBilgileriDAL.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}