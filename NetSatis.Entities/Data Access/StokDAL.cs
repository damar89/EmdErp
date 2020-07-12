using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using FluentValidation.Results;
using System.Security.Cryptography.X509Certificates;
using NetSatis.Entities.Tools;

namespace NetSatis.Entities.Data_Access
{
    public class StokDAL : EntityRepositoryBase<NetSatisContext, Stok, StokValidator>
    {
        /// <summary>
        /// Stok listeleme işlemi yapar
        /// </summary>
        /// <param name="context">db context</param>
        /// <param name="tumKayitlar">tum kayıtları listeler, false olursa stok giriş veya stok çıkışı değerleri 0 dan büyük olan kayıları getirir</param>
        /// <returns></returns>
        public List<Stok> StokListele(NetSatisContext context, bool tumKayitlar = true)
        {
            if (tumKayitlar)
            {
                return StokAdiylaStokGetir(context);

                #region eski kodlar

                //    var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                //(Stoklar, StokHareketleri) =>
                //    new
                //    {
                //        Stoklar.Id,
                //        Stoklar.Durumu,
                //        Stoklar.WebAcikMi,
                //        Stoklar.StokKodu,
                //        Stoklar.StokAdi,
                //        Stoklar.Barkodu,
                //        Stoklar.Birim,
                //        Stoklar.Kategori,
                //        KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                //        AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                //        AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                //        Stoklar.AnaGrup,
                //        Stoklar.AltGrup,
                //        Stoklar.Marka,
                //        Stoklar.Uretici,
                //        Stoklar.Modeli,
                //        Stoklar.Proje,
                //        Stoklar.Pozisyon,
                //        //Stoklar.ResimUrl,
                //        Stoklar.GarantiSuresi,
                //        Stoklar.SatisKdv,
                //        Stoklar.AlisFiyati1,
                //        Stoklar.AlisFiyati2,
                //        Stoklar.AlisFiyati3,
                //        Stoklar.SatisFiyati1,
                //        Stoklar.SatisFiyati2,
                //        Stoklar.SatisFiyati3,
                //        Stoklar.SatisFiyati4,
                //        Stoklar.WebSatisFiyati,
                //        Stoklar.WebBayiSatisFiyati,
                //        Stoklar.Aciklama,
                //        Stoklar.Barkod,
                //        Stoklar.GuncellemeTarihi,
                //        Stoklar.KayitTarihi,
                //        StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                //        StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                //        MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                //                     (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                //                     || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                //                     ).Sum(c => c.Miktar) ?? 0),
                //    }).ToList();
                //    return tablo; 

                #endregion
            }
            else
            {

                return StokAdiylaStokGetir(context, stokGirisVeCikisSifirdanBuyukOlanlar: true);

                #region eski kodlar
                //var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
                //(Stoklar, StokHareketleri) =>
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
                //    Stoklar.AnaGrup,
                //    Stoklar.AltGrup,
                //    Stoklar.Marka,
                //    Stoklar.Uretici,
                //    Stoklar.Modeli,
                //    Stoklar.Proje,
                //    Stoklar.Pozisyon,
                //    KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
                //    AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
                //    AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
                //    //Stoklar.ResimUrl,
                //    Stoklar.GarantiSuresi,
                //    Stoklar.SatisKdv,
                //    Stoklar.AlisFiyati1,
                //    Stoklar.AlisFiyati2,
                //    Stoklar.AlisFiyati3,
                //    Stoklar.SatisFiyati1,
                //    Stoklar.SatisFiyati2,
                //    Stoklar.SatisFiyati3,
                //    Stoklar.SatisFiyati4,
                //    Stoklar.WebSatisFiyati,
                //    Stoklar.WebBayiSatisFiyati,
                //    Stoklar.Aciklama,
                //    Stoklar.Barkod,
                //    Stoklar.GuncellemeTarihi,
                //    Stoklar.KayitTarihi,
                //    StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                //    StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
                //    MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
                //                 (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
                //                 || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
                //                 ).Sum(c => c.Miktar) ?? 0),
                //}).Where(K => K.StokGiris > 0 || K.StokCikis > 0).ToList(); 
                //return tablo;
                #endregion
            }
        }
        public decimal? StokAdetler(NetSatisContext context, int StokId)
        {
            return MevcutStok(context, StokId);

            #region eski kodlar
            //var res = from s in context.Stoklar.Where(x => x.Id == StokId)
            //          join ss in context.StokHareketleri.GroupBy(x => x.StokId) on s.Id equals ss.Key
            //          select new
            //          {
            //              MevcutStok = (ss.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
            //                       (ss.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
            //                       || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
            //                       ).Sum(c => c.Miktar) ?? 0)
            //          };
            //return res.FirstOrDefault()?.MevcutStok; 
            #endregion
        }

