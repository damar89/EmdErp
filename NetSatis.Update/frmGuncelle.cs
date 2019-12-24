using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NetSatis.Update
{

    public partial class frmGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();
        public static bool IsRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;

        }
        public frmGuncelleme()
        {
            
            InitializeComponent();

            if (IsRunning("NetSatis.BackOffice"))
            {
                if(MessageBox.Show("Güncelleme işleminden önce açık olan uygulamanızın kapatılması gerekiyor. Onaylıyor musunuz ?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
               {
                    foreach (var process in Process.GetProcessesByName("NetSatis.BackOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }

            }
            if (IsRunning("NetSatis.FrontOffice"))
            {
                if(MessageBox.Show("Güncelleme işleminden önce açık olan uygulamanızın kapatılması gerekiyor. Onaylıyor musunuz ?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    foreach (var process in Process.GetProcessesByName("NetSatis.FrontOffice"))
                    {
                        process.CloseMainWindow();
                        process.Kill();
                    }
                }

            }
        }

        private void frmGuncelleme_Load(object sender, EventArgs e)
        {

        }

        private void btnGuncellemeyiIndir_Click(object sender, EventArgs e)
        {
            indir.DownloadProgressChanged += (DownloadProgressChangedEventHandler)IndirmeDurumu;
            indir.DownloadFileCompleted += (AsyncCompletedEventHandler)IndirmeBitti;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            indir.DownloadFileAsync(new Uri("https://emdyazilim.com/downloads/Update.zip"), Application.StartupPath + "\\temp\\Update.zip");
            //IndirmeBitti(null,null); 
        }

        private void IndirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            
            if (!Directory.Exists(Application.StartupPath + "\\temp"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\temp");
            }
            ZipFile.ExtractToDirectory(Application.StartupPath + "\\temp\\Update.zip", Application.StartupPath + "\\temp");
            //XElement Dosyalar = XElement.Load(Application.StartupPath + "\\temp\\Liste.xml");

            DirectoryInfo d = new DirectoryInfo(Application.StartupPath +"\\temp\\");
            FileInfo[] Files = d.GetFiles(); 

            foreach (var veriler in Files)
            {
                if (veriler.Name == "Update.zip")
                {
                    continue;
                }

                if (File.Exists(Application.StartupPath+"\\"+veriler.Name))
                {
                File.Delete(Application.StartupPath + "\\" + veriler.Name);    
                }
                File.Copy(Application.StartupPath + "\\temp\\"+veriler.Name ,Application.StartupPath + "\\" + veriler.Name);
               
            }
            Directory.Delete(Application.StartupPath + "\\temp",true);
            MessageBox.Show("Güncelleme Tamamlandı.");
        }


        public void IndirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            progressFile.Properties.Maximum = (int)e.TotalBytesToReceive;
            progressFile.Text = Convert.ToString(e.BytesReceived);
            lblIndirilen.Text = $"{(Convert.ToDecimal(e.BytesReceived) / 1024 / 1024).ToString("N2")}. MB\\{(Convert.ToDecimal(e.TotalBytesToReceive) / 1024 / 1024).ToString("N2")} MB";
        }
    }
}
