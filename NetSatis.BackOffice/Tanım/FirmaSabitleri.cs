using System;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Tanım
{
    public partial class FirmaSabitleri : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FirmaSabitDAL firmasabitDal = new FirmaSabitDAL();
        public FirmaSabitleri()
        {
            InitializeComponent();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FirmaSabitleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = firmasabitDal.GetAll(context);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            FirmaSabitIslem form = new FirmaSabitIslem(new Entities.Tables.FirmaSabitleri());
            form.ShowDialog();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                FirmaSabitIslem form = new FirmaSabitIslem(firmasabitDal.GetByFilter(context, c => c.Id == secilen));
                form.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}