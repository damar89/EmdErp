using FoxLearn.License;
using System;
using System.Windows.Forms;

namespace NetSatisAdmin
{
    public partial class frmRegistration : DevExpress.XtraEditors.XtraForm
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        const int ProductCode = 1;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KeyManager km = new KeyManager(txtProductID.Text);
            string productKey = txtProductKey.Text;
            if (km.ValidKey(ref productKey))
            {
                KeyValuesClass kv = new KeyValuesClass();
                if (km.DisassembleKey(productKey, ref kv))
                {
                    LicenseInfo lic = new LicenseInfo();
                    lic.ProductKey = productKey;
                    lic.FullName = "EmdSoft";
                    if (kv.Type == LicenseType.TRIAL)
                    {
                        lic.Day = kv.Expiration.Day;
                        lic.Month = kv.Expiration.Month;
                        lic.Year = kv.Expiration.Year;
                    }

               
                    km.SaveSuretyFile(string.Format(@"{0}\Key.lic", Application.StartupPath), lic);
                    MessageBox.Show("Etkinleştirme işlemi gerçekleştirildi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
               
            }
            else
                MessageBox.Show("Ürün anahtarı geçersiz.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            txtProductID.Text = ComputerInfo.GetComputerId();
        }
    }
}