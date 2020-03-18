using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace NetSatis.Backup
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        private List<string> dbList;

        public frmBackup()
        {
            InitializeComponent();
            marqueeProgressBarControl1.Properties.Stopped = true;

            txtYedeklemeKonumu.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
            dbList = context.Database.SqlQuery<string>("select name from master.dbo.sysdatabases").ToList();
            foreach (var item in dbList) {
                comboBoxEdit1.Properties.Items.Add(item);
            }
        }
        bool Kontrol()
        {
            if (string.IsNullOrEmpty(txtYedeklemeKonumu.Text)) {
                MessageBox.Show("Lütfen Konumunu seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYedeklemeKonumu_ButtonClick(null, null);
                return false;
            } else if (string.IsNullOrEmpty(comboBoxEdit1.Text)) {
                MessageBox.Show("Lütfen Veri tabanı seçiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxEdit1.ShowPopup();
                return false;
            }
            return true;
        }
        private void btnYedekle_Click(object sender, EventArgs e)
        {
            try {

                if (!Kontrol()) {
                    return;
                }

                marqueeProgressBarControl1.Properties.Stopped = false;

                DateTime dt = DateTime.Now;
                string dosya = $"{dt.Day}-{dt.Month}-{dt.Year}-{dt.Hour}-{dt.Minute}.bak";
                //string sqlcumle =$@"USE {comboBoxEdit1.Text};BACKUP DATABASE {comboBoxEdit1.Text} TO DISK='{txtYedeklemeKonumu.Text}\{dosya}'";
                var sqlcumle = $@"USE master; 
BACKUP DATABASE {comboBoxEdit1.Text}
TO DISK = '{txtYedeklemeKonumu.Text}\{comboBoxEdit1.Text}-{dosya}'
   WITH FORMAT,
      MEDIANAME = 'EDMBackups',
      NAME = 'Tam Yedekleme {comboBoxEdit1.Text}'; ";

                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);

                MessageBox.Show("Yedekleme işlemi başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex) {
                MessageBox.Show("Yedekleme işlemi yapılırken hata oluştu:" + ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                marqueeProgressBarControl1.Properties.Stopped = true;

            }
        }

        private void txtYedeklemeKonumu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {


            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog() == DialogResult.OK) {
                txtYedeklemeKonumu.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedeklemeKonumu.Text);
                SettingsTool.Save();
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            try {
                if (!Kontrol()) {
                    return;
                }
                marqueeProgressBarControl1.Properties.Stopped = false;
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Emd Yedekleme Dosyası *.bak|*.bak;*.sql";
                if (dialog.ShowDialog() == DialogResult.OK) {

                    if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl)) {
                        var connstr = context.Database.Connection.ConnectionString;
                        var serverName = connstr.Substring(connstr.IndexOf("=") + 1, connstr.IndexOf(";") - connstr.IndexOf("=") - 1);
                        var startInfo = new ProcessStartInfo();
                        startInfo.CreateNoWindow = true;
                        startInfo.UseShellExecute = false;
                        startInfo.FileName = "cmd.exe";
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden;

                        // Part 2: set arguments.
                        startInfo.Arguments = $"/C sqlcmd -S {serverName} -i {dialog.FileName} -d {comboBoxEdit1.Text}";

                        try {
                            // Part 3: start with the info we specified.
                            // ... Call WaitForExit.
                            using (Process exeProcess = Process.Start(startInfo)) {
                                exeProcess.WaitForExit();
                            }
                            MessageBox.Show("Script geri yükleme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } catch {
                            // Log error.
                        }

                    } else {

                        string sqlCumle = $@"USE [master]
RESTORE DATABASE [{comboBoxEdit1.Text}] 
FROM DISK = N'{dialog.FileName}'";

                        context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);

                    }
                    MessageBox.Show("Geri yükleme işlemi başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                MessageBox.Show("Geri yükleme işlemi yapılırken hata oluştu:" + ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                marqueeProgressBarControl1.Properties.Stopped = true;
            }

        }
    }
}
