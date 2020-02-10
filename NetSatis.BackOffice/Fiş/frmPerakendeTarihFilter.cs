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
using NetSatis.BackOffice.Fiş;
using NetSatis.Entities.Data_Access;
using NetSatis.BackOffice.Stok_Hareketleri;
using DevExpress.XtraEditors.Mask;
using NetSatis.Entities.Context;

namespace NetSatis.BackOffice.Raporlar
{
    public partial class frmPerakendeTarihFilter : DevExpress.XtraEditors.XtraForm
    {
        FisDAL fisDal = new FisDAL();
        StokHareketDAL stokHareketDal = new StokHareketDAL();
        KategoriDAL kategoriDal = new KategoriDAL();
        AnaGrupDAL anagrupDal = new AnaGrupDAL();
        AltGrupDAL altgrupDal = new AltGrupDAL();
        StokDAL stokDal = new StokDAL();
        NetSatisContext context = new NetSatisContext();
        int user = 0;
        public frmPerakendeTarihFilter(int userId = 0)
        {
            user = userId;
            InitializeComponent();

            dtpBaslangic.DateTime = new DateTime(DateTime.Now.Year, 1, 1, 00, 00, 00);
            dtpBitis.DateTime = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            dtpBaslangic.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            dtpBitis.Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime dtBaslangic = dtpBaslangic.DateTime;
            DateTime dtBitis = dtpBitis.DateTime;
            dtBitis = dtBitis.AddHours(23).AddMinutes(59).AddSeconds(59);
            frmSatisRapor form = new frmSatisRapor(dtBaslangic, dtBitis,user);
            form.Show();
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     private void dtpBaslangic_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                 dtpBaslangic.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day , 0,0,0);
            }
        }

        private void dtpBitis_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
            if (e.Button.Index == 1)
            {

                dtpBitis.EditValue = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day , 23,59,59);
            }
        }
    }
}