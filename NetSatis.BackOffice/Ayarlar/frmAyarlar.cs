using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Printing;
using System.Windows.Forms;
using NetSatis.Entities.Context;
using NetSatis.Entities.Data_Access;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;


namespace NetSatis.BackOffice.Ayarlar
{
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        NetSatis.EDonusum.Controller.EDonusumIslemleri eislem = new EDonusum.Controller.EDonusumIslemleri();
        NetSatisContext context = new NetSatisContext();
        DepoDAL depoDal = new DepoDAL();
        KasaDAL kasaDal = new KasaDAL();
        CariDAL cariDal = new CariDAL();
        StokDAL stokDal = new StokDAL();
        public frmAyarlar()
        {
            InitializeComponent();
            cmbFaturaYazici.Properties.Items.AddRange(YaziciListesi());
            cmbFisYazici.Properties.Items.AddRange(YaziciListesi());
            //gridlookDepo.Properties.DataSource = depoDal.GetAll(context);
            //gridlookDepo.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanDepo);

            comboBoxEdit1.SelectedIndex =
                Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazirmaAyari));

            //gridLookKasa.Properties.DataSource = kasaDal.GetAll(context);

            var combx = eislem.HareketTipiListele();

            foreach (var i in combx)
            {
                cmbTipi.Properties.Items.Add(i.Aciklama);
            }

            cmbTipi.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanHareketTipi);

            cmbFaturaYazici.Text =
                SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici);

            var ayar = context.Ayarlar.FirstOrDefault();
            if (ayar != null)
            {

                txtOnEk.Text = ayar.HizliSatisOnEki;
                calcFisKodu.Value = Convert.ToDecimal(ayar.HizliSatisSiradakiNo);

            }

            var kodlar = context.Kodlar.Where(x => x.Tablo == "Fis").FirstOrDefault();
            if (kodlar != null)
            {
                txtToptanOnEk.Text = kodlar.OnEki;
                calcToptanFisKodu.Value = Convert.ToDecimal(kodlar.SonDeger);
            }



            cmbBilgiFisi.SelectedIndex =
                Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazidirmaAyari));

            cmbTahsilat.SelectedIndex =
                Convert.ToInt32(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_TahsilatFisiYazidirmaAyari));

            cmbFisYazici.Text =
                SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici);

            //gridLookKasa.Properties.DataSource = kasaDal.GetAll(context);

            //gridLookKasa.EditValue = SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanKasa);

            txtFirmaAdi.Text = SettingsTool.AyarOku(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi);

            toggleGuncelle.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrolu));

            toggleBilgiFisiYazdirilsinmi.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi));
            toggleAlisFiyat.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_AlisFiyat));
            toggleBilgiFisiSorulsunmu.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiSorulsunmu));
            toggIrsaliye.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_Olussunmu));
            togCariEtkilesinmi.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_CariEtkilesin));
            togStoguEtkilesinmi.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_StoguEtkilesin));

            kopKoparatifmi.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Kooperatif_Kooperatifmi));



            toggleStokEksi.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisStok_EksiyeDusme));

            toggleMinMiktar.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisStok_MinMiktar));
            toggleDoviz.IsOn = Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_doviz));

            ComboboxListele();
            #region FaturaGörüntüleme
            string faturaAdres = SettingsTool.AyarOku(SettingsTool.Ayarlar.FaturaDizayn_DosyaYolu); //Fatura Dizayn dosyasının Adresini oku
            if (!string.IsNullOrEmpty(faturaAdres) || !string.IsNullOrWhiteSpace(faturaAdres))
            {
                List<FaturaDizaynTemp> itemler = (List<FaturaDizaynTemp>)cmbFaturaDizayn.Properties.DataSource;
                try
                {
                    string str = itemler.FirstOrDefault(x => x.Path == faturaAdres).FileName;

                }
                catch (Exception)
                {

                }


            }

            #endregion
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (context.Ayarlar.Count() == 0)
                {
                    Ayar ayar = new Ayar();
                    ayar.HizliSatisOnEki = txtOnEk.Text;
                    ayar.HizliSatisSiradakiNo = Convert.ToInt32(calcFisKodu.Value);
                    context.Ayarlar.Add(ayar);
                }
                else
                {
                    var ayar = context.Ayarlar.First();
                    ayar.HizliSatisOnEki = txtOnEk.Text;
                    ayar.HizliSatisSiradakiNo = Convert.ToInt32(calcFisKodu.Value);
                }
                if (context.Kodlar.Where(x => x.Tablo == "Fis").Count() == 0)
                {
                    NetSatis.Entities.Tables.Kod kod = new NetSatis.Entities.Tables.Kod();
                    kod.OnEki = txtToptanOnEk.Text;
                    kod.SonDeger = Convert.ToInt32(calcToptanFisKodu.Value);
                    context.Kodlar.Add(kod);
                }
                else
                {
                    var kod = context.Kodlar.Where(x => x.Tablo == "Fis").First();
                    kod.OnEki = txtToptanOnEk.Text;
                    kod.SonDeger = Convert.ToInt32(calcToptanFisKodu.Value);
                }

                context.SaveChanges();

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_PesFisKodu, calcFisKodu.Value.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_PesFisOnEki, txtOnEk.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BarkodAyarlari_Barkodu, calcBarKodu.Value.ToString());
                //doviz
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DolarKur_Usd, calcUsd.Text.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DolarKur_Euro, calcEuro.Text.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.DolarKur_Rub, calcRub.Text.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazici, cmbFaturaYazici.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazici, cmbFisYazici.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FirmaAyarlari_FirmaAdi, txtFirmaAdi.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_FaturaYazirmaAyari, comboBoxEdit1.SelectedIndex.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_BilgiFisiYazidirmaAyari, cmbBilgiFisi.SelectedIndex.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_TahsilatFisiYazidirmaAyari, cmbTahsilat.SelectedIndex.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_VarsayilanHareketTipi, cmbTipi.Text);
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.GenelAyarlar_GuncellemeKontrolu, toggleGuncelle.IsOn.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiYazdirilsinmi, toggleBilgiFisiYazdirilsinmi.IsOn.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Irsaliye_Olussunmu, toggIrsaliye.IsOn.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Irsaliye_CariEtkilesin, togCariEtkilesinmi.IsOn.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Irsaliye_StoguEtkilesin, togStoguEtkilesinmi.IsOn.ToString());



                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BilgiFisi_BilgiFisiSorulsunmu, toggleBilgiFisiSorulsunmu.IsOn.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisStok_EksiyeDusme, toggleStokEksi.IsOn.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_AlisFiyat, toggleAlisFiyat.IsOn.ToString());

                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisStok_MinMiktar, toggleMinMiktar.IsOn.ToString());
                //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Kooperatif_Borsa, kopBorsa.IsOn.ToString());
                //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Kooperatif_Bagkur, kopBagkur.IsOn.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Kooperatif_Kooperatifmi, kopKoparatifmi.IsOn.ToString());
                //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Kooperatif_Mera, kopMera.IsOn.ToString());
                //SettingsTool.AyarDegistir(SettingsTool.Ayarlar.Kooperatif_Zirai, kopZirai.IsOn.ToString());
                SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SatisAyarlari_doviz, toggleDoviz.IsOn.ToString());
            }
            catch (Exception)
            {

            }






            try
            {
                string str = cmbFaturaDizayn.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FaturaDizayn_DosyaAdi, cmbFaturaDizayn.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.FaturaDizayn_DosyaYolu, cmbFaturaDizayn.GetColumnValue("Path").ToString());
                }
            }
            catch (Exception)
            {
            }

            try
            {
                string str2 = cmbSiparisDizayn.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str2))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SiparisDizayn_DosyaAdi1, cmbSiparisDizayn.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.SiparisDizayn_DosyaYolu1, cmbSiparisDizayn.GetColumnValue("Path").ToString());
                }

            }
            catch (Exception)
            {

            }
            try
            {
                string str3 = cmbTeklifDizayn.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str3))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.TeklifDizayn_DosyaAdi2, cmbTeklifDizayn.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.TeklifDizayn_DosyaYolu2, cmbTeklifDizayn.GetColumnValue("Path").ToString());
                }
            }
            catch (Exception)
            {
            }

            try
            {
                string str4 = cmbIrsaliyeDizayn.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str4))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.IrsaliyeDizayn_DosyaAdi3, cmbIrsaliyeDizayn.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.IrsaliyeDizayn_DosyaYolu3, cmbIrsaliyeDizayn.GetColumnValue("Path").ToString());
                }
            }
            catch (Exception)
            {
            }

            try
            {
                string str5 = cmbProFaturaDizayn.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str5))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.ProFaturaDizayn_DosyaAdi4, cmbProFaturaDizayn.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.ProFaturaDizayn_DosyaYolu4, cmbProFaturaDizayn.GetColumnValue("Path").ToString());
                }
            }
            catch (Exception)
            {

            }
            try
            {
                string str6 = lookMustahsil.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str6))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.MustahsilDizayn_DosyaAdi5, lookMustahsil.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.MustahsilDizayn_DosyaYolu5, lookMustahsil.GetColumnValue("Path").ToString());
                }
            }
            catch (Exception)
            {

            }
            try
            {
                string str7 = cmbBilgiFisDizayn.GetColumnValue("Path").ToString();
                if (!string.IsNullOrEmpty(str7))
                {
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BilgiFisiDizayn_DosyaAdi6, cmbBilgiFisDizayn.GetColumnValue("FileName").ToString());
                    SettingsTool.AyarDegistir(SettingsTool.Ayarlar.BilgiFisiDizayn_DosyaYolu6, cmbBilgiFisDizayn.GetColumnValue("Path").ToString());
                }
            }
            catch (Exception)
            {

            }

            SettingsTool.Save();
            MessageBox.Show("Kayıt işlemi Tamamlanmıştır.");

        }
        private List<string> YaziciListesi()
        {
            try
            {
                return new LocalPrintServer().GetPrintQueues().Select(c => c.Name).ToList();

            }
            catch
            {
                return new List<string>();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAyarlar_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape && MessageBox.Show("Kaydedilmemiş veri olabilir. Çıkmak istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void ComboboxListele()
        {
            string uygulamaKlasoru = Application.StartupPath + "\\DizaynFormlar";
            if (Directory.Exists(uygulamaKlasoru) == false)
            {
                Directory.CreateDirectory(uygulamaKlasoru);
            }

            string[] dosyalar = Directory.GetFiles(uygulamaKlasoru);
            List<FaturaDizaynTemp> data = new List<FaturaDizaynTemp>();
            foreach (string item in dosyalar)
            {
                data.Add(new FaturaDizaynTemp
                {
                    Path = item,
                    FileName = item.Substring(item.LastIndexOf("\\")).Replace("\\", "")
                });
            }

            cmbFaturaDizayn.Properties.DataSource = data;
            cmbFaturaDizayn.Properties.DisplayMember = "FileName";
            cmbFaturaDizayn.Properties.ValueMember = "Path";
            cmbSiparisDizayn.Properties.DataSource = data;
            cmbSiparisDizayn.Properties.DisplayMember = "FileName";
            cmbSiparisDizayn.Properties.ValueMember = "Path";
            cmbTeklifDizayn.Properties.DataSource = data;
            cmbTeklifDizayn.Properties.DisplayMember = "FileName";
            cmbTeklifDizayn.Properties.ValueMember = "Path";
            cmbIrsaliyeDizayn.Properties.DataSource = data;
            cmbIrsaliyeDizayn.Properties.DisplayMember = "FileName";
            cmbIrsaliyeDizayn.Properties.ValueMember = "Path";
            cmbProFaturaDizayn.Properties.DataSource = data;
            cmbProFaturaDizayn.Properties.DisplayMember = "FileName";
            cmbProFaturaDizayn.Properties.ValueMember = "Path";
            lookMustahsil.Properties.DataSource = data;
            lookMustahsil.Properties.DisplayMember = "FileName";
            lookMustahsil.Properties.ValueMember = "Path";
            cmbBilgiFisDizayn.Properties.DisplayMember = "FileName";
            cmbBilgiFisDizayn.Properties.ValueMember = "Path";
            cmbBilgiFisDizayn.Properties.DataSource = data;
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            if (kopKoparatifmi.IsOn)
            {
                lookMustahsil.Visible = true;
                labelControl30.Visible = true;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            List<string> listKategori = new List<string>();
            List<string> listana = new List<string>();
            List<string> listalt = new List<string>();
            listKategori = context.Stoklar.Select(z => z.Kategori).Distinct().ToList();
            listana = context.Stoklar.Select(z => z.AnaGrup).Distinct().ToList();
            listalt = context.Stoklar.Select(z => z.AltGrup).Distinct().ToList();
            int counter = 1;
            foreach (var item in listKategori)
            {
                if (item != null)
                {
                    Kategori k = new Kategori();
                    if (counter < 10)
                    {
                        k.Kod = "0" + counter.ToString();
                    }
                    else
                    {
                        k.Kod = counter.ToString();
                    }
                    k.KategoriAdi = item;
                    k.KayitTarihi = DateTime.Now;
                    k.GuncellemeTarihi = DateTime.Now;
                    context.Kategoriler.Add(k);
                    context.SaveChanges();
                    counter++;
                }
            }

            counter = 1;
            foreach (var item in listana)
            {
                if (item != null)
                {
                    AnaGrup k = new AnaGrup();
                    if (counter < 10)
                    {
                        k.Kod = "0" + counter.ToString();
                    }
                    else
                    {
                        k.Kod = counter.ToString();
                    }
                    k.AnaGrupAdi = item;
                    k.KayitTarihi = DateTime.Now;
                    k.GuncellemeTarihi = DateTime.Now;
                    context.AnaGruplar.Add(k);
                    context.SaveChanges();
                    counter++;
                }
            }

            counter = 1;
            foreach (var item in listalt)
            {
                if (item != null)
                {
                    AltGrup k = new AltGrup();
                    if (counter < 10)
                    {
                        k.Kod = "0" + counter.ToString();
                    }
                    else
                    {
                        k.Kod = counter.ToString();
                    }
                    k.AltGrupAdi = item;
                    k.KayitTarihi = DateTime.Now;
                    k.GuncellemeTarihi = DateTime.Now;
                    context.AltGruplar.Add(k);
                    context.SaveChanges();
                    counter++;
                }
            }

            foreach (var item in context.Stoklar.ToList())
            {
                var kat = context.Kategoriler.FirstOrDefault(x => x.KategoriAdi == item.Kategori);
                if (kat != null)
                {
                    item.Kategori = kat.Kod;
                }

                var ana = context.AnaGruplar.FirstOrDefault(x => x.AnaGrupAdi == item.AnaGrup);
                if (ana != null)
                {
                    item.AnaGrup = ana.Kod;
                }

                var alt = context.AltGruplar.FirstOrDefault(x => x.AltGrupAdi == item.AltGrup);
                if (alt != null)
                {
                    item.AltGrup = alt.Kod;
                }
                context.SaveChanges();

            }


        }
    }

    public class FaturaDizaynTemp
    {
        public string Path { get; set; }
        public string FileName { get; set; }
    }
}