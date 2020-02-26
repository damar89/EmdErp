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
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmGunSonuRapor : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        FisDAL fisDal = new FisDAL();
        KasaHareketDAL kasaHareketDal = new KasaHareketDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        public frmGunSonuRapor(DateTime baslangic, DateTime bitis, int userId = 0)
        {
            InitializeComponent();
            gridControl1.DataSource = fisDal.GunSonu(context, baslangic, bitis);
        }
    }
}