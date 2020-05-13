using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NetSatis.Entities.Data_Access
{
    public class KasaDAL : EntityRepositoryBase<NetSatisContext, Kasa, KasaValidator>
    {
        public object KasaListele(NetSatisContext context)
        {
            var result = context.Kasalar.GroupJoin(context.KasaHareketleri, c => c.Id, c => c.KasaId,
                (kasa, kasahareket) => new
                {
                    kasa.Id,
                    kasa.KasaKodu,
                    kasa.KasaAdi,
                    kasa.YetkiliKodu,
                    kasa.YetkiliAdi,
                    kasa.Aciklama,
                    KasaGiris = (kasahareket.Where(c => c.KasaId == kasa.Id && c.Hareket == "Kasa Giriş")
                                     .Sum(c => c.Tutar) ?? 0),
                    KasaCikis = (kasahareket.Where(c => c.KasaId == kasa.Id && c.Hareket == "Kasa Çıkış")
                                     .Sum(c => c.Tutar) ?? 0),
                    Bakiye =
                        (kasahareket.Where(c => c.KasaId == kasa.Id && c.Hareket == "Kasa Giriş").Sum(c => c.Tutar) ??
                         0) - (kasahareket.Where(c => c.KasaId == kasa.Id && c.Hareket == "Kasa Çıkış")
                                   .Sum(c => c.Tutar) ?? 0)
                }).ToList();
            return result;
        }
        public object OdemeTuruToplamKasaTariheGoreListele(NetSatisContext context, Expression<Func<KasaHareket, bool>> pred = null)
        {

            IQueryable<KasaHareket> KasaHareketleri;
            if (pred == null)
                KasaHareketleri = context.KasaHareketleri.AsNoTracking();
            else
                KasaHareketleri = context.KasaHareketleri.AsNoTracking().Where(pred);

            var res = (from k in KasaHareketleri
                       group k by new { k.OdemeTuru, k.Tarih } into grp
                       select new
                       {
                           grp.Key.OdemeTuru.OdemeTuruAdi,
                           grp.Key.Tarih,
                           KasaGiris = grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Giriş").Sum(s => s.Tutar) ?? 0,
                           KasaCikis = grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Çıkış").Sum(s => s.Tutar) ?? 0,
                           Bakiye = (grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Giriş").Sum(s => s.Tutar) ?? 0) - (grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Çıkış").Sum(s => s.Tutar) ?? 0)
                       }).ToList();

            var r = (from x in res.GroupBy(s => s.Tarih.Value.Date)
                     select new
                     {
                         Tarih = x.Key,
                         KrediKarti = x.Where(s => s.OdemeTuruAdi == "Kredi Kartı").Sum(s => s.Bakiye),
                         Nakit = x.Where(s => s.OdemeTuruAdi == "Nakit").Sum(s => s.Bakiye),
                         KasaToplam = x.Where(s => s.OdemeTuruAdi == "Kredi Kartı").Sum(s => s.Bakiye) + x.Where(s => s.OdemeTuruAdi == "Nakit").Sum(s => s.Bakiye),
                     });

            return r.OrderByDescending(x=>x.Tarih); 
            #region eski kodlar
            //old code
            //var result = (from c in context.KasaHareketleri.Where(c => c.KasaId == kasaId)
            //              group c by new { c.OdemeTuru }
            //into grp
            //              select new
            //              {
            //                  grp.Key.OdemeTuru.OdemeTuruAdi,
            //                  KasaGiris = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş")
            //                                   .Sum(c => c.Tutar) ?? 0),
            //                  KasaCikis = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış")
            //                                   .Sum(c => c.Tutar) ?? 0),
            //                  Bakiye =
            //                      (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş")
            //                           .Sum(c => c.Tutar) ?? 0) -
            //                      (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış")
            //                           .Sum(c => c.Tutar) ?? 0)
            //              }).ToList();
            //return result; 
            #endregion
        }
        public object OdemeTuruToplamListele(NetSatisContext context, int kasaId, Expression<Func<KasaHareket, bool>> pred = null)
        {

            IQueryable<KasaHareket> KasaHareketleri;
            if (pred == null)
                KasaHareketleri = context.KasaHareketleri.AsNoTracking();
            else
                KasaHareketleri = context.KasaHareketleri.AsNoTracking().Where(pred);

            var res = (from k in KasaHareketleri.Where(x => x.KasaId == kasaId)
                       group k by new { k.OdemeTuru } into grp
                       select new
                       {
                           grp.Key.OdemeTuru.OdemeTuruAdi,
                           KasaGiris = grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Giriş").Sum(s => s.Tutar) ?? 0,
                           KasaCikis = grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Çıkış").Sum(s => s.Tutar) ?? 0,
                           Bakiye = (grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Giriş").Sum(s => s.Tutar) ?? 0) - (grp.Where(x => x.OdemeTuruId == grp.Key.OdemeTuru.Id && x.Hareket == "Kasa Çıkış").Sum(s => s.Tutar) ?? 0)
                       }).ToList();

            return res;
            #region eski kodlar
            //old code
            //var result = (from c in context.KasaHareketleri.Where(c => c.KasaId == kasaId)
            //              group c by new { c.OdemeTuru }
            //into grp
            //              select new
            //              {
            //                  grp.Key.OdemeTuru.OdemeTuruAdi,
            //                  KasaGiris = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş")
            //                                   .Sum(c => c.Tutar) ?? 0),
            //                  KasaCikis = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış")
            //                                   .Sum(c => c.Tutar) ?? 0),
            //                  Bakiye =
            //                      (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş")
            //                           .Sum(c => c.Tutar) ?? 0) -
            //                      (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış")
            //                           .Sum(c => c.Tutar) ?? 0)
            //              }).ToList();
            //return result; 
            #endregion
        }
        //public object OdemeTuruToplamListeleTarih(NetSatisContext context, int kasaId, DateTime baslangic, DateTime bitis)
        //{
        //    //burası test ediliyor
        //    //var res2 = OdemeTuruToplamListele(context, kasaId);
        //    var res = OdemeTuruToplamListele(context, kasaId, x => x.Tarih >= baslangic && x.Tarih <= bitis);
        //    return res;

        //    #region eski kodlar

        //    //old code
        //    //var result = (from c in context.KasaHareketleri.Where(c => c.KasaId == kasaId)
        //    //              group c by new { c.OdemeTuru }
        //    //    into grp
        //    //              select new
        //    //              {
        //    //                  grp.Key.OdemeTuru.OdemeTuruAdi,
        //    //                  KasaGiris = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Giriş")
        //    //                                   .Sum(c => c.Tutar) ?? 0),
        //    //                  KasaCikis = (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Hareket == "Kasa Çıkış")
        //    //                                   .Sum(c => c.Tutar) ?? 0),
        //    //                  Bakiye =
        //    //                      (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Tarih >= baslangic && c.Tarih <= bitis && c.Hareket == "Kasa Giriş")
        //    //                           .Sum(c => c.Tutar) ?? 0) -
        //    //                      (grp.Where(c => c.OdemeTuruId == grp.Key.OdemeTuru.Id && c.Tarih >= baslangic && c.Tarih <= bitis && c.Hareket == "Kasa Çıkış")
        //    //                           .Sum(c => c.Tutar) ?? 0)
        //    //              }).ToList(); 
        //    //return result;

        //    #endregion
        //}
        public object GenelToplamListele(NetSatisContext context, int kasaId)
        {
            decimal KasaGiris = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Giriş")
                                    .Sum(c => c.Tutar) ?? 0;
            int KasaGirisKayitSayisi = context.KasaHareketleri
                .Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Giriş")
                .Count();
            decimal KasaCikis = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Çıkış")
                                    .Sum(c => c.Tutar) ?? 0;
            int KasaCikisKayitSayisi = context.KasaHareketleri
                .Where(c => c.KasaId == kasaId && c.Hareket == "Kasa Çıkış")
                .Count();
            List<GenelToplam> genelToplamlar = new List<GenelToplam>()
            {
                new GenelToplam()
                {
                    Bilgi = "Kasa Giriş",
                    KayitSayisi = KasaGirisKayitSayisi,
                    Tutar = KasaGiris
                },
                new GenelToplam()
                {
                    Bilgi = "Kasa Çıkış",
                    KayitSayisi = KasaCikisKayitSayisi,
                    Tutar = KasaCikis
                },
                new GenelToplam()
                {
                    Bilgi = "Bakiye",
                    KayitSayisi = KasaGirisKayitSayisi + KasaCikisKayitSayisi,
                    Tutar = KasaGiris - KasaCikis
                }
            };
            return genelToplamlar;
        }
    }
}
