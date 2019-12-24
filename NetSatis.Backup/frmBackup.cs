using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;

namespace NetSatis.Backup
{
    public partial class frmBackup : DevExpress.XtraEditors.XtraForm
    {
        NetSatisContext context = new NetSatisContext();
        private List<string> dbList;

        public frmBackup()
        {
            InitializeComponent();
            txtYedeklemeKonumu.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu);
            dbList=context.Database.SqlQuery<string>("select name from master.dbo.sysdatabases").ToList();
            foreach (var item in dbList)
            {
                comboBoxEdit1.Properties.Items.Add(item);
            }
        }
        private void btnYedekle_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Date;
            string dosya = $"{dt.Day}-{dt.Month}-{dt.Year}-{dt.Hour}-{dt.Minute}.bak";
            string sqlcumle =
                $@"USE {comboBoxEdit1.Text};BACKUP DATABASE {comboBoxEdit1.Text} TO DISK='{txtYedeklemeKonumu.Text}\{dosya}'";
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlcumle);

        }

        private void txtYedeklemeKonumu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog form = new FolderBrowserDialog();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtYedeklemeKonumu.Text = form.SelectedPath;
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.YedeklemeAyarlari_YedeklemeKonumu, txtYedeklemeKonumu.Text);
                SettingsTool.Save();
            }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Emd Yedekleme Dosyası *.bak|*.bak";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string sqlCumle =$"USE master;ALTER DATABASE {comboBoxEdit1.Text} set SINGLE_USER WITH ROLLBACK IMMEDIATE;ALTER DATABASE {comboBoxEdit1.Text} SET READ_ONLY;RESTORE DATABASE {comboBoxEdit1.Text} FROM DISK='{dialog.FileName}';ALTER DATABASE {comboBoxEdit1.Text} SET MULTI_USER;";
                context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCumle);
            }

        }
    }
}
