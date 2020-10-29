using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetSatisAdmin
{
    public partial class frmKullaniciGiris : DevExpress.XtraEditors.XtraForm
    {
        private NetSatisContext context;
        private bool girisBasarili = false;

        public frmKullaniciGiris() {
            InitializeComponent();

            SqlConnectionStringBuilder conneticiConnectionStringBuilder = new SqlConnectionStringBuilder();
            conneticiConnectionStringBuilder.ConnectionString =
                SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi);
            if (!ConnectionTool.CheckConnetion(conneticiConnectionStringBuilder.ConnectionString)) {
                frmBaglantiAyarlari form = new frmBaglantiAyarlari();
                form.ShowDialog();
            }
            context = new NetSatisContext();

            KlasoreIzinVer();

            checkAnimsa.CheckStateChanged += (s, e) => {
                if (checkAnimsa.CheckState == CheckState.Checked) {
                    Properties.Settings.Default.Animsa = true;
                    Properties.Settings.Default.KullaniciAdi = txtKullanici.Text;
                    Properties.Settings.Default.Parola = txtParola.Text;
                    Properties.Settings.Default.Save();
                } else {
                    Properties.Settings.Default.Animsa = false;
                    Properties.Settings.Default.KullaniciAdi = null;
                    Properties.Settings.Default.Parola = null;
                    Properties.Settings.Default.Save();
                }
            };
        }

        private void KlasoreIzinVer() {
            //DirectorySecurity izin = Directory.GetAccessControl(Application.StartupPath);
            //SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            //izin.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl, AccessControlType.Allow));
            //Directory.SetAccessControl(Application.StartupPath, izin);


            DirectoryInfo dInfo = new DirectoryInfo(Application.StartupPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);

        }

        private void btnGiris_Click(object sender, EventArgs e) {
            using (var context = new NetSatisContext()) {
                context.Database.CreateIfNotExists();
                if (!context.Cariler.Any(c => c.CariKodu == "VRS001")) {
                    context.Cariler.Add(new Cari {
                        CariAdi = "Peşin Satış",
                        CariKodu = "VRS001",
                        FaturaUnvani = "Peşin Satış",
                        CariTuru = "Müşteri",

                    });
                    context.SaveChanges();

                }
            }
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text && c.Parola == txtParola.Text)) {
                girisBasarili = true;
                RoleTool.KullaniciEntity =
                    context.Kullanicilar.SingleOrDefault(c => c.KullaniciAdi == txtKullanici.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else {
                MessageBox.Show("Girdiğiniz kullanıcı adı veya parola hatalı.");
                txtKullanici.Text = null;
                txtParola.Text = null;
            }
        }

        private void frmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e) {
            if (!girisBasarili) {
                this.DialogResult = DialogResult.Cancel;
                this.Close();

            }
        }

        private void btnParolaUnuttum_Click(object sender, EventArgs e) {
            if (context.Kullanicilar.Any(c => c.KullaniciAdi == txtKullanici.Text)) {
                frmParolaHatirlat form = new frmParolaHatirlat(txtKullanici.Text);
                form.ShowDialog();
            } else {
                XtraMessageBox.Show("Kullanıcı adınızı boş bırakmayınız veya yazdığınız kullanıcı adı yanlış.");

            }
        }

        private void btnKapat_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void frmKullaniciGiris_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                btnGiris.PerformClick();
            }
        }

        private void frmKullaniciGiris_Load(object sender, EventArgs e) {

            Thread.Sleep(5000);
            if (System.Windows.Forms.SystemInformation.TerminalServerSession) {
                SkinManager.DisableFormSkins();
                SkinManager.DisableMdiFormSkins();
                Application.VisualStyleState = VisualStyleState.NoneEnabled;

                UserLookAndFeel.Default.UseWindowsXPTheme = false;
                UserLookAndFeel.Default.Style = LookAndFeelStyle.Flat;

                WindowsFormsSettings.AnimationMode = AnimationMode.DisableAll;
                WindowsFormsSettings.AllowHoverAnimation = DevExpress.Utils.DefaultBoolean.False;

                BarAndDockingController.Default.PropertiesBar.MenuAnimationType = AnimationType.None;
                BarAndDockingController.Default.PropertiesBar.SubmenuHasShadow = false;
                BarAndDockingController.Default.PropertiesBar.AllowLinkLighting = false;
            }

            checkAnimsa.Checked = false;

            if (Properties.Settings.Default.Animsa == true) {
                txtKullanici.Text = Properties.Settings.Default.KullaniciAdi;
                txtParola.Text = Properties.Settings.Default.Parola;
                checkAnimsa.Checked = true;
            }

        }
    }
}