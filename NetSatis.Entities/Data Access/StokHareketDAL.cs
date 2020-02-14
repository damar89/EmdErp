using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
namespace NetSatis.Entities.Data_Access
{
    public class StokHareketDAL : EntityRepositoryBase<NetSatisContext, StokHareket, StokHareketValidator>
    {
        public object GetAll2(NetSatisContext context, Expression<Func<StokHareket, bool>> filter = null)
        {
            if (filter == null)
            {
                var result = context.StokHareketleri.GroupJoin(context.Fisler, s => s.FisKodu, f => f.FisKodu, (stokHareket, fisler)
              => new
              {
                  stokHareket.Id,
                  stokHareket.FisKodu,
                  stokHareket.FisTuru,
                  stokHareket.Hareket,
                  stokHareket.StokId,
                  stokHareket.Miktar,
                  stokHareket.Kdv,
                  stokHareket.BirimFiyati,
                  stokHareket.DepoId,
                  stokHareket.SeriNo,
                  KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == stokHareket.Stok.Kategori).KategoriAdi ?? "",
                  AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == stokHareket.Stok.AltGrup).AltGrupAdi ?? "",
                  AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == stokHareket.Stok.AnaGrup).AnaGrupAdi ?? "",
                  stokHareket.Tarih,
                  stokHareket.Aciklama,
                  stokHareket.Stok,
                  stokHareket.Depo,
                  stokHareket.IndirimOrani,
                  stokHareket.IndirimOrani2,
                  stokHareket.IndirimOrani3,
                  stokHareket.IndirimTutar,
                  stokHareket.Borsa,
                  stokHareket.Bagkur,
                  stokHareket.Mera,
                  stokHareket.Zirai,
                  stokHareket.ToplamTutar,
                  stokHareket.StokIrsaliye,
                  stokHareket.DipIskontoPayi,
                  c = context.Fisler.FirstOrDefault(x => x.FisKodu == stokHareket.FisKodu).Cari
              }).Select(y => new
              {
                  y.Id,
                  y.FisKodu,
                  Hareket = (y.FisTuru == "Satış İrsaliyesi" && y.StokIrsaliye == "1") ? "Stok Çıkış" : (y.FisTuru == "Alış İrsaliyesi" && y.StokIrsaliye == "1") ? "Stok Giriş"
                  : y.Hareket,
                  y.FisTuru,
                  y.StokId,
                  y.Miktar,
                  y.Kdv,
                  y.BirimFiyati,
                  y.DepoId,
                  y.SeriNo,
                  y.KategoriAdi,
                  y.AnaGrupAdi,
                  y.AltGrupAdi,
                  y.Tarih,
                  y.Aciklama,
                  y.Borsa,
                  y.Bagkur,
                  y.Mera,
                  y.Zirai,
                  y.Stok,
                  y.Depo,
                  y.IndirimOrani,
                  y.IndirimOrani2,
                  y.IndirimOrani3,
                  y.IndirimTutar,
                  y.DipIskontoPayi,
                  y.c.CariAdi,
                  y.ToplamTutar,
                  y.c.CariKodu
              }).ToList();
                return result;
            }
            else
            {
                var result = context.StokHareketleri.Where(filter).GroupJoin(context.Fisler, s => s.FisKodu, f => f.FisKodu, (stokHareket, fisler)
              => new
              {
                  stokHareket.Id,
                  stokHareket.FisKodu,
                  stokHareket.FisTuru,
                  stokHareket.Hareket,
                  stokHareket.StokId,
                  stokHareket.Miktar,
                  stokHareket.Kdv,
                  stokHareket.BirimFiyati,
                  stokHareket.DepoId,
                  stokHareket.SeriNo,
                  KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == stokHareket.Stok.Kategori).KategoriAdi ?? "",
                  AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == stokHareket.Stok.AltGrup).AltGrupAdi ?? "",
                  AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == stokHareket.Stok.AnaGrup).AnaGrupAdi ?? "",
                  stokHareket.Tarih,
                  stokHareket.Aciklama,
                  stokHareket.Stok,
                  stokHareket.Depo,
                  stokHareket.IndirimOrani,
                  stokHareket.IndirimOrani2,
                  stokHareket.IndirimOrani3,
                  stokHareket.DipIskontoPayi,
                  stokHareket.IndirimTutar,
                  stokHareket.Borsa,
                  stokHareket.Bagkur,
                  stokHareket.Mera,
                  stokHareket.Zirai,
                  stokHareket.ToplamTutar,
                  stokHareket.StokIrsaliye,
                  c = context.Fisler.FirstOrDefault(x => x.FisKodu == stokHareket.FisKodu).Cari
              }).Select(y => new
              {
                  y.Id,
                  y.FisKodu,
                  Hareket = (y.FisTuru == "Satış İrsaliyesi" && y.StokIrsaliye == "1") ? "Stok Çıkış" : (y.FisTuru == "Alış İrsaliyesi" && y.StokIrsaliye == "1") ? "Stok Giriş" : y.Hareket,
                  y.FisTuru,
                  y.StokId,
                  y.Miktar,
                  y.Kdv,
                  y.BirimFiyati,
                  y.DepoId,
                  y.SeriNo,
                  y.KategoriAdi,
                  y.AnaGrupAdi,
                  y.AltGrupAdi,
                  y.Tarih,
                  y.Aciklama,
                  y.Stok,
                  y.Depo,
                  y.IndirimOrani,
                  y.IndirimOrani2,
                  y.IndirimOrani3,
                  y.IndirimTutar,
                  y.DipIskontoPayi,

                  y.Borsa,
                  y.Bagkur,
                  y.Mera,
                  y.Zirai,
                  y.c.CariAdi,
                  y.c.CariKodu,
                  y.ToplamTutar,
                  NetBirimFiyat = y.BirimFiyati - (y.IndirimTutar + y.DipIskontoPayi)
              }).ToList();
                return result;
            }
        }
        public object GetGenelStok(NetSatisContext context, int stokId)
        {
            var result = (from c in context.StokHareketleri.Where(c => c.StokId == stokId)
                          group c by new { c.Hareket }
                into g
                          select new
                          {
                              Bilgi = g.Key.Hareket,
                              KayitSayisi = g.Count(),
                              Toplam = g.Sum(c => c.Miktar)
                          }).ToList();
            return result;
        }
        public object SatisListele(NetSatisContext context, string hareket, DateTime baslangic, DateTime bitis)
        {
            var result = context.StokHareketleri.Where(x => x.Hareket == hareket && x.Tarih >= baslangic && x.Tarih <= bitis).GroupBy(x => x.StokId).Select(x => new
            {
                OrtalamaSatisBirimFiyati = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.BirimFiyati) / x.Where(y => y.Hareket.Equals("Stok Çıkış")).Count(),
                Miktar1 = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.Miktar),
                _StokHareketi = x.FirstOrDefault()
            }).Select(x => new
            {
                Kdv = x._StokHareketi.Kdv,
                StokKodu = x._StokHareketi.Stok.StokKodu,
                StokAdi = x._StokHareketi.Stok.StokAdi,
                Birim = x._StokHareketi.Stok.Birim,
                Miktar = x.Miktar1,
                BirimFiyati = x._StokHareketi.BirimFiyati,
                Tarih = x._StokHareketi.Tarih,
                FisKodu = x._StokHareketi.FisKodu,
                DepoAdi = x._StokHareketi.Depo.DepoAdi,
                ToplamTutar = x._StokHareketi.ToplamTutar
            }).ToList();
            return result;
        }
        public object StokSatisListeletTarih(NetSatisContext context, string hareket, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.StokHareketleri.Where(c => c.Hareket == hareket && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.StokHareketleri.Where(c => c.Hareket == hareket), c => c.StokId, c => c.StokId,
                (stokhareket, stoklar) =>
                    new
                    {
                        stokhareket.FisKodu,
                        stokhareket.BirimFiyati,
                        stokhareket.Miktar,
                        stokhareket.Kdv,
                        stokhareket.Hareket,
                        stokhareket.FisTuru,
                        stokhareket.Depo,
                        stokhareket.Tarih,
                        stokhareket.Stok.StokAdi,
                        stokhareket.DipIskontoPayi,
                        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == stokhareket.Stok.Kategori).KategoriAdi ?? "",
                        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == stokhareket.Stok.AltGrup).AltGrupAdi ?? "",
                        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == stokhareket.Stok.AnaGrup).AnaGrupAdi ?? "",
                        stokhareket.Stok.Birim,
                        stokhareket.Stok.StokKodu,
                        stokhareket.Stok.AlisFiyati1,
                        stokhareket.IndirimTutar,
                        stokhareket.Stok.Marka,
                        stokhareket.Stok.Uretici,
                        stokhareket.IndirimOrani,
                        stokhareket.IndirimOrani2,
                        stokhareket.IndirimOrani3,
                        stokhareket.Stok.Kategori,
                        stokhareket.Stok.AnaGrup,
                        stokhareket.ToplamTutar,
                        NetBirim = (stokhareket.BirimFiyati - (stokhareket.IndirimTutar + stokhareket.DipIskontoPayi) ?? 0),
                        AlisToplam = (stokhareket.Miktar * (stokhareket.Stok.AlisFiyati1 ?? 0)),
                        NetTutar = stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0),
                        //KarOran = (stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0) * 100 / (stokhareket.Miktar * stokhareket.Stok.AlisFiyati1 ?? 0)) - (100) ?? 0,
                    }).Select(k => new
                    {
                        k.FisKodu,
                        k.BirimFiyati,
                        k.Miktar,
                        k.Kdv,
                        k.Hareket,
                        k.FisTuru,
                        k.Depo,
                        k.Tarih,
                        k.StokAdi,
                        k.StokKodu,
                        k.AlisFiyati1,
                        k.Birim,
                        k.AnaGrup,
                        k.Marka,
                        k.Uretici,
                        k.IndirimOrani,
                        k.IndirimOrani2,
                        k.IndirimOrani3,
                        k.IndirimTutar,
                        k.KategoriAdi,
                        k.AltGrupAdi,
                        k.AnaGrupAdi,
                        k.Kategori,
                        k.ToplamTutar,
                        k.NetBirim,
                        k.DipIskontoPayi,
                        k.AlisToplam,
                        k.NetTutar,
                        KarTutari = (k.NetTutar - k.AlisToplam) ?? 0,
                        KdvToplam = k.ToplamTutar - (k.ToplamTutar * k.Kdv / 100),
                        karOran =  k.AlisToplam == 0 ? ""  :  ((k.NetTutar -k.AlisToplam) / k.AlisToplam * 100).ToString(),
                    }).ToList();
            return tablo;
        }
        public object StokSatisListeletPerakendeTarih(NetSatisContext context, string hareket, string fisTuru, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.StokHareketleri.Where(c => c.Hareket == hareket && c.FisTuru == fisTuru && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.StokHareketleri.Where(c => c.Hareket == hareket), c => c.StokId, c => c.StokId,
                (stokhareket, stoklar) =>
                    new
                    {
                        stokhareket.FisKodu,
                        stokhareket.BirimFiyati,
                        stokhareket.Miktar,
                        stokhareket.Kdv,
                        stokhareket.Hareket,
                        stokhareket.FisTuru,
                        stokhareket.Depo,
                        stokhareket.Tarih,
                        stokhareket.Stok.StokAdi,
                        stokhareket.DipIskontoPayi,
                        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == stokhareket.Stok.Kategori).KategoriAdi ?? "",
                        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == stokhareket.Stok.AltGrup).AltGrupAdi ?? "",
                        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == stokhareket.Stok.AnaGrup).AnaGrupAdi ?? "",
                        stokhareket.Stok.Birim,
                        stokhareket.Stok.StokKodu,
                        stokhareket.Stok.AlisFiyati1,
                        stokhareket.IndirimTutar,
                        stokhareket.Stok.Marka,
                        stokhareket.Stok.Uretici,
                        stokhareket.IndirimOrani,
                        stokhareket.IndirimOrani2,
                        stokhareket.IndirimOrani3,
                        stokhareket.Stok.Kategori,
                        stokhareket.Stok.AnaGrup,
                        stokhareket.ToplamTutar,
                        NetBirim = (stokhareket.BirimFiyati - (stokhareket.IndirimTutar + stokhareket.DipIskontoPayi) ?? 0),
                        AlisToplam = (stokhareket.Miktar * (stokhareket.Stok.AlisFiyati1 ?? 0)),
                        NetTutar = stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0),
                        //KarOran = (stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0) * 100 / (stokhareket.Miktar * stokhareket.Stok.AlisFiyati1 ?? 0)) - (100) ?? 0,
                    }).Select(k => new
                    {
                        k.FisKodu,
                        k.BirimFiyati,
                        k.Miktar,
                        k.Kdv,
                        k.Hareket,
                        k.FisTuru,
                        k.Depo,
                        k.Tarih,
                        k.StokAdi,
                        k.StokKodu,
                        k.AlisFiyati1,
                        k.Birim,
                        k.AnaGrup,
                        k.Marka,
                        k.Uretici,
                        k.IndirimOrani,
                        k.IndirimOrani2,
                        k.IndirimOrani3,
                        k.IndirimTutar,
                        k.KategoriAdi,
                        k.AltGrupAdi,
                        k.AnaGrupAdi,
                        k.Kategori,
                        k.ToplamTutar,
                        k.NetBirim,
                        k.DipIskontoPayi,
                        k.AlisToplam,
                        k.NetTutar,
                        KarTutari = (k.NetTutar - k.AlisToplam) ?? 0,
                        KdvToplam = k.ToplamTutar - (k.ToplamTutar * k.Kdv / 100)
                    }).ToList();
            return tablo;
        }
        public object GenelIadeListele(NetSatisContext context, string fisTuru,string fisTuru2, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.StokHareketleri.Where(c => c.FisTuru == fisTuru || c.FisTuru == fisTuru2 && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.StokHareketleri.Where(c => c.FisTuru == fisTuru), c => c.StokId, c => c.StokId,
                (stokhareket, stoklar) =>
                    new
                    {
                        stokhareket.FisKodu,
                        stokhareket.BirimFiyati,
                        stokhareket.Miktar,
                        stokhareket.Kdv,
                        stokhareket.Hareket,
                        stokhareket.FisTuru,
                        stokhareket.Depo,
                        stokhareket.Tarih,
                        stokhareket.Stok.StokAdi,
                        stokhareket.Stok.Birim,
                        stokhareket.Stok.StokKodu,
                        stokhareket.Stok.AlisFiyati1,
                        stokhareket.Stok.Marka,
                        stokhareket.Stok.Uretici,
                        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == stokhareket.Stok.Kategori).KategoriAdi ?? "",
                        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == stokhareket.Stok.AltGrup).AltGrupAdi ?? "",
                        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == stokhareket.Stok.AnaGrup).AnaGrupAdi ?? "",
                        stokhareket.IndirimOrani,
                        stokhareket.IndirimOrani2,
                        stokhareket.IndirimOrani3,
                        stokhareket.Stok.Kategori,
                        stokhareket.Stok.AnaGrup,
                        stokhareket.ToplamTutar,
                        NetBirim = stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0,
                        AlisToplam = (stokhareket.Miktar * stokhareket.Stok.AlisFiyati1 ?? 0),
                        NetTutar = stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0),
                        //KarOran = (stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0) * 100 / (stokhareket.Miktar * stokhareket.Stok.AlisFiyati1 ?? 0)) - (100) ?? 0,
                    }).Select(k => new
                    {
                        k.FisKodu,
                        k.BirimFiyati,
                        k.Miktar,
                        k.Kdv,
                        k.Hareket,
                        k.FisTuru,
                        k.Depo,
                        k.Tarih,
                        k.StokAdi,
                        k.StokKodu,
                        k.AlisFiyati1,
                        k.KategoriAdi,
                        k.AnaGrupAdi,
                        k.AltGrupAdi,
                        k.Birim,
                        k.AnaGrup,
                        k.Marka,
                        k.Uretici,
                        k.IndirimOrani,
                        k.IndirimOrani2,
                        k.IndirimOrani3,
                        k.Kategori,
                        k.ToplamTutar,
                        k.NetBirim,
                        k.AlisToplam,
                        k.NetTutar,
                        KarTutari = (k.NetTutar - k.AlisToplam) ?? 0,
                        KdvToplam = k.ToplamTutar - (k.ToplamTutar * k.Kdv / 100)
                    }).ToList();
            return tablo;
        }
        public object AlisListele(NetSatisContext context, string hareket, DateTime baslangic, DateTime bitis)
        {
            var result = context.StokHareketleri.Where(x => x.Hareket == hareket && x.Tarih >= baslangic && x.Tarih <= bitis).GroupBy(x => x.StokId).Select(x => new
            {
                OrtalamaAlisBirimFiyati = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.BirimFiyati) / x.Where(y => y.Hareket.Equals("Stok Giriş")).Count(),
                Miktar1 = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.Miktar),
                _StokHareketi = x.FirstOrDefault()
            }).Select(x => new
            {
                Kdv = x._StokHareketi.Kdv,
                StokKodu = x._StokHareketi.Stok.StokKodu,
                StokAdi = x._StokHareketi.Stok.StokAdi,
                Birim = x._StokHareketi.Stok.Birim,
                Miktar = x.Miktar1,
                BirimFiyati = x.OrtalamaAlisBirimFiyati,
                Tarih = x._StokHareketi.Tarih,
                FisKodu = x._StokHareketi.FisKodu,
                DepoAdi = x._StokHareketi.Depo.DepoAdi,
                ToplamTutar = x.Miktar1 * x.OrtalamaAlisBirimFiyati,
                NetBirim = x._StokHareketi.BirimFiyati - x._StokHareketi.IndirimTutar,
                IndirimTutar = x._StokHareketi.IndirimTutar,
                IndirimOrani = x._StokHareketi.IndirimOrani,
                IndirimOrani2 = x._StokHareketi.IndirimOrani2,
                IndirimOrani3 = x._StokHareketi.IndirimOrani3,
                BirimFiyati2 = x._StokHareketi.BirimFiyati,
                NetTutar2 = x._StokHareketi.BirimFiyati * x._StokHareketi.Miktar - x._StokHareketi.IndirimTutar
            }).ToList();
            return result;
        }
        public object SatisListeletTarih(NetSatisContext context, DateTime baslangic, DateTime bitis)
        {
            var result = context.StokHareketleri.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).GroupBy(x => x.StokId).Select(x => new
            {
                ToplamGirisMiktari = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.Miktar),
                ToplamGirisTutari = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.ToplamTutar),
                ToplamCikisMiktari = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.Miktar),
                ToplamCikisTutari = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.ToplamTutar),
                OrtalamaAlisBirimFiyati = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.BirimFiyati) / x.Where(y => y.Hareket.Equals("Stok Giriş")).Count(),
                OrtalamaSatisBirimFiyati = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.BirimFiyati) / x.Where(y => y.Hareket.Equals("Stok Çıkış")).Count(),
                OrtalamaAlisToplamTutar = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.ToplamTutar) / x.Where(y => y.Hareket.Equals("Stok Giriş")).Count(),
                OrtalamaSatisToplamTutar = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.ToplamTutar) / x.Where(y => y.Hareket.Equals("Stok Çıkış")).Count(),
                ToplamNetSatisTutari = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.ToplamTutar),
                ToplamNetAlisTutari = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.ToplamTutar),
                _StokHareketi = x.FirstOrDefault()
            }).Select(x => new
            {
                UrunKodu = x._StokHareketi.Stok.StokKodu,
                UrunAdi = x._StokHareketi.Stok.StokAdi,
                UrunKDV = x._StokHareketi.Kdv,
                UrunBirim = x._StokHareketi.Stok.Birim,
                Tarih = x._StokHareketi.Tarih,
                x.ToplamGirisMiktari,
                x.ToplamGirisTutari,
                UrunCikisMiktari = x.ToplamCikisMiktari,
                x.ToplamCikisTutari,
                UrunAlisFiyati = x.OrtalamaAlisBirimFiyati,
                UrunSatisFiyati = x.OrtalamaSatisBirimFiyati,
                FisKodu = x._StokHareketi.FisKodu,
                Hareket = x._StokHareketi.Hareket,
                x.OrtalamaAlisToplamTutar,
                x.OrtalamaSatisToplamTutar,
                UrunSatisFiyatiToplam = x.ToplamCikisMiktari * x.OrtalamaSatisBirimFiyati,
                UrunAlisFiyatiToplam = x.ToplamCikisMiktari * x.OrtalamaAlisBirimFiyati,
                KarZararTutari = (x.ToplamCikisMiktari * x.OrtalamaSatisBirimFiyati) - (x.ToplamCikisMiktari * x.OrtalamaAlisBirimFiyati),
                KarZararOrani = (x.ToplamCikisMiktari * x.OrtalamaSatisBirimFiyati) * 100 / (x.ToplamCikisMiktari * x.OrtalamaAlisBirimFiyati) - 100,
                DepoMevcudu = x.ToplamGirisMiktari - x.ToplamCikisMiktari,
                EnvanterTutari = (x.ToplamGirisMiktari - x.ToplamCikisMiktari) * x.OrtalamaAlisBirimFiyati ?? x._StokHareketi.Stok.AlisFiyati1
            }).ToList();
            #region Eski
            //var tablo = context.StokHareketleri.Where(c => c.Hareket == hareket && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
            //    context.StokHareketleri.Where(c => c.Hareket == hareket), c => c.StokId, c => c.StokId,
            //    (stokhareket, stoklar) =>
            //        new
            //        {
            //            stokhareket.FisKodu,
            //            //stokhareket.Cari.CariAdi,
            //            stokhareket.BirimFiyati,
            //            stokhareket.Miktar,
            //            stokhareket.Kdv,
            //            stokhareket.Hareket,
            //            stokhareket.Depo,
            //            stokhareket.Tarih,
            //            stokhareket.Stok.StokAdi,
            //            stokhareket.Stok.Birim,
            //            stokhareket.Stok.StokKodu,
            //            stokhareket.Stok.AlisFiyati1,
            //            stokhareket.Stok.Marka,
            //            stokhareket.Stok.Uretici,
            //            stokhareket.IndirimOrani,
            //            stokhareket.Stok.Kategori,
            //            stokhareket.Stok.AnaGrup,
            //            ToplamTutar = (stokhareket.Miktar * stokhareket.BirimFiyati) ?? 0,
            //            NetBirim = stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0,
            //            AlisToplam = (stokhareket.Miktar * stokhareket.Stok.AlisFiyati1 ?? 0),
            //            NetTutar = stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0),
            //            KarOran = (stokhareket.Miktar * (stokhareket.BirimFiyati - (stokhareket.BirimFiyati * stokhareket.IndirimOrani / 100) ?? 0) * 100 / (stokhareket.Miktar * stokhareket.Stok.AlisFiyati1 ?? 0)) - (100) ?? 0,
            //        }).Select(k => new
            //        {
            //            k.FisKodu,
            //            k.BirimFiyati,
            //            k.Miktar,
            //            k.Kdv,
            //            k.Hareket,
            //            k.Depo,
            //            k.Tarih,
            //            k.StokAdi,
            //            k.StokKodu,
            //            k.AlisFiyati1,
            //            k.Birim,
            //            k.AnaGrup,
            //            k.Marka,
            //            k.Uretici,
            //            k.IndirimOrani,
            //            k.Kategori,
            //            k.ToplamTutar,
            //            k.NetBirim,
            //            k.AlisToplam,
            //            k.NetTutar,
            //            KdvToplam = k.ToplamTutar - (k.ToplamTutar * k.Kdv / 100)
            //        }).ToList(); 
            #endregion
            return result;
        }
        public object GetDepoStok(NetSatisContext context, int stokId)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokId == stokId),
                c => c.Id, c => c.DepoId, (depolar, stokhareketleri) => new
                {
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış" || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ??
                                  0) - (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış" || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0)
                }).ToList();
            return result;
        }
        public object DepoStokListele(NetSatisContext context, int depoId)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri.Where(c => c.DepoId == depoId),
                c => c.Id, c => c.StokId,
                (Stoklar, StokHareketleri) =>
                    new
                    {
                        Stoklar.StokAdi,
                        Stoklar.StokKodu,
                        Stoklar.AlisFiyati1,
                        Stoklar.SatisFiyati1,
                        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                        Stoklar.Birim,
                        Stoklar.SatisKdv,
                        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                        StokCikis = StokHareketleri.Where(c => c.Hareket == "Stok Çıkış" || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                        MevcutStok = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0 -
                                     StokHareketleri.Where(c => c.Hareket == "Stok Çıkış" || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0
                    }).ToList();
            return tablo;
        }
        public object DepoIstatistlikListele(NetSatisContext context, int depoId)
        {
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam()
                {
                    Bilgi = "Stok Giriş",
                    KayitSayisi = context.StokHareketleri
                        .Where(c => c.DepoId == depoId && c.Hareket == "Stok Giriş").Count(),
                    Tutar = context.StokHareketleri.Where(c => c.DepoId == depoId).Sum(c => c.Miktar) ?? 0
                },
                new GenelToplam()
                {
                    Bilgi = "Stok Çıkış",
                    KayitSayisi = context.StokHareketleri
                        .Where(c => c.DepoId == depoId && c.Hareket == "Stok Çıkış").Count(),
                    Tutar = context.StokHareketleri.Where(c => c.DepoId == depoId).Sum(c => c.Miktar) ?? 0
                },
            };
            return genelToplamlar;
        }
        public DataSet StokEnvanterListele(NetSatisContext context, int? depoID = null, DateTime? baslangic = null, DateTime? bitis = null)
        {
            DataSet DS = new DataSet("StokEnvanterData");
            DataTable DT1 = new DataTable("EnvanterBilgileri");
            DT1.Columns.Add("BaslangicTarihi", typeof(string));
            DT1.Columns.Add("BitisTarihi", typeof(string));
            DT1.Columns.Add("Depo", typeof(string));
            DataTable DT2 = new DataTable("EnvanterSatirlari");
            DT2.Columns.Add("UrunKodu", typeof(string));
            DT2.Columns.Add("UrunAdi", typeof(string));
            DT2.Columns.Add("UrunKDV", typeof(string));
            DT2.Columns.Add("UrunBirim", typeof(string));
            DT2.Columns.Add("UrunToplamGirisMiktari", typeof(decimal));
            DT2.Columns.Add("UrunToplamGirisTutari", typeof(decimal));
            DT2.Columns.Add("UrunToplamCikisMiktari", typeof(decimal));
            DT2.Columns.Add("UrunToplamCikisTutari", typeof(decimal));
            DT2.Columns.Add("OrtalamaAlisFiyati", typeof(decimal));
            DT2.Columns.Add("OrtalamaSatisFiyati", typeof(decimal));
            DT2.Columns.Add("UrunDepoMevcudu", typeof(decimal));
            DT2.Columns.Add("UrunDepoAdi", typeof(string));
            DT2.Columns.Add("EnvanterTutari", typeof(decimal));
            DataRow DR1 = DT1.NewRow();
            var first = context.StokHareketleri.Where(x => x.Hareket != null).ToList();
            if (baslangic != null && bitis != null)
            {
                first = first.Where(x => x.Tarih >= baslangic && x.Tarih <= bitis).ToList();
            }
            if (depoID != null)
            {
                first = first.Where(x => x.DepoId == depoID).ToList();
            }
            var result = first.GroupBy(x => x.StokId).Select(x => new
            {
                ToplamGirisMiktari = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.Miktar),
                ToplamGirisTutari = x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.ToplamTutar),
                ToplamCikisMiktari = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.Miktar),
                ToplamCikisTutari = x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.ToplamTutar),
                OrtalamaAlisFiyati = (x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.BirimFiyati) == 0) ? 0 :
                    x.Where(y => y.Hareket.Equals("Stok Giriş")).Sum(y => y.BirimFiyati) / x.Where(y => y.Hareket.Equals("Stok Giriş")).Count(),
                OrtalamaSatisFiyati = (x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.BirimFiyati) == 0) ? 0 :
                    x.Where(y => y.Hareket.Equals("Stok Çıkış")).Sum(y => y.BirimFiyati) / x.Where(y => y.Hareket.Equals("Stok Çıkış")).Count(),
                _StokHareketi = x.FirstOrDefault()
            }).Select(x => new
            {
                UrunKodu = x._StokHareketi.Stok.StokKodu,
                UrunAdi = x._StokHareketi.Stok.StokAdi,
                UrunKDV = x._StokHareketi.Kdv,
                UrunBirim = x._StokHareketi.Stok.Birim,
                x.ToplamGirisMiktari,
                x.ToplamGirisTutari,
                x.ToplamCikisMiktari,
                x.ToplamCikisTutari,
                x.OrtalamaAlisFiyati,
                x.OrtalamaSatisFiyati,
                DepoMevcudu = x.ToplamGirisMiktari - x.ToplamCikisMiktari,
                x._StokHareketi.Depo.DepoAdi,
                EnvanterTutari = (x.ToplamGirisMiktari - x.ToplamCikisMiktari) * ((x.OrtalamaAlisFiyati == 0 || x.OrtalamaAlisFiyati == null) ?
                    x._StokHareketi.Stok.AlisFiyati1 : x.OrtalamaAlisFiyati)
            }).ToList();
            DR1["BaslangicTarihi"] = baslangic == null ? "-" : baslangic.Value.ToShortDateString();
            DR1["BitisTarihi"] = bitis == null ? "-" : bitis.Value.ToShortDateString();
            DR1["Depo"] = depoID != null ? result.FirstOrDefault().DepoAdi : "Tüm Depolar";
            DT1.Rows.Add(DR1); foreach (var item in result)
            {
                DataRow DR = DT2.NewRow();
                DR["UrunKodu"] = item.UrunKodu;
                DR["UrunAdi"] = item.UrunAdi;
                DR["UrunKDV"] = item.UrunKDV;
                DR["UrunBirim"] = item.UrunBirim;
                DR["UrunToplamGirisMiktari"] = item.ToplamGirisMiktari;
                DR["UrunToplamGirisTutari"] = item.ToplamGirisTutari;
                DR["UrunToplamCikisMiktari"] = item.ToplamCikisMiktari;
                DR["UrunToplamCikisTutari"] = item.ToplamCikisTutari;
                DR["OrtalamaAlisFiyati"] = item.OrtalamaAlisFiyati;
                DR["OrtalamaSatisFiyati"] = item.OrtalamaSatisFiyati;
                DR["UrunDepoMevcudu"] = item.DepoMevcudu;
                DR["UrunDepoAdi"] = depoID != null ? item.DepoAdi : "Tüm Depolar";
                DR["EnvanterTutari"] = item.EnvanterTutari == null ? 0 : item.EnvanterTutari;
                DT2.Rows.Add(DR);
            }
            DS.Tables.Add(DT1);
            DS.Tables.Add(DT2);
            return DS;
        }
    }
}
