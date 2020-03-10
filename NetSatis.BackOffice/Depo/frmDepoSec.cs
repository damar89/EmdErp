using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Depo
{
    public partial class frmDepoSec : Form
    {
        NetSatisContext context = new NetSatisContext();
        DepoDAL depoDal = new DepoDAL();
        private int _stokId;
        public Entities.Tables.Depo entity = new Entities.Tables.Depo();
        public bool secildi = false;
        public frmDepoSec(int stokId)
        {
            InitializeComponent();
            _stokId = stokId;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDepoSec_Load(object sender, EventArgs e)
        {
            gridContDepolar.DataSource = depoDal.DepoBazindaStokListele(context, _stokId);

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridDepolar.SelectedRowsCount != 0)
            {
                string depoKodu = gridDepolar.GetFocusedRowCellValue(colDepoKodu).ToString();
                entity = context.Depolar.SingleOrDefault(c => c.DepoKodu == depoKodu);
                secildi = true;
                this.Close();
            }

        }

        private void frmDepoSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                btnKapat.PerformClick();
            }
        }
    }
}
