using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using NetSatis.Entities.Tools;
using NetSatisAdmin;
using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace NetSatis.BackOffice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {



            bool prog;
            Mutex mtx = new Mutex(true, "NetSatis.BackOffice", out prog);
            if (!prog)
            {
                MessageBox.Show("Bu program zaten çalışıyor.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            GC.KeepAlive(mtx);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR"); Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            BonusSkins.Register();
            SkinManager.EnableFormSkins();


#if DEBUG
            if (new frmKullaniciGiris().ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmAnaMenu());
                return;
            }
#endif


            Form ilkForm = new frmLisansGirisi();


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
                        if (new frmKullaniciGiris().ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new frmAnaMenu());
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Lisans Pasif Durumda");
                    }
                }
                catch (Exception)
                {
                    if (NetSatisAdmin.Properties.Settings.Default.Lisans != 1)
                    {
                        Application.Run(new frmOflineLisans());
                    }
                    else
                    {

                        if (new frmKullaniciGiris().ShowDialog() == DialogResult.OK)
                        {
                            Application.Run(new frmAnaMenu());
                        }
                        else
                        {
                            Application.Exit();
                        }
                        //frmKullaniciGiris frm = new frmKullaniciGiris();
                        //frm.ShowDialog();
                        //Application.Run(new frmAnaMenu());
                    }
                }


            }





            //if (new frmKullaniciGiris().ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frmAnaMenu());
            //}
            //else
            //{
            //    Application.Exit();
            //}

        }
    }
}
