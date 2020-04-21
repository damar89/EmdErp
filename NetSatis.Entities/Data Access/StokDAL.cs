using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
namespace NetSatis.Entities.Data_Access
{
    public class StokDAL : EntityRepositoryBase<NetSatisContext, Stok, StokValidator>
    {
        public object StokListele(NetSatisContext context, bool hepsi = true)
        {
            if (hepsi) {
                var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
            (Stoklar, StokHareketleri) =>
                new {
                    Stoklar.Id,
                    Stoklar.Durumu,
                    Stoklar.WebAcikMi,
                    Stoklar.StokKodu,
                    Stoklar.StokAdi,
                    Stoklar.Barkodu,
                    Stoklar.Birim,
                    Stoklar.Kategori,
                    KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                    AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                    AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                    Stoklar.AnaGrup,
                    Stoklar.AltGrup,
                    Stoklar.Marka,
                    Stoklar.Uretici,
                    Stoklar.Modeli,
                    Stoklar.Proje,
                    Stoklar.Pozisyon,
                    //Stoklar.ResimUrl,
                    Stoklar.GarantiSuresi,
                    Stoklar.SatisKdv,
                    Stoklar.AlisFiyati1,
                    Stoklar.AlisFiyati2,
                    Stoklar.AlisFiyati3,
                    Stoklar.SatisFiyati1,
                    Stoklar.SatisFiyati2,
                    Stoklar.SatisFiyati3,
                    Stoklar.SatisFiyati4,
                    Stoklar.WebSatisFiyati,
                    Stoklar.WebBayiSatisFiyati,
                    Stoklar.Aciklama,
                    Stoklar.Barkod,
                    Stoklar.GuncellemeTarihi,
                    Stoklar.KayitTarihi,
                    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
                }).ToList();
                return tablo;
            } else {
                var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                (Stoklar, StokHareketleri) =>
                new {
                    Stoklar.Id,
                    Stoklar.Durumu,
                    Stoklar.WebAcikMi,
                    Stoklar.StokKodu,
                    Stoklar.StokAdi,
                    Stoklar.Barkodu,
                    Stoklar.Birim,
                    Stoklar.Kategori,
                    Stoklar.AnaGrup,
                    Stoklar.AltGrup,
                    Stoklar.Marka,
                    Stoklar.Uretici,
                    Stoklar.Modeli,
                    Stoklar.Proje,
                    Stoklar.Pozisyon,
                    KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                    AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                    AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                    //Stoklar.ResimUrl,
                    Stoklar.GarantiSuresi,
                    Stoklar.SatisKdv,
                    Stoklar.AlisFiyati1,
                    Stoklar.AlisFiyati2,
                    Stoklar.AlisFiyati3,
                    Stoklar.SatisFiyati1,
                    Stoklar.SatisFiyati2,
                    Stoklar.SatisFiyati3,
                    Stoklar.SatisFiyati4,
                    Stoklar.WebSatisFiyati,
                    Stoklar.WebBayiSatisFiyati,
                    Stoklar.Aciklama,
                    Stoklar.Barkod,
                    Stoklar.GuncellemeTarihi,
                    Stoklar.KayitTarihi,
                    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                    StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
                }).Where(K => K.StokGiris > 0 || K.StokCikis > 0).ToList();
                return tablo;
            }
        }
        public decimal? StokAdetler(NetSatisContext context, int StokId)
        {
            var res = from s in context.Stoklar.Where(x => x.Id == StokId)
                      join ss in context.StokHareketleri.GroupBy(x => x.StokId) on s.Id equals ss.Key
                      select new {
                          MevcutStok = (ss.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                   (ss.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                   || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                   ).Sum(c => c.Miktar) ?? 0)
                      };
            return res.FirstOrDefault()?.MevcutStok;
        }

        public object StokListeleMiktar(NetSatisContext context, string MevcutStok)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                (Stoklar, StokHareketleri) =>
                    new {
                        Stoklar.Id,
                        Stoklar.Durumu,
                        Stoklar.WebAcikMi,
                        Stoklar.StokKodu,
                        Stoklar.StokAdi,
                        Stoklar.Barkodu,
                        Stoklar.Birim,
                        Stoklar.Kategori,
                        Stoklar.AnaGrup,
                        Stoklar.AltGrup,
                        Stoklar.Marka,
                        Stoklar.Uretici,
                        Stoklar.Modeli,
                        Stoklar.Proje,
                        Stoklar.Pozisyon,
                        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                        Stoklar.GarantiSuresi,
                        Stoklar.SatisKdv,
                        Stoklar.AlisFiyati1,
                        Stoklar.AlisFiyati2,
                        Stoklar.AlisFiyati3,
                        Stoklar.SatisFiyati1,
                        Stoklar.SatisFiyati2,
                        Stoklar.SatisFiyati3,
                        Stoklar.SatisFiyati4,
                        Stoklar.WebSatisFiyati,
                        Stoklar.WebBayiSatisFiyati,
                        Stoklar.Aciklama,
                        Stoklar.Barkod,
                        Stoklar.GuncellemeTarihi,
                        Stoklar.KayitTarihi,
                        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                        StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                        MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
                    }).Where(K => K.StokGiris > 0 || K.StokCikis > 0).ToList();
            return tablo;
        }
        public object StokSec(NetSatisContext context)
        {
            var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                (Stoklar, StokHareketleri) =>
                    new {
                        Stoklar.Id,
                        Stoklar.Durumu,
                        Stoklar.WebAcikMi,
                        Stoklar.StokKodu,
                        Stoklar.StokAdi,
                        Stoklar.Barkodu,
                        Stoklar.Birim,
                        Stoklar.Kategori,
                        Stoklar.Marka,
                        Stoklar.Uretici,
                        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                        //Stoklar.AlisKdv,
                        Stoklar.SatisKdv,
                        Stoklar.SatisFiyati1,
                        Stoklar.SatisFiyati2,
                        Stoklar.SatisFiyati3,
                        Stoklar.SatisFiyati4,
                        Stoklar.WebSatisFiyati,
                        Stoklar.WebBayiSatisFiyati,
                        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                        StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                        MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
                    }).Where(K => K.StokGiris > 0 || K.StokCikis > 0).ToList();
            return tablo;
        }
        public object StokKoduylaStokGetir(NetSatisContext context, string aramaMetni)
        {
            List<string> result = aramaMetni.Split(' ').ToList();
            string metin1 = result.Count > 0 ? result[0] : "";
            string metin2 = result.Count > 1 ? result[1] : "";
            string metin3 = result.Count > 2 ? result[2] : "";
            if (result.Count == 1) {
                var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                    (Stoklar, StokHareketleri) =>
           new {
               Stoklar.Id,
               Stoklar.Durumu,
               Stoklar.WebAcikMi,
               Stoklar.StokKodu,
               Stoklar.StokAdi,
               Stoklar.Barkodu,
               Stoklar.Birim,
               Stoklar.Kategori,
               Stoklar.Marka,
               Stoklar.Uretici,
               KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
               AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
               AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
               //Stoklar.AlisKdv,
               Stoklar.SatisKdv,
               Stoklar.SatisFiyati1,
               Stoklar.SatisFiyati2,
               StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
               StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
               MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
           }).Where(x => x.StokKodu.Contains(metin1)).ToList();
                return tablo;
            } else if (result.Count == 2) {
                var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                    (Stoklar, StokHareketleri) =>
           new {
               Stoklar.Id,
               Stoklar.Durumu,
               Stoklar.WebAcikMi,
               Stoklar.StokKodu,
               Stoklar.StokAdi,
               Stoklar.Barkodu,
               Stoklar.Birim,
               Stoklar.Kategori,
               Stoklar.Marka,
               Stoklar.Uretici,
               KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
               AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
               AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
               //Stoklar.AlisKdv,
               Stoklar.SatisKdv,
               Stoklar.SatisFiyati1,
               Stoklar.SatisFiyati2,
               StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
               StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
               MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
           }).Where(x => x.StokKodu.Contains(metin1) && x.StokAdi.Contains(metin2)).ToList();
                return tablo;
            } else if (result.Count > 2) {
                var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
             (Stoklar, StokHareketleri) =>
    new {
        Stoklar.Id,
        Stoklar.Durumu,
        Stoklar.WebAcikMi,
        Stoklar.StokKodu,
        Stoklar.StokAdi,
        Stoklar.Barkodu,
        Stoklar.Birim,
        Stoklar.Kategori,
        Stoklar.Marka,
        Stoklar.Uretici,
        //Stoklar.AlisKdv,
        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
        Stoklar.SatisKdv,
        Stoklar.SatisFiyati1,
        Stoklar.SatisFiyati2,
        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
        StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
        MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                 ).Sum(c => c.Miktar) ?? 0),
    }).Where(x => x.StokKodu.Contains(metin1) && x.StokKodu.Contains(metin2) && x.StokKodu.Contains(metin3)).ToList();
                return tablo;
            }
            return null;
        }
        public object StokAdiylaStokGetir(NetSatisContext context, Expression<Func<Stok, bool>> pred = null)
        {

            // ikisi de barkod ile arama yapıyor olması lazım, beraber kontrol edelim.
            IQueryable<Stok> tablo;
            if (pred != null)
                tablo = context.Stoklar.Include(x => x.Barkod).Where(pred);
            else
                tablo = context.Stoklar.Include("Barkod");

            #region duzenleme
            // if (result.Count == 1)
            // {
            //     var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
            //         (Stoklar, StokHareketleri) =>
            //new
            //{
            //    Stoklar.Id,
            //    Stoklar.Durumu,
            //    Stoklar.WebAcikMi,
            //    Stoklar.StokKodu,
            //    Stoklar.StokAdi,
            //    Stoklar.Barkodu,
            //    Stoklar.Birim,
            //    Stoklar.Kategori,
            //    Stoklar.Marka,
            //    Stoklar.Uretici,
            //    KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
            //    AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
            //    AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
            //    //Stoklar.AlisKdv,
            //    Stoklar.SatisKdv,
            //    Stoklar.SatisFiyati1,
            //    Stoklar.SatisFiyati2,
            //    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //    StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //    MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
            //                      (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
            //                      || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
            //                      ).Sum(c => c.Miktar) ?? 0),
            //}).Where(x => x.StokAdi.Contains(metin1)).ToList();
            //     return tablo;
            // }
            // else if (result.Count == 2)
            // {
            //     var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
            //         (Stoklar, StokHareketleri) =>
            //new
            //{
            //    Stoklar.Id,
            //    Stoklar.Durumu,
            //    Stoklar.WebAcikMi,
            //    Stoklar.StokKodu,
            //    Stoklar.StokAdi,
            //    Stoklar.Barkodu,
            //    Stoklar.Birim,
            //    Stoklar.Kategori,
            //    Stoklar.Marka,
            //    Stoklar.Uretici,
            //    KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
            //    AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
            //    AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
            //    //Stoklar.AlisKdv,
            //    Stoklar.SatisKdv,
            //    Stoklar.SatisFiyati1,
            //    Stoklar.SatisFiyati2,
            //    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //    StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //    MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
            //                      (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
            //                      || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
            //                      ).Sum(c => c.Miktar) ?? 0),
            //}).Where(x => x.StokAdi.Contains(metin1) && x.StokAdi.Contains(metin2)).ToList();
            //     return tablo;
            // }
            // else if (result.Count > 2)
            // { 
            //         var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
            //         (Stoklar, StokHareketleri) =>
            //new
            //{
            //    Stoklar.Id,
            //    Stoklar.Durumu,
            //    Stoklar.WebAcikMi,
            //    Stoklar.StokKodu,
            //    Stoklar.StokAdi,
            //    Stoklar.Barkodu,
            //    Stoklar.Birim,
            //    Stoklar.Kategori,
            //    Stoklar.Marka,
            //    Stoklar.Uretici,
            //    KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
            //    AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
            //    AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
            //     //Stoklar.AlisKdv,
            //     Stoklar.SatisKdv,
            //    Stoklar.SatisFiyati1,
            //    Stoklar.SatisFiyati2,
            //    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //    StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //    MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
            //                             (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
            //                             || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
            //                             ).Sum(c => c.Miktar) ?? 0),
            //}).Where(x => x.StokAdi.Contains(metin1) && x.StokAdi.Contains(metin2) && x.StokAdi.Contains(metin3)).ToList();


            //         return tablo;
            //     }
            //         return null;
            #endregion
            var res = tablo.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                  (Stoklar, StokHareketleri) =>
                         new {
                             Stoklar.Id,
                             Stoklar.Durumu,
                             Stoklar.WebAcikMi,
                             Stoklar.StokKodu,
                             Stoklar.StokAdi,
                             Stoklar.Barkodu,
                             Stoklar.Birim,
                             Stoklar.Kategori,
                             Stoklar.Marka,
                             Stoklar.Uretici,
                             KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                             AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                             AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                             //Stoklar.AlisKdv,
                             Stoklar.SatisKdv,
                             Stoklar.SatisFiyati1,
                             Stoklar.SatisFiyati2,
                             StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                             StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                             MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                                                      (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                                                      || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                                                      ).Sum(c => c.Miktar) ?? 0),
                         }).ToList();


            return res;
            //}
            //return null;
        }
        public Stok GetByFilter(NetSatisContext context, Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
