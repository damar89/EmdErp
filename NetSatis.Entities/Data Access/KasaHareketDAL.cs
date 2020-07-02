using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Linq;
namespace NetSatis.Entities.Data_Access
{
    public class KasaHareketDAL : EntityRepositoryBase<NetSatisContext, KasaHareket, KasaHareketValidator>
    {
        public object kasaHareket(NetSatisContext context, int kasaId, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.Kasalar.Where(c => c.Id == kasaId), c => c.KasaId, c => c.Id,
                (kasaHareketleri, kasalar) =>
                    new
                    {
                        kasaHareketleri.KasaId,
                        kasaHareketleri.Kasa,
                        kasaHareketleri.FisKodu,
                        kasaHareketleri.FisTuru,
                        kasaHareketleri.Hareket,
                        kasaHareketleri.Tarih,
                        kasaHareketleri.VadeTarihi,
                        kasaHareketleri.OdemeTuru,
                        kasaHareketleri.OdemeTuruId,
                        kasaHareketleri.Tutar,
                        kasaHareketleri.Aciklama,
                    }).ToList();
            return tablo;
        }
        public object kasaHareketTarih(NetSatisContext context, int kasaId, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.KasaHareketleri.Where(c => c.KasaId == kasaId && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.Kasalar.Where(c => c.Id == kasaId), c => c.KasaId, c => c.Id,
                (kasaHareketleri, kasalar) =>
                    new
                    {
                        kasaHareketleri.KasaId,
                        kasaHareketleri.Kasa,
                        kasaHareketleri.FisKodu,
                        kasaHareketleri.Hareket,
                        kasaHareketleri.FisTuru,
                        kasaHareketleri.Tarih,
                        kasaHareketleri.VadeTarihi,
                        kasaHareketleri.OdemeTuru,
                        kasaHareketleri.Tutar,
                        kasaHareketleri.Aciklama,
                    }).ToList();
            return tablo;
        }
        public object MasrafHareket(NetSatisContext context, string fisTuru, DateTime baslangic, DateTime bitis)
        {
            var tablo = context.KasaHareketleri.Where(c => c.FisTuru == fisTuru && c.Tarih >= baslangic && c.Tarih <= bitis).GroupJoin(
                context.KasaHareketleri.Where(c => c.FisTuru == fisTuru), c => c.CariId, c => c.CariId,
                (fisler, cariler) =>
                   new
                   {
                       fisler.Id,
                       fisler.FisKodu,
                       fisler.FisTuru,
                       fisler.Tarih,
                       fisler.VadeTarihi,
                       fisler.Aciklama,
                       fisler.Tutar
                   }).Select(k => new
                   {
                       k.Id,
                       k.FisKodu,
                       k.FisTuru,
                       k.Tarih,
                       k.VadeTarihi,
                       k.Aciklama,
                       k.Tutar
                   }).ToList();
            return tablo;
        }
    }
}
