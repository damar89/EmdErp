﻿using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tools;

namespace NetSatisAdmin
{
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        private NetSatisContext context;
        private bool girisBasarili = false;

        public frmKullaniciGiris()
        {
            InitializeComponent();

            SqlConnectionStringBuilder conneticiConnectionStringBuilder = new SqlConnectionStringBuilder();
            conneticiConnectionStringBuilder.ConnectionString =
                SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi);
            if (!ConnectionTool.CheckConnetion(conneticiConnectionStringBuilder.ConnectionString))
            {
                frmBaglantiAyarlari form = new frmBaglantiAyarlari();
                form.ShowDialog();
            }
            context = new NetSatisContext();

        }

        private void KlasoreIzinVer()
        {
            DirectorySecurity izin = Directory.GetAccessControl(Application.StartupPath);
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            izin.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl, AccessControlType.Allow));
            Directory.SetAccessControl(Application.StartupPath, izin);

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text && c.Parola == txtParola.Text))
            {
                girisBasarili = true;
                RoleTool.KullaniciEntity =
                    context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullanici.Text);
                Properties.Settings.Default.Animsa = (bool)checkAnimsa.Checked;
                Properties.Settings.Default.KullaniciAdi = txtKullanici.Text;
                Properties.Settings.Default.Parola = txtParola.Text;
                Properties.Settings.Default.Save();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı veya parola hatalı.");
                txtKullanici.Text = null;
                txtParola.Text = null;
            }
        }





        private void frmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!girisBasarili)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();

            }
        }

        private void btnParolaUnuttum_Click(object sender, EventArgs e)
        {
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text))
            {
                frmParolaHatirlat form = new frmParolaHatirlat(txtKullanici.Text);
                form.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adınızı boş bırakmayınız veya yazdığınız kullanıcı adı yanlış.");

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void frmKullaniciGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e)
        {
            txtKullanici.Text = Properties.Settings.Default.KullaniciAdi;
            txtParola.Text = Properties.Settings.Default.Parola;
            checkAnimsa.Checked = true;



            if (Properties.Settings.Default.Animsa == true)
            {
                txtKullanici.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                checkAnimsa.Checked = true;
            }

        }
    }
}