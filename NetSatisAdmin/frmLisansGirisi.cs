using System;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;

namespace NetSatisAdmin
{
    public partial class frmLisansGirisi : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        public frmLisansGirisi()
        {
            InitializeComponent();
            txtLisansKey.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.Lisans_LisansKey);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Lisans_LisansKey, txtLisansKey.Text);
            SettingsTool.Save();
            //Properties.Settings.Default.Lisans = txtLisansKey.Text;
            //Properties.Settings.Default.Save();


            this.Close();

        }
    }
}