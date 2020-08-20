using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NetSatis.Entities.Tools;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetSatisAdmin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
            {
                SkinManager.DisableFormSkins();
                SkinManager.DisableMdiFormSkins();
                Application.VisualStyleState = VisualStyleState.NoneEnabled;

                UserLookAndFeel.Default.UseWindowsXPTheme = false;
                UserLookAndFeel.Default.Style = LookAndFeelStyle.Flat;

                WindowsFormsSettings.AnimationMode = AnimationMode.DisableAll;
                WindowsFormsSettings.AllowHoverAnimation = DevExpress.Utils.DefaultBoolean.False;

            
                BarAndDockingController.Default.PropertiesBar.SubmenuHasShadow = false;
                BarAndDockingController.Default.PropertiesBar.AllowLinkLighting = false;
                //Properties.Settings.Default.Lisans=0;
                //Properties.Settings.Default.Save();
                Form ilkForm = new frmLisansGirisi();
            }

            //Properties.Settings.Default.Lisans = "";
            Properties.Settings.Default.Save();
            var d = SettingsTool.AyarOku(SettingsTool.Ayarlar.Lisans_LisansKey);
            if (SettingsTool.AyarOku(SettingsTool.Ayarlar.Lisans_LisansKey) == null && SettingsTool.AyarOku(SettingsTool.Ayarlar.Lisans_LisansKey) != "")
            {
                frmLisansGirisi ns = new frmLisansGirisi();
                ns.ShowDialog();

            }
            else
            {
                try
                {
                    string Key = SettingsTool.AyarOku(SettingsTool.Ayarlar.Lisans_LisansKey);
                    string url = "https://emdsoftlisans.com/api/LisansGenerator/" + Key;
                    var request = (HttpWebRequest)WebRequest.Create(url);
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    bool IsActive = Convert.ToBoolean(responseString);
                    if (IsActive == true)
                    {
                        frmKullaniciGiris frm = new frmKullaniciGiris();
                        frm.ShowDialog();
                    }
                    else
                    {
                        XtraMessageBox.Show("Lisans Pasif Durumda");
                    }
                }
                catch (Exception)
                {
                    if (Properties.Settings.Default.Lisans != 1)
                    {
                        Application.Run(new frmOflineLisans());
                    }
                    else
                    {
                        frmKullaniciGiris frm = new frmKullaniciGiris();
                        frm.ShowDialog();
                    }
                }


            }

            //Application.Run(ilkForm);

        }
    }
}
