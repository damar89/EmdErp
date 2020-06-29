using IniParser;
using IniParser.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace NetSatis.Entities.Tools
{
    public static class SettingsTool
    {
        static FileIniDataParser parser = new FileIniDataParser();
        static IniData data;
        static string dosyaAdi = "Settings.ini";

        public enum Ayarlar
        {
            SmsAyarları_KullanıcıAdı,
            SmsAyarları_Parola,
            SatisAyarlari_VarsayilanHareketTipi,
            SatisAyarlari_FaturaYazici,
            SatisAyarlari_Terazi,
            SatisAyarlari_TeraziPort,
            SatisAyarlari_BilgiFisiYazici,
            Irsaliye_Olussunmu,
            Irsaliye_CariEtkilesin,
            Irsaliye_StoguEtkilesin,
            SatisAyarlari_AlisFiyat,
            SatisAyarlari_ToptanFiyat,
            SatisAyarlari_StokGozukmesin,
            SatisAyarlari_CariGozukmesin,
            BilgiFisi_BilgiFisiYazdirilsinmi,
            BilgiFisi_BilgiFisiSorulsunmu,
            SatisAyarlari_FaturaYazirmaAyari,
            SatisAyarlari_BilgiFisiYazidirmaAyari,
            SatisAyarlari_TahsilatFisiYazidirmaAyari,
            YedeklemeAyarlari_YedeklemeKonumu,
            GenelAyarlar_GuncellemeKontrolu,
            DatabaseAyarlar_BaglantiCumlesi,
            SatisAyarlari_PesFisKodu,
            SatisAyarlari_PesFisOnEki,
            BarkodAyarlari_Barkodu,
            FirmaAyarlari_FirmaAdi,
            FaturaDizayn_DosyaAdi,
            FaturaDizayn_DosyaYolu,
            SiparisDizayn_DosyaAdi1,
            SiparisDizayn_DosyaYolu1,
            TeklifDizayn_DosyaAdi2,
            TeklifDizayn_DosyaYolu2,
            IrsaliyeDizayn_DosyaAdi3,
            IrsaliyeDizayn_DosyaYolu3,
            ProFaturaDizayn_DosyaAdi4,
            ProFaturaDizayn_DosyaYolu4,
            TahsilatDizayn_DosyaAdi5,
            TahsilatDizayn_DosyaYolu5,
            BilgiFisiDizayn_DosyaAdi6,
            BilgiFisiDizayn_DosyaYolu6,
            SatisStok_EksiyeDusme,
            SatisStok_MinMiktar,
            SatisStok_VarsayilanKdv,
            TemaAyarlari_Tema,
            Kooperatif_Kooperatifmi,
            Kooperatif_Zirai,
            Kooperatif_Borsa,
            Kooperatif_Bagkur,
            Kooperatif_Mera,
            SatisAyarlari_doviz,
            DolarKur_Usd,
            DolarKur_Euro,
            DolarKur_Rub,
            Lisans_LisansKey





        }
        static SettingsTool()
        {
            if (System.IO.File.Exists(Application.StartupPath + "\\" + dosyaAdi) == true)
            {
                data = parser.ReadFile(dosyaAdi);
            }
            else
            {
                using (System.IO.File.Create(Application.StartupPath + "\\" + dosyaAdi))
                {

                };

                data = parser.ReadFile(dosyaAdi);
            }
        }


        public static void AyarDegistir(Ayarlar ayar, string value)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));

            if (data != null)
            {
                if (data.Sections.Count(c => c.SectionName == gelenAyar[0]) == 0)
                {
                    data.Sections.AddSection(gelenAyar[0]);
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);

                }
                else
                {
                    data[gelenAyar[0]].AddKey(gelenAyar[1]);
                }

                data[gelenAyar[0]][gelenAyar[1]] = value;

            }
        }

        public static string AyarOku(Ayarlar ayar)
        {
            string[] gelenAyar = ayar.ToString().Split(Convert.ToChar("_"));
            return data[gelenAyar[0]][gelenAyar[1]];
        }

        public static void Save()
        {
            parser.WriteFile(dosyaAdi, data);

        }
    }
}
