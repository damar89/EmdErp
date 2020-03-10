using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Masraf
{
    public partial class frmMasrafSec : DevExpress.XtraEditors.XtraForm
    {
        MasrafDAL masrafDal = new MasrafDAL();
        NetSatisContext context = new NetSatisContext();
        public List<Entities.Tables.Masraf> secilen = new List<Entities.Tables.Masraf>();
        public bool secildi = false;

        public frmMasrafSec()
        {
            InitializeComponent();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if(gridStoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string masrafKodu = gridStoklar.GetRowCellValue(row, colMasrafKodu).ToString();
                    secilen.Add(context.Masraflar.SingleOrDefault(c => c.MasrafKodu == masrafKodu));
                }

                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen bir ürün bulunamadı");
            }
        }

        private void frmMasrafSec_Load(object sender, EventArgs e)
        {
            gridContStoklar.DataSource = masrafDal.GetAll(context);
        }

        private void gridStoklar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }
        }

        private void gridStoklar_DoubleClick(object sender, EventArgs e)
        {
            if (gridStoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridStoklar.GetSelectedRows())
                {
                    string masrafKodu = gridStoklar.GetRowCellValue(row, colMasrafKodu).ToString();
                    secilen.Add(context.Masraflar.SingleOrDefault(c => c.MasrafKodu == masrafKodu));
                }

                secildi = true;
                this.Close();
            }
        }
    }
}