using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
namespace NetSatis.Entities.Data_Access
{
    public class FisDAL : EntityRepositoryBase<NetSatisContext, Fis, FisValidator>
    {
        public object Fatura(NetSatisContext context, string fisKodu)
        {
            var tablo = context.Fisler.Where(c => c.FisKodu == fisKodu).GroupJoin(
                context.Fisler.Where(c => c.FisKodu == fisKodu), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                    new
                    {
                        fisler.Id,
                        fisler.FisKodu,
                        fisler.FisTuru,
                        fisler.ToplamTutar,
                        fisler.Cari.CariAdi,
                        fisler.Cari.CariKodu,
                        fisler.Tarih,
                        fisler.VadeTarihi,
                        fisler.Personel.PersonelKodu,
                        fisler.Personel.PersonelAdi,
                        fisler.Aciklama,
                        fisler.Seri,
                        fisler.Proje,
                        fisler.OzelKod,
                        fisler.Sira,
                        fisler.Tipi,
                        fisler.BelgeNo,
                        fisler.IskontoOrani1,
                        fisler.IskontoTutari1,
                        fisler.IskontoOrani2,
                        fisler.IskontoTutari2,
                        fisler.IskontoOrani3,
                        fisler.IskontoTutari3,
                        alacak =
                            (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası")
                                 .Sum(c => c.ToplamTutar) ?? 0) +
                            (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                                 .Sum(c => c.Tutar) ?? 0),
                        borc =
                            (context.Fisler.Where(c =>
                                     c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
                                 .Sum(c => c.ToplamTutar) ?? 0) +
                            (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                                 .Sum(c => c.Tutar) ?? 0)
                    }).Select(k => new
                    {
                        k.Id,
                        k.FisKodu,
                        k.FisTuru,
                        k.ToplamTutar,
                        k.CariAdi,
                        k.CariKodu,
                        k.Tarih,
                        k.VadeTarihi,
                        k.PersonelAdi,
                        k.PersonelKodu,
                        k.Seri,
                        k.Sira,
                        k.Proje,
                        k.OzelKod,
                        k.Tipi,
                        k.Aciklama,
                        k.BelgeNo,
                        k.IskontoOrani1,
                        k.IskontoTutari1,
                        k.borc,
                        k.alacak,
                        bakiye = k.alacak - k.borc
                    }).ToList();
            return tablo;
        }
        public object GunSonu(NetSatisContext context, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Proje,
                       fisler.OzelKod,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       fisler.Tipi,
                       fisler.EfaturaDurumu,
                       fisler.IrsaliyeFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.FaturaFisKodu,
                       fisler.TeklifFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.Tarih,
                       k.VadeTarihi,
                       k.PersonelKodu,
                       k.Proje,
                       k.OzelKod,
                       k.OdemeTuru,
                       k.PersonelAdi,
                       k.Seri,
                       k.Sira,
                       k.Tipi,
                       k.EfaturaDurumu,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.FaturaFisKodu,
                       k.IskontoTutari1,
                   }).ToList();
            return tablo;
        }
        public object Tahsilat(NetSatisContext context, string fisKodu, string CariId)
        {
            var tablo = context.Fisler.Where(c => c.FisKodu == fisKodu).GroupJoin(
                context.Fisler.Where(c => c.FisKodu == fisKodu), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                    new
                    {
                        fisler.Id,
                        fisler.FisKodu,
                        fisler.FisTuru,
                        fisler.ToplamTutar,
                        fisler.Cari.CariAdi,
                        fisler.Cari.CariKodu,
                        fisler.Tarih,
                        fisler.VadeTarihi,
                        fisler.Aciklama,
                        fisler.Personel.PersonelKodu,
                        fisler.Personel.PersonelAdi,
                        fisler.Seri,
                        fisler.Sira,
                        fisler.Proje,
                        fisler.OzelKod,
                        fisler.Tipi,
                        fisler.BelgeNo,
                        fisler.IskontoOrani1,
                        fisler.IskontoTutari1,
                        fisler.IskontoOrani2,
                        fisler.IskontoTutari2,
                        fisler.IskontoOrani3,
                        fisler.IskontoTutari3,
                        alacak =
                            (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası")
                                 .Sum(c => c.ToplamTutar) ?? 0) +
                            (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                                 .Sum(c => c.Tutar) ?? 0),
                        borc =
                            (context.Fisler.Where(c =>
                                     c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
                                 .Sum(c => c.ToplamTutar) ?? 0) +
                            (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                                 .Sum(c => c.Tutar) ?? 0)
                    }).Select(k => new
                    {
                        k.Id,
                        k.FisKodu,
                        k.FisTuru,
                        k.ToplamTutar,
                        k.CariAdi,
                        k.CariKodu,
                        k.Tarih,
                        k.VadeTarihi,
                        k.PersonelAdi,
                        k.PersonelKodu,
                        k.Seri,
                        k.Proje,
                        k.OzelKod,
                        k.Sira,
                        k.Tipi,
                        k.Aciklama,
                        k.BelgeNo,
                        k.IskontoOrani1,
                        k.IskontoTutari1,
                        k.borc,
                        k.alacak,
                        bakiye = k.alacak - k.borc
                    }).ToList();
            return tablo;
        }
        public FisKooperatif KooperatifFisi(NetSatisContext context, string fisKodu)
        {
            var fis = context.Fisler.FirstOrDefault(x => x.FisKodu == fisKodu);
            var kalemler = context.StokHareketleri.Where(x => x.FisKodu == fisKodu);
            FisKooperatif f = new FisKooperatif
            {
                FisKodu = fis.FisKodu,
                Aciklama = fis.Aciklama,
                Adres = fis.Adres,
                AraToplam_ = fis.AraToplam_,
                BelgeNo = fis.BelgeNo,
                CariAdi = fis.Cari.CariAdi,
                FaturaUnvani = fis.FaturaUnvani,
                Il = fis.Il,
                Ilce = fis.Ilce,
                Semt = fis.Semt,
                Tarih = fis.Tarih,
                ToplamTutar = fis.ToplamTutar,
                FisTuru = fis.FisTuru,
                VergiDairesi = fis.VergiDairesi,
                VergiNo = fis.VergiNo,
                Zirai = kalemler.Select(x => x.Zirai).DefaultIfEmpty(0).Sum(),
                Borsa = kalemler.Select(x => x.Borsa).DefaultIfEmpty(0).Sum(),
                Mera = kalemler.Select(x => x.Mera).DefaultIfEmpty(0).Sum(),
                Bagkur = kalemler.Select(x => x.Bagkur).DefaultIfEmpty(0).Sum(),
                ToplamTutarYazi = YaziyaCevir(fis.ToplamTutar.Value)
            };
            return f;
        }
        public List<FisKooperatifKalemler> KooperatifFisiKalemleri(NetSatisContext context, string fisKodu)
        {
            var kalemler = context.StokHareketleri.Where(x => x.FisKodu == fisKodu).Select(x => new FisKooperatifKalemler
            {
                StokKodu = x.Stok.StokKodu,
                StokAdi = x.Stok.StokAdi,
                Birim = x.Stok.Birim,
                Miktar = x.Miktar,
                Fiyat = x.BirimFiyati,
                Tutar = x.ToplamTutar,
                IskontoOrani1 = x.IndirimOrani,
                IskontoTutari1 = x.IndirimTutar
            }).ToList();
            return kalemler;
        }
        public object TumListelemeler(NetSatisContext context, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.Fisler.Where(c => c.Tarih >= baslangic && c.Tarih <= bitis), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       fisler.Proje,
                       fisler.OzelKod,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       fisler.Tipi,
                       fisler.EfaturaDurumu,
                       fisler.IrsaliyeFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.FaturaFisKodu,
                       fisler.TeklifFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.Tarih,
                       k.VadeTarihi,
                       k.PersonelKodu,
                       k.OdemeTuru,
                       k.PersonelAdi,
                       k.Proje,
                       k.OzelKod,
                       k.Seri,
                       k.Sira,
                       k.Tipi,
                       k.EfaturaDurumu,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.FaturaFisKodu,
                       k.IskontoTutari1,
                   }).ToList();
            return tablo;
        }
        public object Listelemeler(NetSatisContext context, string fisTuru)
        {
            var tablo = context.Fisler.Where(c => c.FisTuru == fisTuru).GroupJoin(
                context.Fisler.Where(c => c.FisTuru == fisTuru), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       fisler.Tipi,
                       fisler.Proje,
                       fisler.OzelKod,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       fisler.EfaturaDurumu,
                       fisler.IrsaliyeFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.FaturaFisKodu,
                       fisler.TeklifFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                       alacak =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                       .Sum(c => c.Tutar) ?? 0),
                       borc =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                       .Sum(c => c.Tutar) ?? 0)
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.Tarih,
                       k.VadeTarihi,
                       k.Proje,
                       k.OzelKod,
                       k.PersonelKodu,
                       k.PersonelAdi,
                       k.Seri,
                       k.OdemeTuru,
                       k.Sira,
                       k.Tipi,
                       k.EfaturaDurumu,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.FaturaFisKodu,
                       k.IskontoTutari1,
                       k.borc,
                       k.alacak,
                       bakiye = k.alacak - k.borc
                   }).ToList();
            return tablo;
        }
        public object SiparisFaturalandir(NetSatisContext context, string fisTuru, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => c.FisTuru == fisTuru && (c.Tarih >= baslangic && c.Tarih <= bitis)).GroupJoin(
                context.Fisler.Where(c => c.FisTuru == fisTuru), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       fisler.Tipi,
                       fisler.Proje,
                       fisler.OzelKod,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       fisler.EfaturaDurumu,
                       fisler.IrsaliyeFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.FaturaFisKodu,
                       fisler.TeklifFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                       alacak =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                       .Sum(c => c.Tutar) ?? 0),
                       borc =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                       .Sum(c => c.Tutar) ?? 0)
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.Tarih,
                       k.VadeTarihi,
                       k.Proje,
                       k.OzelKod,
                       k.PersonelKodu,
                       k.PersonelAdi,
                       k.Seri,
                       k.OdemeTuru,
                       k.Sira,
                       k.Tipi,
                       k.EfaturaDurumu,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.FaturaFisKodu,
                       k.IskontoTutari1,
                       k.borc,
                       k.alacak,
                       bakiye = k.alacak - k.borc
                   }).ToList();
            return tablo;
        }
        public object Listelemeler2(NetSatisContext context, string fisTuru, string fisTuru2, string fisTuru3, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => (c.FisTuru == fisTuru || c.FisTuru == fisTuru2 || c.FisTuru == fisTuru3) && (c.VadeTarihi >= baslangic && c.VadeTarihi <= bitis)).GroupJoin(
               context.Fisler.Where(c => (c.FisTuru == fisTuru || c.FisTuru == fisTuru2 || c.FisTuru == fisTuru3) && (c.VadeTarihi >= baslangic && c.VadeTarihi <= bitis)), c => c.CariId, c => c.CariId,
               (fisler, cariler) =>
                  new
                  {
                      fisler.Id,
                      fisler.FisKodu,
                      fisler.FisTuru,
                      fisler.ToplamTutar,
                      fisler.Cari.CariAdi,
                      fisler.Cari.CariKodu,
                      fisler.Tarih,
                      fisler.VadeTarihi,
                      fisler.Personel.PersonelKodu,
                      fisler.Personel.PersonelAdi,
                      fisler.Seri,
                      fisler.Sira,
                      fisler.Tipi,
                      fisler.Proje,
                      fisler.OzelKod,
                      fisler.EfaturaDurumu,
                      fisler.IrsaliyeFisKodu,
                      fisler.TeklifFisKodu,
                      fisler.SiparisFisKodu,
                      fisler.FaturaFisKodu,
                      fisler.Aciklama,
                      fisler.BelgeNo,
                      OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                      fisler.IskontoOrani1,
                      fisler.IskontoTutari1,
                      fisler.DipIskNetTutari,
                      alacak =
                      (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası")
                      .Sum(c => c.ToplamTutar) ?? 0) +
                      (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                      .Sum(c => c.Tutar) ?? 0),
                      borc =
                      (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
                      .Sum(c => c.ToplamTutar) ?? 0) +
                      (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                      .Sum(c => c.Tutar) ?? 0)
                  }).Select(k => new
                  {
                      k.Id,
                      k.FisKodu,
                      k.FisTuru,
                      k.ToplamTutar,
                      k.CariAdi,
                      k.CariKodu,
                      k.IrsaliyeFisKodu,
                      k.FaturaFisKodu,
                      k.SiparisFisKodu,
                      k.TeklifFisKodu,
                      k.Tarih,
                      k.OdemeTuru,
                      k.VadeTarihi,
                      k.PersonelKodu,
                      k.PersonelAdi,
                      k.Proje,
                      k.OzelKod,
                      k.Seri,
                      k.Sira,
                      k.Tipi,
                      k.EfaturaDurumu,
                      k.Aciklama,
                      k.BelgeNo,
                      k.IskontoOrani1,
                      k.IskontoTutari1,
                      k.DipIskNetTutari,
                      k.borc,
                      k.alacak,
                      bakiye = k.alacak - k.borc
                  }).ToList();
            return tablo;
        }
        public object ListelemelerTarih(NetSatisContext context, string fisTuru, string fisTuru2, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => (c.FisTuru == fisTuru || c.FisTuru == fisTuru2) && (c.Tarih >= baslangic && c.Tarih <= bitis)).GroupJoin(
                context.Fisler.Where(c => c.FisTuru == fisTuru || c.FisTuru == fisTuru2 && (c.Tarih >= baslangic && c.Tarih <= bitis)), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       fisler.Proje,
                       fisler.OzelKod,
                       fisler.Tipi,
                       fisler.EfaturaDurumu,
                       fisler.FaturaFisKodu,
                       fisler.IrsaliyeFisKodu,
                       fisler.TeklifFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                       fisler.DipIskNetTutari,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       alacak =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası" || c.FisTuru == "Satış İade Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                       .Sum(c => c.Tutar) ?? 0),
                       borc =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası" || c.FisTuru == "Alış İade Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                       .Sum(c => c.Tutar) ?? 0)
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.FaturaFisKodu,
                       k.Tarih,
                       k.OdemeTuru,
                       k.VadeTarihi,
                       k.PersonelKodu,
                       k.PersonelAdi,
                       k.Seri,
                       k.Sira,
                       k.Proje,
                       k.OzelKod,
                       k.Tipi,
                       k.EfaturaDurumu,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IskontoTutari1,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.borc,
                       k.alacak,
                       k.DipIskNetTutari,
                       bakiye = k.alacak - k.borc
                   }).ToList();
            return tablo;
        }
        public object ListelemelerTarihPerakende(NetSatisContext context, string fisTuru, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => (c.FisTuru == fisTuru) && (c.Tarih >= baslangic && c.Tarih <= bitis)).GroupJoin(
                context.Fisler.Where(c => (c.FisTuru == fisTuru) && (c.Tarih >= baslangic && c.Tarih <= bitis)), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       fisler.Tipi,
                       fisler.FaturaFisKodu,
                       fisler.IrsaliyeFisKodu,
                       fisler.Proje,
                       fisler.OzelKod,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       fisler.TeklifFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                       fisler.DipIskNetTutari,
                       alacak =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası" || c.FisTuru == "Satış İade Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                       .Sum(c => c.Tutar) ?? 0),
                       borc =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası" || c.FisTuru == "Alış İade Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                       .Sum(c => c.Tutar) ?? 0)
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.FaturaFisKodu,
                       k.Tarih,
                       k.VadeTarihi,
                       k.PersonelKodu,
                       k.PersonelAdi,
                       k.Seri,
                       k.Sira,
                       k.Tipi,
                       k.OdemeTuru,
                       k.Proje,
                       k.OzelKod,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IskontoTutari1,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.borc,
                       k.alacak,
                       k.DipIskNetTutari,
                       bakiye = k.alacak - k.borc
                   }).ToList();
            return tablo;
        }
        public object PerakendeFis(NetSatisContext context, string fisTuru, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.Fisler.Where(c => c.FisTuru == fisTuru && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.Fisler.Where(c => c.FisTuru == fisTuru && c.Tarih >= baslangic && c.Tarih <= bitis), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.ToplamTutar,
                       fisler.Cari.CariAdi,
                       fisler.Cari.CariKodu,
                       fisler.Tarih,
                       fisler.Proje,
                       fisler.OzelKod,
                       fisler.VadeTarihi,
                       fisler.Personel.PersonelKodu,
                       fisler.Personel.PersonelAdi,
                       fisler.Seri,
                       fisler.Sira,
                       fisler.Tipi,
                       fisler.FaturaFisKodu,
                       fisler.IrsaliyeFisKodu,
                       fisler.TeklifFisKodu,
                       fisler.SiparisFisKodu,
                       fisler.Aciklama,
                       fisler.BelgeNo,
                       fisler.IskontoOrani1,
                       fisler.IskontoTutari1,
                       OdemeTuru = (context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault() != null ?
                         context.OdemeTurleri.Where(x => x.Id == context.KasaHareketleri.Where(c => c.FisKodu == fisler.FisKodu).FirstOrDefault().OdemeTuruId).FirstOrDefault().OdemeTuruAdi
                                : "Acik Hesap"
                       ),
                       fisler.DipIskNetTutari,

                       alacak =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Alış Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Giriş")
                       .Sum(c => c.Tutar) ?? 0),
                       borc =
                       (context.Fisler.Where(c => c.CariId == fisler.Cari.Id && c.FisTuru == "Perakende Satış Faturası")
                       .Sum(c => c.ToplamTutar) ?? 0) +
                       (context.KasaHareketleri.Where(c => c.CariId == fisler.Cari.Id && c.Hareket == "Kasa Çıkış")
                       .Sum(c => c.Tutar) ?? 0)
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.ToplamTutar,
                       k.CariAdi,
                       k.CariKodu,
                       k.Tarih,
                       k.VadeTarihi,
                       k.PersonelKodu,
                       k.PersonelAdi,
                       k.Seri,
                       k.OdemeTuru,
                       k.Sira,
                       k.Tipi,
                       k.Proje,
                       k.OzelKod,
                       k.FaturaFisKodu,
                       k.IrsaliyeFisKodu,
                       k.TeklifFisKodu,
                       k.SiparisFisKodu,
                       k.Aciklama,
                       k.BelgeNo,
                       k.IskontoOrani1,
                       k.IskontoTutari1,
                       k.DipIskNetTutari,
                       k.borc,
                       k.alacak,

                       bakiye = k.alacak - k.borc
                   }).ToList();
            return tablo;
        }
        string YaziyaCevir(decimal cevir)
        {
            string sTutar = cevir.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";
            string[] birler = { "", "BİR", "İKİ", "Üç", "DÖRT", "BEŞ", "ALTI", "YEDİ", "SEKİZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YİRMİ", "OTUZ", "KIRK", "ELLİ", "ALTMIŞ", "YETMİŞ", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRİLYON", "TRİLYON", "MİLYAR", "MİLYON", "BİN", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.
            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.
            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            
            string grupDegeri;
            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";
                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YÜZ"; //yüzler                
                if (grupDegeri == "BİRYÜZ") //biryüz düzeltiliyor.
                    grupDegeri = "YÜZ";
                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar
                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                
                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];
                if (grupDegeri == "BİRBİN") //birbin düzeltiliyor.
                    grupDegeri = "BİN";
                yazi += grupDegeri;
            }
            if (yazi != "")
                yazi += " TL ";
            int yaziUzunlugu = yazi.Length;
            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];
            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];
            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "SIFIR Kr.";
            return yazi;
        }
    }
}