using DevExpress.XtraReports.UI;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatis.Reports.Stok
{
    public class Envanter
    {
        public void EnvanterHazirla()
        {
            NetSatisContext context = new NetSatisContext();
            StokHareketDAL stokHareketDal = new StokHareketDAL();
            DataSet gelen = stokHareketDal.StokEnvanterListele(context);

            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    rptStokEnvanter rpt = new rptStokEnvanter();
                    rpt.LoadLayout(OFD.FileName);
                    rpt.DataSource = gelen;
                    rpt.DataMember = "EnvanterBilgileri";
                    rpt.ShowPreview();  
                }
            }
        }
    }
}
