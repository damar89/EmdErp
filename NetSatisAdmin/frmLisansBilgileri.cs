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
using FoxLearn.License;

namespace NetSatisAdmin
{
    public partial class frmLisansBilgileri : DevExpress.XtraEditors.XtraForm
    {
        public frmLisansBilgileri()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        const int ProductCode = 1;
        private void frmLisansBilgileri_Load(object sender, EventArgs e)
        {
            lblProductID.Text = ComputerInfo.GetComputerId();
            KeyManager km = new KeyManager(lblProductID.Text);
            LicenseInfo lic = new LicenseInfo();
            int value = km.LoadSuretyFile(string.Format(@"{0}\key.lic", Application.StartupPath), ref lic);
            string productKey = lic.ProductKey;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    lblProductName.Text = "EmdSfot";
                    lblProductKey.Text = productKey;
                    if (kv.Type == LicenseType.TRIAL)
                        lblLicenceType.Text = string.Format("{0} gün", (kv.Expiration - DateTime.Now.Date).Days);
                    else
                        lblLicenceType.Text = "Full";





                }
            }

        }
    }
}