using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using NetSatis.BackOffice.AnaMenü;
using NetSatis.BackOffice.Ayarlar;
using NetSatis.BackOffice.Cari;
using NetSatis.BackOffice.Depo;
using NetSatis.BackOffice.Fiyat_Değiştir;
using NetSatis.BackOffice.Fiş;
using NetSatis.BackOffice.Hızlı_Satış;
using NetSatis.BackOffice.Kasa;
using NetSatis.BackOffice.Kasa_Hareketleri;
using NetSatis.BackOffice.Personel;
using NetSatis.BackOffice.Raporlar;
using NetSatis.BackOffice.Stok;
using NetSatis.BackOffice.Masraf;
using NetSatis.BackOffice.Stok_Hareketleri;
using NetSatis.BackOffice.Ödeme_Türü;
using NetSatis.BackOffice.İndirim;
using NetSatis.Backup;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tools;
using NetSatis.Reports.Stok;
using NetSatisAdmin;
using NetSatis.BackOffice.Ajanda;
using NetSatis.Reports.Dizayn;
using NetSatis.BackOffice.Döviz_Kurları;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraTreeList;
using NetSatis.BackOffice.Tanım;

namespace NetSatis.BackOffice
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly object frmGuncelleme;
        StokDAL stokDal = new StokDAL();
        public static int UserId = -1;
        public frmAnaMenu()
        {
            InitializeComponent();
            string DosyaYolu = $@"{Application.StartupPath}\Gorunum";
            if (!Directory.Exists(DosyaYolu)) Directory.CreateDirectory(DosyaYolu);

            string BarkodDizayn = $@"{Application.StartupPath}\BarkodDizayn";
            if (!Directory.Exists(BarkodDizayn)) Directory.CreateDirectory(BarkodDizayn);

            try
            {
                managerS.LookAndFeel.SetSkinStyle(SettingsTool.AyarOku(SettingsTool.Ayarlar.TemaAyarlari_Tema));
                //frmKullaniciGiris girisform = new frmKullaniciGiris();
                //girisform.ShowDialog();
                barKullaniciAdi.Caption = $"Giriş Yapan Kullanıcı : {RoleTool.KullaniciEntity.KullaniciAdi}";
                string Name = RoleTool.KullaniciEntity.KullaniciAdi;
                using (NetSatis.Entities.Context.NetSatisContext db = new Entities.Context.NetSatisContext())
                {
                    var list = db.Kullanicilar.Where(x => x.KullaniciAdi == Name).FirstOrDefault();
                    UserId = list.Id;
                }
                WebClient indir = new WebClient();
                string programVersiyon = Assembly.Load("NetSatis.BackOffice").GetName().Version.ToString();
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                string guncelVersiyon = indir.DownloadString("https://emdyazilim.com/downloads/version.txt")
                    .Substring(0, 7);
                if (programVersiyon != guncelVersiyon)
                {
                    if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrolu)))
                    {
                        if (MessageBox.Show("Programın yeni bir sürümü bulundu güncellemek ister misiniz?",
                                "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Process.Start($"{Application.StartupPath}\\NetSatis.Update.exe");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Application.Exit();
            }


        }
        //private void LisansUygula()
        //{
        //    for (var i = 0; i < CurrentLicense.License.LicenseInformation.Count; i++)
        //        Dictionary.Add(CurrentLicense.License.LicenseInformation.GetKey(i).ToString(), CurrentLicense.License.LicenseInformation.GetByIndex(i).ToString());


        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            frmAjanda form = new frmAjanda();
            form.MdiParent = this;
            form.Show();

            RoleTool.RolleriYukle(ribbonControl1);

        }

        private void barStokHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokHareketleri form = new frmStokHareketleri();

            form.Show();
        }

        private void barKasaHareketleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasaHareketleri form = new frmKasaHareketleri(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void barPlasiyer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPersonel form = new frmPersonel();
            form.MdiParent = this;
            form.Show();
        }

        private void FisIslem_Click(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Item.Caption);

            form.Show();
        }

        private void FisIslem_Click(string e)
        {
            frmFisIslem form = new frmFisIslem(null, e);

            form.Show();
        }
        private void StokTransfer_Click(string e)
        {
            frmFisTransfer frm = new frmFisTransfer(null, e);
            frm.Show();
        }

        private void barDepo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepo form = new frmDepo();
            form.MdiParent = this;
            form.Show();
        }

        private void barKasalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasa form = new frmKasa();

            form.Show();
        }

        private void barOdemeTurleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdemeTuru form = new frmOdemeTuru();

            form.Show();
        }

        private void barTopluFiyatDegisikligi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTopluFiyat form = new frmTopluFiyat();
            form.Show();
        }

        private void barIndirimler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmIndirim form = new frmIndirim();
            form.Show();
        }

        private void barSatisEkrani_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barStokHareketRaporu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptStokHareketleri report = new rptStokHareketleri();
            frmRaporGoruntule form = new frmRaporGoruntule(report);
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barRaporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRaporListesi form = new frmRaporListesi();
            form.MdiParent = this;
            form.Show();
        }

        private void barRaporDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmRaporDuzenle form = new frmRaporDuzenle();
            form.WindowState = FormWindowState.Maximized;
            form.Show();

        }

        private void barEtiketBasim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BarkodEtiketHazirla form = new BarkodEtiketHazirla();
            form.ShowDialog();
        }

        private void btnOzgunRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOzgunRaporHazirla form = new frmOzgunRaporHazirla();
            form.ShowDialog();
        }

        private void btnAyarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAyarlar form = new frmAyarlar();
            form.MdiParent = this;
            form.Show();
        }

        private void btnYedekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmBackup form = new frmBackup();
            form.ShowDialog();
        }

        private void btnGuncelle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebClient indir = new WebClient();
            string programVersiyon = Assembly.Load("NetSatis.BackOffice").GetName().Version.ToString();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string guncelVersiyon = indir.DownloadString("https://emdyazilim.com/downloads/version.txt");
            if (programVersiyon != guncelVersiyon)
            {
                Process.Start($"{Application.StartupPath}\\NetSatis.Update.exe");
            }
            else
            {
                MessageBox.Show("Programınız Güncel");
            }


        }

        private void barHizliSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHizliSatis form = new frmHizliSatis();
            form.Show();
        }

        private void btnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStok form = new frmStok();

            form.Show();
        }

        private void btnCariler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCari form = new frmCari();

            form.Show();
        }

        private void barFisveFaturalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFis form = new frmFis();
            form.MdiParent = this;
            form.Show();
        }

        private void btnEkTanim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKullanicilar form = new frmKullanicilar();
            form.ShowDialog();
        }

        private void btnStokAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokIslem form = new frmStokIslem(new Entities.Tables.Stok());
            form.Show();


        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAjanda form = new frmAjanda();
            form.MdiParent = this;
            form.Show();

        }

        private void btnCariAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmCariIslem form = new frmCariIslem(new Entities.Tables.Cari());
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTahsilatlar form = new frmTahsilatlar();

            form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOdemeler form = new frmOdemeler();

            form.Show();

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCariDevir form = new frmCariDevir();

            form.Show();

        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSayimEksigi form = new frmSayimEksigi();

            form.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSayimFazlasi form = new frmSayimFazlasi();

            form.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokDevir form = new frmStokDevir();

            form.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAlisFtr form = new frmAlisFtr();

            form.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPerakendeListesi form = new frmPerakendeListesi(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmToptanSatis form = new frmToptanSatis();

            form.Show();
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAlisIade form = new frmAlisIade();

            form.Show();
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSatisIade form = new frmSatisIade();

            form.Show();
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFis form = new frmFis();

            form.Show();
        }

        private void btnMasraf_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMasraf form = new frmMasraf();

            form.Show();

        }

        private void skinRibbonGalleryBarItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void skinRibbonGalleryBarItem1_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            string t = e.Item.Tag.ToString();

            SettingsTool.AyarDegistir(SettingsTool.Ayarlar.TemaAyarlari_Tema, e.Item.Tag.ToString());
            SettingsTool.Save();
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSatisIrsaliyesi form = new frmSatisIrsaliyesi();
            form.MdiParent = this;
            form.Show();
        }



        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAlisIrsaliyesi form = new frmAlisIrsaliyesi();

            form.Show();
        }

        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAlinanSiparis form = new frmAlinanSiparis();

            form.Show();
        }

        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVerilenSiparis form = new frmVerilenSiparis();

            form.Show();
        }

        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAlinanTeklif form = new frmAlinanTeklif();

            form.Show();
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVerilenTeklif form = new frmVerilenTeklif();

            form.Show();
        }

        private void btnGenelStokHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokHareketleri form = new frmStokHareketleri();

            form.Show();
        }

        private void btnTekStokHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGenelSatisRapor form = new frmGenelSatisRapor(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void btnAlis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGenelAlisRapor form = new frmGenelAlisRapor(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void btnKarZarar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGenelSatisKarlilik form = new frmGenelSatisKarlilik(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void btnCariDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCariBakiye form = new frmCariBakiye();

            form.Show();
        }

        private void btnCariEkstre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEkstre form = new frmEkstre();
            form.Show();

        }

        private void btnTarihSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmTarihliRapor form = new frmTarihliRapor();
            //form.Show();

        }

        private void btnTarihKar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTarihliKar form = new frmTarihliKar();
            form.Show();
        }

        private void btnTarihAlis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTarihliAlis form = new frmTarihliAlis();
            form.Show();
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKasaTarih form = new frmKasaTarih();
            form.Show();
        }

        private void btnEgitim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCDKwrhI6KKjw5ETHV9NJ3YA");

        }

        private void btnSite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://emdyazilim.com/");
        }

        private void btnStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStok form = new frmStok();

            form.Show();
        }

        private void btnCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCari form = new frmCari();

            form.Show();
        }

        private void btnStokTanitim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokIslem form = new frmStokIslem(new Entities.Tables.Stok());
            form.ShowDialog();
        }

        private void btnStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokHareketleri form = new frmStokHareketleri();

            form.Show();
        }

        private void btnCariTanitimKArti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCariIslem form = new frmCariIslem(new Entities.Tables.Cari());
            form.Show();
        }

        private void btnFisler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFisIslem form = new frmFisIslem(null, e.Link.Caption);

            form.Show();

        }
        private void btnFisler_LinkClicked2(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmFisTransfer form = new frmFisTransfer(null, e.Link.Caption);

            form.Show();

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem33_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGenelSatisRapor form = new frmGenelSatisRapor(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void navBarItem34_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliSatis frm = new frmTarihliSatis();
            frm.Show();

        }

        private void navBarItem35_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGenelAlisRapor form = new frmGenelAlisRapor(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void navBarItem36_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliAlis form = new frmTarihliAlis();
            form.Show();
        }

        private void navBarItem37_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmGenelSatisKarlilik form = new frmGenelSatisKarlilik(DateTime.MinValue, DateTime.MaxValue);

            form.Show();
        }

        private void navBarItem38_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliKar form = new frmTarihliKar();
            form.Show();
        }

        private void navBarItem41_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasaTarih form = new frmKasaTarih();
            form.Show();
        }

        private void navBarItem42_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmCariBakiye form = new frmCariBakiye();

            form.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEkstre form = new frmEkstre();
            form.Show();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAlisFtr form = new frmAlisFtr();

            form.Show();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmToptanSatis form = new frmToptanSatis();

            form.Show();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAlisIade form = new frmAlisIade();

            form.Show();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSatisIade form = new frmSatisIade();

            form.Show();
        }

        private void navBarItem23_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAlisIrsaliyesi form = new frmAlisIrsaliyesi();

            form.Show();
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmSatisIrsaliyesi form = new frmSatisIrsaliyesi();

            form.Show();
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAlinanSiparis form = new frmAlinanSiparis();

            form.Show();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmVerilenSiparis form = new frmVerilenSiparis();

            form.Show();
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmAlinanTeklif form = new frmAlinanTeklif();

            form.Show();
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmVerilenTeklif form = new frmVerilenTeklif();

            form.Show();
        }

        private void btnPersonelTanitim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmPersonel frm = new frmPersonel();
            frm.Show();
        }

        private void btnDepoTanitim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDepo frm = new frmDepo();
            frm.Show();
        }

        private void btnOdemeTanitim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmOdemeTuru frm = new frmOdemeTuru();
            frm.Show();
        }

        private void btnKasaTanitim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKasa frm = new frmKasa();
            frm.Show();
        }

        private void btnMasrafTanitim_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmMasraf frm = new frmMasraf();
            frm.Show();
        }

        private void barBtnFaturaDizayn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFaturaDizayn frm = new frmFaturaDizayn();

            frm.Show();
        }

        private void barBtnStokEnvanter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Envanter envt = new Envanter();
            envt.EnvanterHazirla();
        }

        private void btnKisayol_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKisayol form = new frmKisayol();
            form.Show();
        }

        private void barBtnCokluStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCokluStok frm = new frmCokluStok();
            frm.MdiParent = this; frm.Show();
        }

        private void btnCariHesapEkstre_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmEkstre frm = new frmEkstre();
            frm.Show();

        }

        private void btnStokHareketi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmStokHareketleri frm = new frmStokHareketleri();
            frm.Show();
        }

        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDovizKurlari frm = new frmDovizKurlari();
            frm.Show();
        }

        private void navBarItem25_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliMasraf frm = new frmTarihliMasraf();
            frm.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEtkinlestirme frm = new frmEtkinlestirme();
            frm.Show();
        }

        private void barButtonItem38_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmStokSatis frm = new frmStokSatis(DateTime.MinValue, DateTime.MaxValue);
            frm.ShowDialog();
        }

        private void navBarItem26_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmKârTarihAlis frm = new frmKârTarihAlis();
            frm.Show();
        }

        private void btnIadeListeleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliIade frm = new frmTarihliIade();
            frm.Show();
        }

        private void btnOdemeler_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliOdeme frm = new frmTarihliOdeme();
            frm.Show();
        }

        private void btnTahsilatlar_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliTahsilat frm = new frmTarihliTahsilat();
            frm.Show();
        }

        private void btnCokluCari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCokluCari frm = new frmCokluCari();
            frm.Show();
        }

        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPesSatisIrsaliyesi frm = new frmPesSatisIrsaliyesi();
            frm.Show();
        }

        private void frmHakkinda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDetay_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmTarihliDetay frm = new frmTarihliDetay();
            frm.Show();

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnHareketTipi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmHareketTipi frm = new frmHareketTipi();
            frm.Show();
        }

        private void navBarItem27_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBa ba = new frmBa();
            ba.Show();
        }

        private void treeList1_Click(object sender, EventArgs e)
        {

        }

        private void treeList1_MouseClick(object sender, MouseEventArgs e)
        {




        }

        private void treeList1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var x = sender as TreeList;
            int a = 5;
            string name = "";
            if (x.FocusedNode.Tag != null)
            {
                name = x.FocusedNode.Tag.ToString();
            }

            switch (name)
            {
                case "Sayım Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;

                case "Alış Faturası":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;

                case "Stok Listesi":
                    btnStok_ItemClick(null, null);
                    break;

                case "Stok Tanıtım Kartı":
                    btnStokAc_ItemClick(null, null);
                    break;
                case "Cari Tanıtım Kartı":
                    btnCariAc_ItemClick(null, null);
                    break;
                case "Cari Listesi":
                    btnCariler_ItemClick(null, null);
                    break;

                case "Toptan Satış Faturası":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Tahsilat Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Ödeme Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Cari Devir Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Masraf Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Satış İade Faturası":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Alış İade Faturası":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Satış İrsaliyesi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Alış İrsaliyesi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Verilen Sipariş Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Alınan Sipariş Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Alınan Teklif Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Verilen Teklif Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;

                case "Stok Devir Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Satış İade Faturaları":
                    navBarItem12_LinkClicked(null, null);
                    break;
                case "Toptan Satış Faturaları":
                    barButtonItem32_ItemClick(null, null);
                    break;
                case "Satış İrsaliyeleri":
                    barButtonItem39_ItemClick(null, null);
                    break;
                case "Alış İrsaliyeleri":
                    barButtonItem40_ItemClick(null, null);
                    break;
                case "Sayım Eksiği Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Sayım Fazlası Fişi":
                    FisIslem_Click(x.FocusedNode.Tag.ToString());
                    break;
                case "Alış İade Faturaları":
                    barButtonItem33_ItemClick(null, null);
                    break;
                case "Verilen Siparişler":
                    barButtonItem42_ItemClick(null, null);
                    break;
                case "Alınan Siparişler":
                    barButtonItem41_ItemClick(null, null);
                    break;
                case "Ödeme Türü Tanıtım Kartı":
                    btnOdemeTanitim_LinkClicked(null, null);
                    break;
                case "Masraf Tanıtım Kartı":
                    btnMasrafTanitim_LinkClicked(null, null);
                    break;
                case "Kasa Tanıtım Kartı":
                    btnKasaTanitim_LinkClicked(null, null);
                    break;
                case "Depo Tanıtım Kartı":
                    btnDepoTanitim_LinkClicked(null, null);
                    break;
                case "Hareket Tipi":
                    btnHareketTipi_LinkClicked(null, null);
                    break;
                case "Personel Tanıtım Kartı":
                    btnPersonelTanitim_LinkClicked(null, null);
                    break;
                case "Verilen Teklifler":
                    barButtonItem44_ItemClick(null, null);
                    break;
                case "Alınan Teklifler":
                    barButtonItem43_ItemClick(null, null);
                    break;
                case "Alış Faturaları":
                    barButtonItem16_ItemClick(null, null);
                    break;
                case "Bs Form":
                    navBarItem30_LinkClicked(null, null);
                    break;
                case "Ba Form":
                    navBarItem27_LinkClicked(null, null);
                    break;
                case "Genel Stok Hareketleri":
                    btnStokHareketi_LinkClicked(null, null);
                    break;
                case "Satış Raporu":
                    navBarItem33_LinkClicked(null, null);
                    break;
                case "Tarih Aralıklı Satış Raporu":
                    navBarItem34_LinkClicked(null, null);
                    break;
                case "Kar Zarar Raporu Alış Fiyatından":
                    navBarItem26_LinkClicked(null, null);
                    break;
                case "Kar Zarar Analizi":
                    navBarItem37_LinkClicked(null, null);
                    break;
                case "Tarih Aralıklı Kar Zarar Analizi":
                    navBarItem38_LinkClicked(null, null);
                    break;
                case "Ödeme Listesi":
                    btnOdemeler_LinkClicked(null, null);
                    break;
                case "Tahsilat Listesi":
                    btnTahsilatlar_LinkClicked(null, null);
                    break;
                case "Masraf Dökümü":
                    navBarItem25_LinkClicked(null, null);
                    break;
                case "Stok Transfer":
                    StokTransfer_Click(x.FocusedNode.Tag.ToString());
                    //btnFisler_LinkClicked2(x.FocusedNode.Tag.ToString());
                    break;
                case "Genel Alış Raporu":
                    navBarItem35_LinkClicked(null, null);
                    break;
                case "Tarih Aralıklı Alış Raporu":
                    navBarItem36_LinkClicked(null, null);
                    break;
                case "İade Listeleri":
                    btnIadeListeleri_LinkClicked(null, null);
                    break;
                case "Cari Bakiye Durum Raporu":
                    navBarItem42_LinkClicked(null, null);
                    break;
                case "Cari Hesap Ekstresi":
                    btnCariHesapEkstre_LinkClicked(null, null);
                    break;
                case "Günlük Kasa Raporu":
                    navBarItem41_LinkClicked(null, null);
                    break;
                case "Kasa Raporu Detaylı":
                    btnDetay_LinkClicked(null, null);
                    break;
                default:
                    break;
            }

        }

        private void navBarItem30_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBs frm = new frmBs();
            frm.Show();
        }

        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FirmaSabitleri frm = new FirmaSabitleri();
            frm.Show();
        }

        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEkullanici frm = new frmEkullanici();
            frm.Show();

        }

        private void barButtonItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFaturaGonder frm = new frmFaturaGonder();
            frm.Show();

        }

        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {

        }
    }
}
