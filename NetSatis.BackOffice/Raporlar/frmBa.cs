using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmBa : DevExpress.XtraEditors.XtraForm
    {

        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();

        public frmBa()
        {
            InitializeComponent();
            var combx = eislem.HareketTipiListele();

            foreach (var i in combx)
            {
                cmbTipi.Properties.Items.Add(i.Aciklama);
            }
            cmbAy.Month = DateTime.Now.Month;
            for (int i = DateTime.Now.Year - 2; i <= DateTime.Now.Year + 2; i++)
            {
                cmbYil.Properties.Items.Add(i);
            }
            cmbYil.Text = DateTime.Now.Year.ToString();
        }
    }
}