        public List<Stok> StokSec(NetSatisContext context)
        {

            return StokListele(context, false);

            #region eski kodlar
            //var tablo = context.Stoklar.GroupJoin(context.StokHareketleri, c => c.Id, c => c.StokId,
            //    (Stoklar, StokHareketleri) =>
            //        new
            //        {
            //            Stoklar.Id,
            //            Stoklar.Durumu,
            //            Stoklar.WebAcikMi,
            //            Stoklar.StokKodu,
            //            Stoklar.StokAdi,
            //            Stoklar.Barkodu,
            //            Stoklar.Birim,
            //            Stoklar.Kategori,
            //            Stoklar.Marka,
            //            Stoklar.Uretici,
            //            KategoriAdi = context.Kategoriler.FirstOrDefault(x => x.Kod == Stoklar.Kategori).KategoriAdi ?? "",
            //            AltGrupAdi = context.AltGruplar.FirstOrDefault(x => x.Kod == Stoklar.AltGrup).AltGrupAdi ?? "",
            //            AnaGrupAdi = context.AnaGruplar.FirstOrDefault(x => x.Kod == Stoklar.AnaGrup).AnaGrupAdi ?? "",
            //            //Stoklar.AlisKdv,
            //            Stoklar.SatisKdv,
            //            Stoklar.SatisFiyati1,
            //            Stoklar.SatisFiyati2,
            //            Stoklar.SatisFiyati3,
            //            Stoklar.SatisFiyati4,
            //            Stoklar.WebSatisFiyati,
            //            Stoklar.WebBayiSatisFiyati,
            //            StokGiris = StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //            StokCikis = StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0,
            //            MevcutStok = (StokHareketleri.Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar) ?? 0) -
            //                     (StokHareketleri.Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura")
            //                     || (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")
            //                     ).Sum(c => c.Miktar) ?? 0),
            //        }).Where(K => K.StokGiris > 0 || K.StokCikis > 0).ToList();
            //return tablo; 
            #endregion
        }

        public int StokKayitSayisi(NetSatisContext context, Expression<Func<Stok, bool>> pred = null)
        {
            return pred == null ? context.Stoklar.AsNoTracking().Count() : context.Stoklar.Where(pred).AsNoTracking().Count();
        }

        /// <summary>
        /// Stok kayıtlarının getirir.
        /// </summary>
        /// <param name="context">db context</param>
        /// <param name="pred">where koşulu</param>
        /// <param name="take">kaç adet kayıt getirmesi gerektiği belirtilir.</param>
        /// <param name="skip">kaç adet kayıt atlamsı gerektiği belirtilir.</param>
        /// <returns></returns>
        public List<Stok> StokAdiylaStokGetir(NetSatisContext context, Expression<Func<Stok, bool>> pred = null, int skip = 0, int take = 0, bool stokGirisVeCikisSifirdanBuyukOlanlar = false, bool noTracking = true)
        {

            //stok tablosunun ilk halini oluşturur

            bool aktifpasif = string.IsNullOrEmpty(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_StokGozukmesin)) ? false : Convert.ToBoolean(SettingsTool.AyarOku(SettingsTool.Ayarlar.SatisAyarlari_StokGozukmesin));

            IQueryable<Stok> tablo = context.Stoklar.Where(x => x.Durumu == (aktifpasif ? true : x.Durumu)).Include(x => x.StokHareket).Include(x => x.Barkod);
            if (noTracking)
                tablo = tablo.AsNoTracking();
            if (pred != null)
            {
                //pred ile where koşullarını set eder ve bağlı barkodları tabloya yükler
                tablo = tablo.Where(pred);
            }

            #region take, skip işlemleri

            //getirmesi istenilen ve pas geçilmesi istenilen sayılar belirtilir
            if (take != 0 && skip != 0)
            {
                tablo = tablo.OrderBy(x => x.Id).Skip(skip).Take(take);
            }
            else if (take != 0)
            {
                tablo = tablo.Take(take);
            }
            else if (skip != 0)
            {
                tablo = tablo.OrderBy(x => x.Id).Skip(skip);
            }
            #endregion


            #region eski kodlar
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

