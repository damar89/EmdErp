using FoxLearn.License;
using System;

namespace NetSatisAdmin
{
    public partial class frmGenerate : DevExpress.XtraEditors.XtraForm
    {
        public frmGenerate()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtProductID.Text);
            KeyValuesClass kv;
            string productKey = string.Empty;
            if (cboLicenseType.SelectedIndex == 0)
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.FULL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1
                };
                if (!km.GenerateKey(kv, ref productKey))
                    txtProductKey.Text = "ERROR";
            }
            else
            {
                kv = new KeyValuesClass()
                {
                    Type = LicenseType.TRIAL,
                    Header = Convert.ToByte(9),
                    Footer = Convert.ToByte(6),
                    ProductCode = (byte)ProductCode,
                    Edition = Edition.ENTERPRISE,
                    Version = 1,
                    Expiration = DateTime.Now.Date.AddDays(Convert.ToInt32(txtExperience.Text))
                };
                if (!km.GenerateKey(kv, ref productKey))
                    txtProductKey.Text = "ERROR";
            }
            txtProductKey.Text = productKey;
        }
        const int ProductCode = 1;
        private void frmGenerate_Load(object sender, EventArgs e)
        {
            cboLicenseType.SelectedIndex = 0;
            txtProductID.Text = ComputerInfo.GetComputerId();
        }
    }
}