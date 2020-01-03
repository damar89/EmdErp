using System.Collections.Generic;
using System.Linq;

namespace NetSatis.EDonusum.Controller
{
    public class EDonusumIslemleri
    {
        public void HareketTipiOlustur(string Kodu, string Aciklama)
        {
            using (VTContext db = new VTContext())
            {
                Models.Donusum.HareketTipi h = new Models.Donusum.HareketTipi
                {
                    Aciklama = Aciklama,
                    Kodu = Kodu
                };
                db.HareketTipi.Add(h);
                db.SaveChanges();
            }
        }
        public Models.Donusum.HareketTipi HareketTipiGetir(int id)
        {
            using (VTContext db = new VTContext())
            {

                return db.HareketTipi.Where(x => x.Id == id).FirstOrDefault();

            }
        }
        public List<Models.Donusum.HareketTipi> HareketTipiListele()
        {
            using (VTContext db = new VTContext())
            {
                var list = db.HareketTipi.ToList();
                return list;
            }
        }
        public int HareketIdGetir(string Aciklama)
        {
            using (VTContext db = new VTContext())
            {
                var list = db.HareketTipi.Where(x => x.Aciklama == Aciklama).FirstOrDefault();
                return list.Id;
            }
        }
        public void HareketTipiDuzenle(int id, string Kodu, string Aciklama)
        {
            using (VTContext db = new VTContext())
            {
                var list = db.HareketTipi.Where(x => x.Id == id).FirstOrDefault();
                list.Kodu = Kodu;
                list.Aciklama = Aciklama;
                db.SaveChanges();
            }
        }
        public void HareketTipiSil(int id)
        {
            using (VTContext db = new VTContext())
            {
                var list = db.HareketTipi.Where(x => x.Id == id).FirstOrDefault();
                db.HareketTipi.Remove(list);
                db.SaveChanges();
            }
        }
        public int MasterOlustur(Models.Donusum.Master _master)
        {
            string f = _master.FisKodu;
            using (VTContext db = new VTContext())
            {
                db.Master.Add(_master);
                db.SaveChanges();
            }
            using (VTContext dbs = new VTContext())
            {
                var list = dbs.Master.Where(x => x.FisKodu == f).FirstOrDefault();
                return list.Id;
            }
        }
        public void DetailsOlustur(Models.Donusum.Details _details)
        {
            using (VTContext db = new VTContext())
            {
                db.Detail.Add(_details);
                db.SaveChanges();
            }
        }
    }
}
