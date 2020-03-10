using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System.Linq;
namespace NetSatis.Entities.Data_Access
{
    public class DepoDAL:EntityRepositoryBase<NetSatisContext,Depo,DepoValidator>
    {
        public object DepoBazindaStokListele(NetSatisContext context, int stokId)
        {
            var result = context.Depolar.GroupJoin(context.StokHareketleri.Where(c => c.StokId == stokId),
                c => c.Id, c => c.DepoId, (depolar, stokhareketleri) => new
                {
                    depolar.Id,
                    depolar.DepoKodu,
                    depolar.DepoAdi,
                    depolar.YetkiliKodu,
                    depolar.YetkiliAdi,
                    depolar.Telefon,
                    depolar.Il,
                    depolar.Ilce,
                    depolar.Semt,
                    depolar.Adres,
                    StokGiris = stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0,
                    StokCikis = stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0,
                    MevcutStok = (stokhareketleri.Where(c => c.Hareket == "Stok Giriş").Sum(c => c.Miktar) ?? 0) -
                                 (stokhareketleri.Where(c => c.Hareket == "Stok Çıkış").Sum(c => c.Miktar) ?? 0)}).ToList();
            return result;
        }
    }
}
