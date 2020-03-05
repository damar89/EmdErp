using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Windows.Forms;

namespace NetSatis.Update
{

    public partial class frmGuncelleme : DevExpress.XtraEditors.XtraForm
    {
        WebClient indir = new WebClient();
        string startupPath;
        string tempPath;
        string updateFile;
        public static bool IsRunning(string ProgramAdi)
        {
            return Process.GetProcessesByName(ProgramAdi).Length > 0;

        }
        public frmGuncelleme()
        {
            try
            {

                InitializeComponent();

                startupPath = Application.StartupPath;
                tempPath = Path.Combine(startupPath, "temp");
                updateFile = tempPath + "\\Update.zip";

                if (!Directory.Exists(tempPath))
                    Directory.CreateDirectory(tempPath);
                else
                {
                    Directory.Delete(tempPath, true);
                    Directory.CreateDirectory(tempPath);
                }


                if (IsRunning("NetSatis.BackOffice"))
                {
                    if (MessageBox.Show("Güncelleme işleminden önce açık olan uygulamanızın kapatılması gerekiyor. Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    if (MessageBox.Show("Güncelleme işleminden önce açık olan uygulamanızın kapatılması gerekiyor. Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        foreach (var process in Process.GetProcessesByName("NetSatis.FrontOffice"))
                        {
                            process.CloseMainWindow();
                            process.Kill();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncellemeyiIndir_Click(object sender, EventArgs e)
        {
            indir.DownloadProgressChanged += (DownloadProgressChangedEventHandler)IndirmeDurumu;
            indir.DownloadFileCompleted += (AsyncCompletedEventHandler)IndirmeBitti;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            indir.DownloadFileAsync(new Uri("https://emdyazilim.com/downloads/Update.zip"), updateFile);
        }

        private void IndirmeBitti(object sender, AsyncCompletedEventArgs e)
        {
            try
            {



                if (!File.Exists(updateFile))
                {
                    MessageBox.Show("Güncelleme dosyası bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ZipFile.ExtractToDirectory(updateFile, tempPath);

                var d = new DirectoryInfo(tempPath);
                var Files = d.GetFiles();

                foreach (var veriler in Files)
                {
                    if (veriler.Name == "Update.zip")
                        continue;
                    string startupFileName = startupPath + "\\" + veriler.Name;
                    if (File.Exists(startupFileName))
                        File.Delete(startupFileName);

                    File.Copy(tempPath + "\\" + veriler.Name, startupFileName, true);

                }
                Directory.Delete(tempPath, true);
                MessageBox.Show("Güncelleme Tamamlandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


        public void IndirmeDurumu(object sender, DownloadProgressChangedEventArgs e)
        {
            progressFile.Properties.Maximum = (int)e.TotalBytesToReceive;
            progressFile.Text = Convert.ToString(e.BytesReceived);
            lblIndirilen.Text = $"{(Convert.ToDecimal(e.BytesReceived) / 1024 / 1024).ToString("N2")}. MB\\{(Convert.ToDecimal(e.TotalBytesToReceive) / 1024 / 1024).ToString("N2")} MB";
        }
    }
}
