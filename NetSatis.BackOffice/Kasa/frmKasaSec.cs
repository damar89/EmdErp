using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.BackOffice.Kasa
{
    public partial class frmKasaSec : Form
    {
        KasaDAL kasaDal=new KasaDAL();
        NetSatisContext context=new NetSatisContext();
        public Entities.Tables.Kasa entity=new Entities.Tables.Kasa();
        public bool secildi = false;

        public frmKasaSec()
        {
            InitializeComponent();

        }

        private void frmKasaSec_Load(object sender, EventArgs e)
        {
            gridContSecim.DataSource = kasaDal.KasaListele(context);

        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (gridSecim.GetSelectedRows().Length !=0)
            {
              string kasakodu = gridSecim.GetFocusedRowCellValue(colKasaKodu).ToString();
           entity= context.Kasalar.SingleOrDefault(c=>c.KasaKodu==kasakodu);
            secildi = true;
            this.Close();   
            }
           
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKasaSec_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Escape )
            {

                this.Close();
            }
        }
    }
}
