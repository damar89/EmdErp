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

namespace NetSatisAdmin
{
    public partial class frmOflineLisans : DevExpress.XtraEditors.XtraForm
    {
     
        public frmOflineLisans()
        {
            InitializeComponent();
        }

        private void frmOflineLisans_Load(object sender, EventArgs e)
        {
            EmdSoft.Api.ApiControl api = new EmdSoft.Api.ApiControl();
            textEdit1.Text = api.OfflineLisans();
            labelControl1.Text = api.Lisans(textEdit1.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            EmdSoft.Api.ApiControl api = new EmdSoft.Api.ApiControl();
            var LicKey = api.Lisans(textEdit1.Text);
            var AcKey = textEdit2.Text.Replace(" ", "");
            //labelControl1.Text=Convert.ToString(LicKey);
            if (LicKey == AcKey)
            {
                Properties.Settings.Default.Lisans = 1;
                Properties.Settings.Default.Save();
                Application.Exit();
            }
            else
            {
                XtraMessageBox.Show("Offline Lisans Hatası");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
               EmdSoft.Api.ApiControl api = new EmdSoft.Api.ApiControl();
            //textEdit1.Text = api.OfflineLisans();
            labelControl1.Text = api.Lisans(textEdit1.Text);
        }
    }
}