            //var listStok = tablo.ToList();
            var resh = (from s in tablo.ToList()
                        join k in context.Kategoriler on s.Kategori equals k.Kod into kk
                        from _k in kk.DefaultIfEmpty()
                        join ag in context.AltGruplar on s.AltGrup equals ag.Kod into agg
                        from _ag in agg.DefaultIfEmpty()
                        join ang in context.AnaGruplar on s.AnaGrup equals ang.Kod into angg
                        from _ang in angg.DefaultIfEmpty()
                        select new
                        {
                            s.Id,
                            s.Durumu,
                            s.WebAcikMi,
                            s.StokKodu,
                            s.StokAdi,
                            s.Barkodu,
                            s.Birim,
                            s.Kategori,
                            s.Marka,
                            s.Uretici,
                            _k?.KategoriAdi,
                            _ag?.AltGrupAdi,
                            _ang?.AnaGrupAdi,
                            s.OzelKodu,
                            s.Proje,
                            s.SatisKdv,
                            s.AlisFiyati1,
                            s.SatisFiyati1,
                            s.SatisFiyati2,
                            SHareket = s.StokHareket
                        }).ToList();
            var resh2 = (from s in resh
                         select new Stok
                         {
                             Id = s.Id,
                             Durumu = s.Durumu,
                             WebAcikMi = s.WebAcikMi,
                             StokKodu = s.StokKodu,
                             StokAdi = s.StokAdi,
                             Barkodu = s.Barkodu,
                             Birim = s.Birim,
                             Kategori = s.Kategori,
                             Marka = s.Marka,
                             Uretici = s.Uretici,
                             KategoriAdi = s.KategoriAdi,
                             AltGrupAdi = s.AltGrupAdi,
                             AnaGrupAdi = s.AnaGrupAdi,
                             SatisKdv = s.SatisKdv,
                             OzelKodu = s.OzelKodu,
                             Proje = s.Proje,
                             AlisFiyati1 = s.AlisFiyati1,
                             SatisFiyati1 = s.SatisFiyati1,
                             SatisFiyati2 = s.SatisFiyati2,
                             StokGiris = StokGiris(s.SHareket),
                             StokCikis = StokCikis(s.SHareket),
                             MevcutStok = MevcutStok(s.SHareket),
                         });
            if (stokGirisVeCikisSifirdanBuyukOlanlar)
                resh2 = resh2.Where(x => x.StokGiris.Value != 0 || x.StokCikis.Value != 0);
            return resh2.ToList();

        }
        #region Stok giriş, çıkış ve mevcut stok miktar methodları

        public decimal? StokGiris(ICollection<StokHareket> hareketler = null)
        {
            var res = hareketler
                .Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1"))
                .Sum(c => c.Miktar);
            return res;
        }
        public decimal? StokCikis(ICollection<StokHareket> hareketler = null)
        {
            var res = hareketler
                .Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") ||
                            (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar);
            return res;
        }
        public decimal? MevcutStok(ICollection<StokHareket> hareketler = null)
        {
            var res = StokGiris(hareketler) - StokCikis(hareketler);
            return res;
        }
        public decimal? StokGiris(NetSatisContext context, int StokId)
        {

            var hr = context.StokHareketleri.Where(x => x.StokId == StokId).AsNoTracking().ToList();
            var res = hr
                .Where(c => c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1"))
                .Sum(c => c.Miktar);
            return res;
        }
        public decimal? StokCikis(NetSatisContext context, int StokId)
        {
            var hr = context.StokHareketleri.Where(x => x.StokId == StokId).AsNoTracking().ToList();
            var res = hr
                .Where(c => (c.Hareket == "Stok Çıkış" && c.FisTuru != "Perakende Fatura") ||
                            (c.FisTuru == "Satış İrsaliyesi" && c.StokIrsaliye == "1")).Sum(c => c.Miktar);
            return res;
        }
        public decimal? MevcutStok(NetSatisContext context, int StokId)
        {

            var res = StokGiris(context, StokId) - StokCikis(context, StokId);
         
            return res;
        }

        #endregion


        #region Kar zarar işlemleri

        public decimal? StokKar(NetSatisContext context, int StokId)
        {
            var res = context.StokHareketleri
                .Where(c => c.StokId == StokId && c.Hareket == "Stok Giriş" || (c.FisTuru == "Alış İrsaliyesi" && c.StokIrsaliye == "1")).AsNoTracking();
            var sonuc = res.Count() / res.Sum(c => c.SatisFiyati);
            return sonuc;
        }

        #endregion 
    }
}
