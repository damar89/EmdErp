using NetSatis.Entities.Tables.OtherTables;
using System;
using System.Collections.Generic;

namespace NetSatis.BackOffice.İndirim
{
    public partial class frmTopluOran : DevExpress.XtraEditors.XtraForm
    {
        
        public List<TopluIskonto> list;
        public bool secildi=false;

        public frmTopluOran()
        {
            InitializeComponent();
            list = new List<TopluIskonto>
            {
                new TopluIskonto
                {
                  
                    KolonAdi = "IndirimOrani",
                    Degeri = 0

                },
            };
            gridControl1.DataSource = list;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            secildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}