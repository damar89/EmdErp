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
        public int MasterGuncelle(Models.Donusum.Master _master)
        {
            string f = _master.FisKodu;
            using (VTContext db = new VTContext())
            {
                var temp = db.Master.FirstOrDefault(x => x.FisKodu == _master.FisKodu);
                temp.Aciklama = _master.Aciklama;
                temp.AlisVerisNo = _master.AlisVerisNo;
                temp.DokumanKodu = _master.DokumanKodu;
                temp.EditDate = _master.EditDate;
                temp.EditUser = _master.EditUser;
                temp.FisKodu = _master.FisKodu;
                temp.FisTuru = _master.FisTuru;
                temp.HareketTipi = _master.HareketTipi;
                temp.HarTip = _master.HarTip;
                temp.IslemTarihi = _master.IslemTarihi;
                temp.Kdv = _master.Kdv;
                temp.MusteriKodu = _master.MusteriKodu;
                temp.Matrah = _master.Matrah;
                temp.NetTutar = _master.NetTutar;
                temp.SaveDate = _master.SaveDate;
                temp.SaveUser = _master.SaveUser;
                temp.SeriKodu = _master.SeriKodu;
                temp.SiraKodu = _master.SiraKodu;
                temp.Tutar = _master.Tutar;
                temp.VadeTarihi = _master.VadeTarihi;
                temp.DipIskonto = _master.DipIskonto;
                db.SaveChanges();
            }
            return _master.Id;
        }
        public void MasterSil(int id)
        {
            using (VTContext db = new VTContext())
            {

                var temp = db.Master.Where(x => x.AlisVerisNo == id).FirstOrDefault();
                if (temp != null)
                {
                    db.Master.Remove(temp);
                    var detailTemp = db.Detail.Where(x => x.MasterId == temp.Id).ToList();
                    db.Detail.RemoveRange(detailTemp);
                }






                db.SaveChanges();
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
        public void DetailsGuncelle(Models.Donusum.Details _details)
        {
            using (VTContext db = new VTContext())
            {
                var temp = db.Detail.FirstOrDefault(x => x.MasterId == _details.MasterId && x.StokId == _details.StokId);
                temp.HareketTipi = _details.HareketTipi;
                temp.HarTip = _details.HarTip;
                temp.Isk1 = _details.Isk1;
                temp.Isk2 = _details.Isk2;
                temp.Isk3 = _details.Isk3;
                temp.IskontoTutar = _details.IskontoTutar;
                temp.Kdv = _details.Kdv;
                temp.KdvOrani = _details.KdvOrani;
                temp.KdvDahilFiyat = _details.KdvDahilFiyat;
                temp.MasterId = _details.MasterId;
                temp.Matrah = _details.Matrah;
                temp.Miktar = _details.Miktar;
                temp.MusteriKodu = _details.MusteriKodu;
                temp.StokId = _details.StokId;
                temp.Tutar = _details.Tutar;
                db.SaveChanges();
            }
        }
        public void DetailsSil(int id)
        {
            using (VTContext db = new VTContext())
            {
                var temp = db.Detail.FirstOrDefault(x => x.Id == id);
                db.Detail.Remove(temp);
                db.SaveChanges();
            }
        }
    }
}
