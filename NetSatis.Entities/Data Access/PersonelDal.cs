using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;

namespace NetSatis.Entities.Data_Access
{
    public class PersonelDal : EntityRepositoryBase<NetSatisContext, Personel, PersonelValidator>
    {
        public object PersonelListele(NetSatisContext context)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.Id, c => c.PlasiyerId,
                (personel, fis) => new
                {
                    personel.Id,
                    personel.Calisiyor,
                    personel.PersonelKodu,
                    personel.PersonelAdi,
                    personel.Unvani,
                    personel.TcKimlikNo,
                    personel.IseGirisTarihi,
                    personel.IstenCikisTarihi,
                    personel.VergiDairesi,
                    personel.VergiNo,
                    personel.CepTelefonu,
                    personel.Telefon,
                    personel.Fax,
                    personel.Il,
                    personel.Ilce,
                    personel.Semt,
                    personel.Adres,
                    personel.Email,
                    personel.Web,
                    personel.PrimOrani,
                    personel.AylikMaasi,
                    personel.Aciklama,
                    ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası").Sum(c => c.ToplamTutar) ?? 0,
                    PrimTutar = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası" || c.FisTuru == "Toptan Satış Faturası").Sum(c => c.ToplamTutar) ?? 0) /
                                100 * personel.PrimOrani

                }).ToList();
            return result;
        }
        public object TariheGorePersonelListele(NetSatisContext context, int Ay, int Yil)
        {
            var result = context.Personeller.GroupJoin(context.Fisler, c => c.Id, c => c.PlasiyerId,
                (personel, fis) => new
                {
                    personel.Id,
                    personel.Calisiyor,
                    personel.PersonelKodu,
                    personel.PersonelAdi,
                    personel.Unvani,
                    personel.TcKimlikNo,
                    personel.IseGirisTarihi,
                    personel.IstenCikisTarihi,
                    personel.VergiDairesi,
                    personel.VergiNo,
                    personel.CepTelefonu,
                    personel.Telefon,
                    personel.Fax,
                    personel.Il,
                    personel.Ilce,
                    personel.Semt,
                    personel.Adres,
                    personel.Email,
                    personel.Web,
                    personel.PrimOrani,
                    personel.AylikMaasi,
                    personel.Aciklama,
                    ToplamSatis = fis.Where(c => c.FisTuru == "Perakende Satış Faturası" && c.FisTuru == "Toptan Satış Faturası" && c.Tarih.Value.Month == Ay && c.Tarih.Value.Year == Yil).Sum(c => c.ToplamTutar) ?? 0,
                    PrimTutar = (fis.Where(c => c.FisTuru == "Perakende Satış Faturası" && c.FisTuru == "Toptan Satış Faturası" && c.Tarih.Value.Month == Ay && c.Tarih.Value.Year == Yil).Sum(c => c.ToplamTutar) ?? 0) /
                                100 * personel.PrimOrani


                }).ToList();
            return result;
        }

        public object PersonelFisToplam(NetSatisContext context, int personelId)
        {
            var result = (from c in context.Fisler.Where(c => c.PlasiyerId == personelId)
                          group c by new { c.FisTuru }
                into grp
                          select new
                          {
                              Bilgi = grp.Key.FisTuru,
                              KayitSayisi = grp.Count(),
                              ToplamTutar = grp.Sum(c => c.ToplamTutar)
                          }).ToList();
            return result;
        }

    }
}
