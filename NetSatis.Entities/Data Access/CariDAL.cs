using System;
using System.Collections.Generic;
using System.Linq;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using NetSatis.Entities.Validations;
namespace NetSatis.Entities.Data_Access
{
    public class CariDAL : EntityRepositoryBase<NetSatisContext, Cari, CariValidator>
    {
        public object GetCariler(NetSatisContext context)
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.Id, c => c.CariId,
                (cariler, fisler) => new
                {
                    #region pt1
                    cariler.Id,
                    cariler.Durum,
                    cariler.CariTuru,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.CariSinif,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.CepTelefonu2,
                    cariler.CepTelefonu3,
                    cariler.Telefon,
                    cariler.Telefon2,
                    cariler.Telefon3,
                    cariler.EMail2,
                    cariler.Fax,
                    cariler.EMail,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.Adres2,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,
                    AlisToplam = fisler.Where(c => c.FisTuru == "Alış Faturası" || c.FisTuru == "Perakende İade İrsaliyesi" || c.FisTuru == "Perakende İade Faturası"
                    || c.FisTuru == "Satış İade Faturası"
                    || (c.FisTuru == "Alış İrsaliyesi" && c.CariIrsaliye == "1")
                    ).Sum(c => c.ToplamTutar) ?? 0,
                    SatisToplam = fisler.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası"
                    || c.FisTuru == "Alış İade Faturası"
                    || c.FisTuru == "Perakende Satış İrsaliyesi"
                    || (c.FisTuru == "Satış İrsaliyesi" && c.CariIrsaliye == "1")
                    ).Sum(c => c.ToplamTutar) ?? 0,
                    #endregion
                }).GroupJoin(context.KasaHareketleri, c => c.Id, c => c.CariId, (cariler, kasahareket) => new
                {
                    cariler.Id,
                    cariler.Durum,
                    cariler.CariTuru,
                    cariler.CariSinif,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.CepTelefonu2,
                    cariler.CepTelefonu3,
                    cariler.Telefon,
                    cariler.Telefon2,
                    cariler.Telefon3,
                    cariler.EMail2,
                    cariler.Fax,
                    cariler.EMail,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.Adres2,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,
                    Alacak = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                    Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiye = (cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)) -
                    (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)),
                }).Select(k => new
                {
                    k.Id,
                    k.Durum,
                    k.CariTuru,
                    k.CariKodu,
                    k.CariAdi,
                    k.CariSinif,
                    k.YetkiliKisi,
                    k.FaturaUnvani,
                    k.CepTelefonu,
                    k.CepTelefonu2,
                    k.CepTelefonu3,
                    k.Telefon,
                    k.Telefon2,
                    k.Telefon3,
                    k.EMail2,
                    k.Fax,
                    k.EMail,
                    k.Web,
                    k.Il,
                    k.Ilce,
                    k.Adres2,
                    k.Semt,
                    k.Adres,
                    k.CariGrubu,
                    k.CariAltGrubu,
                    k.OzelKod1,
                    k.OzelKod2,
                    k.OzelKod3,
                    k.OzelKod4,
                    k.VergiNo,
                    k.VergiDairesi,
                    k.IskontoOrani,
                    k.RiskLimiti,
                    k.AlisOzelFiyati,
                    k.SatisOzelFiyati,
                    k.Aciklama,
                    k.Alacak,
                    k.Borc,
                    k.Bakiye,
                    HesapBakiye = k.Alacak - k.Borc > 0 ? "Alacaklı" : k.Alacak - k.Borc < 0 ? "Borçlu" : "-"
                })
                .ToList();
            return result;
        }
        public object GetCariler2(NetSatisContext context, string CariId)
        {
            var result = context.Cariler.GroupJoin(context.Fisler, c => c.Id, c => c.CariId,
                (cariler, fisler) => new
                {
                    #region pt1
                    cariler.Id,
                    cariler.Durum,
                    cariler.CariTuru,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.CariSinif,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.CepTelefonu2,
                    cariler.CepTelefonu3,
                    cariler.Telefon,
                    cariler.Telefon2,
                    cariler.Telefon3,
                    cariler.EMail2,
                    cariler.Fax,
                    cariler.EMail,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,
                    AlisToplam = fisler.Where(c => c.FisTuru == "Alış Faturası" || c.FisTuru == "Perakende İade İrsaliyesi" || c.FisTuru == "Perakende İade Faturası"
                    || c.FisTuru == "Satış İade Faturası"
                    || (c.FisTuru == "Alış İrsaliyesi" && c.CariIrsaliye == "1")
                    ).Sum(c => c.ToplamTutar) ?? 0,
                    SatisToplam = fisler.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası"
                    || c.FisTuru == "Alış İade Faturası"
                    || c.FisTuru == "Perakende Satış İrsaliyesi"
                    || (c.FisTuru == "Satış İrsaliyesi" && c.CariIrsaliye == "1")
                    ).Sum(c => c.ToplamTutar) ?? 0,
                    #endregion
                }).GroupJoin(context.KasaHareketleri, c => c.Id, c => c.CariId, (cariler, kasahareket) => new
                {
                    cariler.Id,
                    cariler.Durum,
                    cariler.CariTuru,
                    cariler.CariSinif,
                    cariler.CariKodu,
                    cariler.CariAdi,
                    cariler.YetkiliKisi,
                    cariler.FaturaUnvani,
                    cariler.CepTelefonu,
                    cariler.CepTelefonu2,
                    cariler.CepTelefonu3,
                    cariler.Telefon,
                    cariler.Telefon2,
                    cariler.Telefon3,
                    cariler.EMail2,
                    cariler.Fax,
                    cariler.EMail,
                    cariler.Web,
                    cariler.Il,
                    cariler.Ilce,
                    cariler.Semt,
                    cariler.Adres,
                    cariler.CariGrubu,
                    cariler.CariAltGrubu,
                    cariler.OzelKod1,
                    cariler.OzelKod2,
                    cariler.OzelKod3,
                    cariler.OzelKod4,
                    cariler.VergiNo,
                    cariler.VergiDairesi,
                    cariler.IskontoOrani,
                    cariler.RiskLimiti,
                    cariler.AlisOzelFiyati,
                    cariler.SatisOzelFiyati,
                    cariler.Aciklama,
                    Alacak = cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0),
                    Borc = cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0),
                    Bakiye = (cariler.SatisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Çıkış").Sum(c => c.Tutar) ?? 0)) -
                    (cariler.AlisToplam + (kasahareket.Where(c => c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ?? 0)),
                }).Select(k => new
                {
                    k.Id,
                    k.Durum,
                    k.CariTuru,
                    k.CariKodu,
                    k.CariAdi,
                    k.CariSinif,
                    k.YetkiliKisi,
                    k.FaturaUnvani,
                    k.CepTelefonu,
                    k.CepTelefonu2,
                    k.CepTelefonu3,
                    k.Telefon,
                    k.Telefon2,
                    k.Telefon3,
                    k.EMail2,
                    k.Fax,
                    k.EMail,
                    k.Web,
                    k.Il,
                    k.Ilce,
                    k.Semt,
                    k.Adres,
                    k.CariGrubu,
                    k.CariAltGrubu,
                    k.OzelKod1,
                    k.OzelKod2,
                    k.OzelKod3,
                    k.OzelKod4,
                    k.VergiNo,
                    k.VergiDairesi,
                    k.IskontoOrani,
                    k.RiskLimiti,
                    k.AlisOzelFiyati,
                    k.SatisOzelFiyati,
                    k.Aciklama,
                    k.Alacak,
                    k.Borc,
                    k.Bakiye,
                    HesapBakiye = k.Alacak - k.Borc > 0 ? "Alacaklı" : k.Alacak - k.Borc < 0 ? "Borçlu" : "-"
                })
                .ToList();
            return result;
        }
        public object CariFisAyrinti(NetSatisContext context, int cariId)
        {
            var result = context.Fisler.Where(c => c.CariId == cariId).OrderBy(f => f.Tarih).Select(k => new
            {
                k.Tarih,
                k.VadeTarihi,
                k.Id,
                k.FisKodu,
                k.FisTuru,
                k.Personel.PersonelKodu,
                k.Personel.PersonelAdi,
                k.BelgeNo,
                k.IskontoOrani1,
                k.IskontoTutari1,
                k.Aciklama,
                k.ToplamTutar,
                kasaHareket = k.FisTuru == "Cari Devir Fişi" ?
                         context.KasaHareketleri.FirstOrDefault(x => x.FisKodu == k.FisKodu).Hareket : "-",
                Odenen = context.KasaHareketleri.Where(c => c.FisKodu == k.FisKodu).Sum(c => c.Tutar) ?? 0,
                KalanOdeme = k.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == k.FisKodu).Sum(c => c.Tutar) ?? 0)
            }).Select(s => new
            {
                s.Tarih,
                s.VadeTarihi,
                s.Id,
                s.FisKodu,
                s.FisTuru,
                s.PersonelKodu,
                s.PersonelAdi,
                s.BelgeNo,
                s.IskontoOrani1,
                s.IskontoTutari1,
                s.Aciklama,
                s.ToplamTutar,
                s.Odenen,
                s.KalanOdeme,
                s.kasaHareket,
                Durum = (s.FisTuru == "Alış Faturası" || s.FisTuru == "Satış İade Faturası" || s.FisTuru == "Tahsilat Fişi" || (s.FisTuru == "Cari Devir Fişi" && s.kasaHareket == "Kasa Giriş")) ?
                s.ToplamTutar - s.Odenen > 0 ? "A" : s.ToplamTutar - s.Odenen < 0 ? "B" : "K" :
                s.ToplamTutar - s.Odenen > 0 ? "B" : s.ToplamTutar - s.Odenen < 0 ? "A" : "K",
                AktifTutar = context.Fisler.Where(c => c.CariId == cariId && c.Tarih <= s.Tarih).Select(j => new
                {
                    j.FisTuru,
                    kasaHareket = j.FisTuru == "Cari Devir Fişi" ?
                    context.KasaHareketleri.FirstOrDefault(x => x.FisKodu == j.FisKodu).Hareket : "-",
                    j.ToplamTutar,
                    Odenen = context.KasaHareketleri.Where(c => c.FisKodu == j.FisKodu).Sum(c => c.Tutar) ?? 0,
                    KalanOdeme = j.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == j.FisKodu).Sum(c => c.Tutar) ?? 0),
                    j.CariIrsaliye
                }).Select(l => new
                {
                    kDurum =
                        (l.FisTuru == "Alış Faturası" || l.FisTuru == "Satış İade Faturası" || l.FisTuru == "Perakende İade Faturası") ? (l.KalanOdeme > 0 ? l.KalanOdeme * -1 : l.KalanOdeme) :
                        (l.FisTuru == "Tahsilat Fişi" ||
                         (l.FisTuru == "Cari Devir Fişi" && l.kasaHareket == "Kasa Giriş")) ? l.Odenen * -1 :
                                (l.FisTuru == "Tahsilat Fişi" || (l.FisTuru == "Cari Devir Fişi" && l.kasaHareket == "Kasa Çıkış")) ? l.Odenen :
                                    (l.FisTuru == "Ödeme Fişi") ? l.Odenen :
                                    (l.FisTuru == "Perakende Satış İrsaliyesi") ? l.KalanOdeme :
                                    (l.FisTuru == "Perakende İade İrsaliyesi") ? l.KalanOdeme * -1 :
                                       (l.FisTuru.Contains("Alış İrsaliye") && l.CariIrsaliye == "1") ? l.KalanOdeme * -1 :
                                       (l.FisTuru.Contains("Satış İrsaliye") && l.CariIrsaliye == "1") ? l.KalanOdeme :
                                    (l.FisTuru.Contains("İrsaliye")
                                    ||
                                    l.FisTuru.Contains("Sipariş") || l.FisTuru.Contains("Teklif")) ? 0 :
                                    l.KalanOdeme
                }).Sum(t => t.kDurum) ?? 0
            }).ToList();
            return result;
        }
        public object CariFisAyrintiStok(NetSatisContext context, int cariId, DateTime baslangic, DateTime bitis)
        {
            var fisler = context.Fisler.Where(x => x.CariId == cariId && x.Tarih >= baslangic && x.Tarih <= bitis).OrderBy(f => f.Tarih).ToList();
            List<KooperatifEkstreModel> liste = new List<KooperatifEkstreModel>();
            foreach (var fis in fisler)
            {
                if (fis.FisTuru.Contains("Fatura"))
                {
                    //stokhareket
                    var list = context.StokHareketleri.Where(x => x.FisKodu == fis.FisKodu).Select(x =>
                        new KooperatifEkstreModel
                        {
                            IslemTarihi = (DateTime)fis.Tarih,
                            IslemTuru = fis.FisTuru,
                            UrunAdi = x.Stok.StokAdi,
                            Miktar = x.Miktar,
                            Birim = x.Stok.Birim,
                            FisKodu = fis.FisKodu,
                            SatirTutari = x.BirimFiyati * x.Miktar,
                            IndirimTutari=x.IndirimTutar,
                            DipIndirim=x.DipIskontoPayi,
                            BirimFiyat = x.BirimFiyati,
                            //SatirTutari = x.ToplamTutar,
                            FisTutari = x.BirimFiyati*x.Miktar-(x.DipIskontoPayi+x.IndirimTutar),
                            Aciklama = fis.Aciklama,
                            ZiraiToplam = x.Zirai,
                            MeraToplam = x.Mera,
                            BagkurToplam = x.Bagkur,
                            BorsaToplam = x.Borsa
                        }).ToList();
                    foreach (var item in list)
                    {
                        item.ZiraiToplam = (item.SatirTutari * item.ZiraiToplam) / 100;
                        item.BorsaToplam = (item.SatirTutari * item.BorsaToplam) / 100;
                        item.BagkurToplam = (item.SatirTutari * item.BagkurToplam) / 100;
                    }
                    liste.AddRange(list);
                }
                else
                {
                    //Kasahareket
                    var list = context.KasaHareketleri.Where(x => x.FisKodu == fis.FisKodu).Select(x =>
                        new KooperatifEkstreModel
                        {
                            IslemTarihi = (DateTime)fis.Tarih,
                            IslemTuru = fis.FisTuru,
                            UrunAdi = "",
                            Miktar = 0,
                            Birim = "",
                            //SatirTutari = x.Tutar,
                            Aciklama = x.Aciklama,
                            FisTutari = fis.ToplamTutar,
                            ZiraiToplam = 0,
                            MeraToplam = 0,
                            BagkurToplam = 0,
                            BorsaToplam = 0
                        }).ToList();
                    liste.AddRange(list);
                }
            }
            return liste;
        }
        public object CariFisAyrinti(NetSatisContext context, int cariId, DateTime baslangic, DateTime bitis)
        {
            var str = "İrsaliye";
            if (Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.Irsaliye_CariEtkilesin)))
            {
                str = "";
            }
            var result = context.Fisler.Where(c => c.CariId == cariId && c.Tarih >= baslangic && c.Tarih <= bitis).OrderBy(f => f.Tarih).Select(k => new
            {
                k.Tarih,
                k.VadeTarihi,
                k.Id,
                k.FisKodu,
                k.FisTuru,
                k.Personel.PersonelKodu,
                k.Personel.PersonelAdi,
                k.BelgeNo,
                k.IskontoOrani1,
                k.IskontoTutari1,
                k.Aciklama,
                k.ToplamTutar,
                kasaHareket = k.FisTuru == "Cari Devir Fişi" ?
                         context.KasaHareketleri.FirstOrDefault(x => x.FisKodu == k.FisKodu).Hareket : "-",
                Odenen = context.KasaHareketleri.Where(c => c.FisKodu == k.FisKodu).Sum(c => c.Tutar) ?? 0,
                KalanOdeme = k.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == k.FisKodu).Sum(c => c.Tutar) ?? 0)
            }).Select(s => new
            {
                s.Tarih,
                s.VadeTarihi,
                s.Id,
                s.FisKodu,
                s.FisTuru,
                s.PersonelKodu,
                s.PersonelAdi,
                s.BelgeNo,
                s.IskontoOrani1,
                s.IskontoTutari1,
                s.Aciklama,
                s.ToplamTutar,
                s.Odenen,
                s.KalanOdeme,
                s.kasaHareket,
                Durum = (s.FisTuru == "Alış Faturası" || s.FisTuru == "Satış İade Faturası" || s.FisTuru == "Tahsilat Fişi" || (s.FisTuru == "Cari Devir Fişi" && s.kasaHareket == "Kasa Giriş")) ?
                s.ToplamTutar - s.Odenen > 0 ? "A" : s.ToplamTutar - s.Odenen < 0 ? "B" : "K" :
                s.ToplamTutar - s.Odenen > 0 ? "B" : s.ToplamTutar - s.Odenen < 0 ? "A" : "K",
                AktifTutar = context.Fisler.Where(c => c.CariId == cariId && c.Tarih <= s.Tarih).Select(j => new
                {
                    j.FisTuru,
                    kasaHareket = j.FisTuru == "Cari Devir Fişi" ?
                    context.KasaHareketleri.FirstOrDefault(x => x.FisKodu == j.FisKodu).Hareket : "-",
                    j.ToplamTutar,
                    Odenen = context.KasaHareketleri.Where(c => c.FisKodu == j.FisKodu).Sum(c => c.Tutar) ?? 0,
                    KalanOdeme = j.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == j.FisKodu).Sum(c => c.Tutar) ?? 0),
                    j.CariIrsaliye
                }).Select(l => new
                {
                    kDurum =
                        (l.FisTuru == "Alış Faturası" || l.FisTuru == "Satış İade Faturası" || l.FisTuru == "Perakende İade Faturası") ? (l.KalanOdeme > 0 ? l.KalanOdeme * -1 : l.KalanOdeme) :
                        (l.FisTuru == "Tahsilat Fişi" ||
                         (l.FisTuru == "Cari Devir Fişi" && l.kasaHareket == "Kasa Giriş")) ? l.Odenen * -1 :
                                (l.FisTuru == "Tahsilat Fişi" || (l.FisTuru == "Cari Devir Fişi" && l.kasaHareket == "Kasa Çıkış")) ? l.Odenen :
                                    (l.FisTuru == "Ödeme Fişi") ? l.Odenen :
                                    (l.FisTuru == "Perakende Satış İrsaliyesi") ? l.KalanOdeme :
                                    (l.FisTuru == "Perakende İade İrsaliyesi") ? l.KalanOdeme * -1 :
                                       (l.FisTuru.Contains("Alış İrsaliye") && l.CariIrsaliye == "1") ? l.KalanOdeme * -1 :
                                       (l.FisTuru.Contains("Satış İrsaliye") && l.CariIrsaliye == "1") ? l.KalanOdeme :
                                    (l.FisTuru.Contains("İrsaliye")
                                    ||
                                    l.FisTuru.Contains("Sipariş") || l.FisTuru.Contains("Teklif")) ? 0 :
                                    l.KalanOdeme
                }).Sum(t => t.kDurum) ?? 0
            }).ToList();
            #region Eski
            //var result = asd.Select(fisler => new
            //{
            //    fisler.Tarih,
            //    fisler.VadeTarihi,
            //    fisler.Id,
            //    fisler.FisKodu,
            //    fisler.FisTuru,
            //    fisler.Personel.PersonelKodu,
            //    fisler.Personel.PersonelAdi,
            //    fisler.BelgeNo,
            //    fisler.IskontoOrani1,
            //    fisler.IskontoTutari1,
            //    fisler.Aciklama,
            //    fisler.ToplamTutar,
            //    kasaHareket = fisler.FisTuru == "Cari Devir Fişi" ?
            //            context.KasaHareketleri.FirstOrDefault(x => x.FisKodu == fisler.FisKodu).Hareket : "-",
            //    Odenen = context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0,
            //    KalanOdeme = fisler.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0)
            //}).Select(s => new
            //{
            //    s.Tarih,
            //    s.VadeTarihi,
            //    s.Id,
            //    s.FisKodu,
            //    s.FisTuru,
            //    s.PersonelKodu,
            //    s.PersonelAdi,
            //    s.BelgeNo,
            //    s.IskontoOrani1,
            //    s.IskontoTutari1,
            //    s.Aciklama,
            //    s.ToplamTutar,
            //    s.Odenen,
            //    s.KalanOdeme,
            //    Durum = (s.FisTuru == "Alış Faturası" || s.FisTuru == "Satış İade Faturası" || s.FisTuru == "Tahsilat Fişi" || (s.FisTuru == "Cari Devir Fişi" && s.kasaHareket == "Kasa Giriş")) ?
            //    s.ToplamTutar - s.Odenen > 0 ? "A" : s.ToplamTutar - s.Odenen < 0 ? "B" : "K" :
            //    s.ToplamTutar - s.Odenen > 0 ? "B" : s.ToplamTutar - s.Odenen < 0 ? "A" : "K",
            //    AktifTutar = asd.Where(c => c.Id <= s.Id).
            //    Select(fisler => new
            //    {
            //        fisler.FisTuru,
            //        fisler.ToplamTutar,
            //        kasaHareket = fisler.FisTuru == "Cari Devir Fişi" ?
            //        context.KasaHareketleri.FirstOrDefault(x => x.FisKodu == fisler.FisKodu).Hareket : "-",
            //        Odenen = context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0,
            //        KalanOdeme = fisler.ToplamTutar - (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).Sum(c => c.Tutar) ?? 0)
            //    }).Select(l => new
            //    {
            //        kDurum = (l.FisTuru == "Alış Faturası" || l.FisTuru == "Satış İade Faturası") ?
            //                l.ToplamTutar - l.Odenen > 0 ? (l.ToplamTutar - l.Odenen) * -1 : (l.ToplamTutar - l.Odenen) : (l.FisTuru == "Tahsilat Fişi" || (l.FisTuru == "Cari Devir Fişi" && l.kasaHareket == "Kasa Giriş")) ? l.Odenen * -1 : l.Odenen
            //    }).Sum(t => t.kDurum) ?? 0
            //}).ToList(); 
            #endregion
            return result;
        }
        public object CariFisGenelToplam(NetSatisContext context, int cariId)
        {
            var result = (from c in context.Fisler.Where(c => c.CariId == cariId)
                          group c by new { c.FisTuru }
                into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              Tutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }
        // public object GunlukRapor(NetSatisContext context, DateTime baslangic,DateTime bitis)
        //{
        //    var result = (from c in context.Fisler.Where(c => c.CariId == cariId)
        //                  group c by new { c.FisTuru }
        //        into grp
        //                  select new
        //                  {
        //                      Bilgi = grp.Key.FisTuru,
        //                      KayitSayisi = grp.Count(),
        //                      Tutar = grp.Sum(c => c.ToplamTutar)
        //                  }).ToList();
        //    return result;
        //}
        public object CariGenelToplam(NetSatisContext context, int cariId)
        {
            string[] Faturalar = { "Alış Faturası", "Satış İade Faturası", "Perakende İade İrsaliyesi", "Perakende İade Faturası" };
            string[] SatisFaturalar = { "Perakende Satış Faturası", "Toptan Satış Faturası", "Alış İade Faturası", "Perakende Satış İrsaliyesi" };

            decimal alacak = (context.Fisler.Where(c => c.CariId == cariId && (SatisFaturalar.Contains(c.FisTuru)
                || (c.FisTuru == "Satış İrsaliyesi" && c.CariIrsaliye == "1"))

            )
                     .Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariId == cariId && c.Hareket == "Kasa Çıkış")
                     .Sum(c => c.Tutar) ?? 0);
            decimal borc = (context.Fisler.Where(c => c.CariId == cariId && (Faturalar.Contains(c.FisTuru)
             || (c.FisTuru == "Alış İrsaliyesi" && c.CariIrsaliye == "1"))

            )
                 .Sum(c => c.ToplamTutar) ?? 0) +
            (context.KasaHareketleri.Where(c => c.CariId == cariId && c.Hareket == "Kasa Giriş")
                 .Sum(c => c.Tutar) ?? 0);
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam()
                {
                    Bilgi = "Alacak",
                    Tutar = alacak
                },
                new GenelToplam()
                {
                Bilgi = "Borç",
                Tutar = borc
            },
                new GenelToplam()
                {
                    Bilgi = "Bakiye",
                    Tutar = alacak-borc
                }
            };
            return genelToplamlar;
        }
        public object CariGenelToplam(NetSatisContext context, int cariId, DateTime baslangic, DateTime bitis) //Olmuyor
        {
            string[] Faturalar = { "Alış Faturası", "Satış İade Faturası", "Perakende İade İrsaliyesi", "Perakende İade Faturası" }; //Ödeme Fişi
            string[] SatisFaturalar = { "Perakende Satış Faturası", "Toptan Satış Faturası", "Alış İade Faturası", "Perakende Satış İrsaliyesi" }; //Tahsilat Fişi
            decimal alacak =
                (context.Fisler.Where(c => c.CariId == cariId && c.Tarih >= baslangic && c.Tarih <= bitis && SatisFaturalar.Contains(c.FisTuru))
                     .Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariId == cariId && c.Tarih >= baslangic && c.Tarih <= bitis && c.Hareket == "Kasa Çıkış")
                     .Sum(c => c.Tutar) ?? 0);
            decimal borc =
                (context.Fisler.Where(c => c.CariId == cariId && c.Tarih >= baslangic && c.Tarih <= bitis && Faturalar.Contains(c.FisTuru))
                 .Sum(c => c.ToplamTutar) ?? 0) +
            (context.KasaHareketleri.Where(c => c.CariId == cariId && c.Tarih >= baslangic && c.Tarih <= bitis && c.Hareket == "Kasa Giriş")
                 .Sum(c => c.Tutar) ?? 0);
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam()
                {
                    Bilgi = "Alacak",
                    Tutar = alacak
                },
                new GenelToplam()
                {
                Bilgi = "Borç",
                Tutar = borc
            },
                new GenelToplam()
                {
                    Bilgi = "Bakiye",
                    Tutar = alacak-borc
                }
            };
            return genelToplamlar;
        }
        public CariBakiye cariBakiyesi(NetSatisContext context, int cariId)
        {
            string[] Faturalar = { "Alış Faturası", "Satış İade Faturası", "Perakende İade İrsaliyesi", "Perakende İade Faturası" };
            string[] SatisFaturalar = { "Perakende Satış Faturası", "Toptan Satış Faturası", "Alış İade Faturası", "Perakende Satış İrsaliyesi" };
            decimal borc =
                (context.Fisler.Where(c => c.CariId == cariId && SatisFaturalar.Contains(c.FisTuru))
                     .Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariId == cariId && c.Hareket == "Kasa Çıkış")
                     .Sum(c => c.Tutar) ?? 0);
            decimal alacak =
                (context.Fisler.Where(c => c.CariId == cariId && Faturalar.Contains(c.FisTuru))
                     .Sum(c => c.ToplamTutar) ?? 0) +
                (context.KasaHareketleri.Where(c => c.CariId == cariId && c.Hareket == "Kasa Giriş")
                     .Sum(c => c.Tutar) ?? 0);
            CariBakiye entity = new CariBakiye
            {
                CariId = cariId,
                //RiskLimiti = Convert.ToDecimal(context.Cariler.Where(c => c.Id == cariId).SingleOrDefault().RiskLimiti),
                Alacak = alacak,
                Borc = borc,
                Bakiye = borc - alacak,
            };
            return entity;
        }
        public Cari GetByFilter(NetSatisContext context, Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
