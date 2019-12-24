using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmdSoft.Lisans.Controllers
{
    public class LisansController : ApiController
    {
        [Route("api/LisansGenerator/{Key}")]
        [HttpGet]
        public bool LisansGenerator(string Key)
        {
            //FirmaOlustur();
            Guid lickey=new Guid(Key);
            using (VTContext db=new VTContext())
            {
                var list=db.LicKeyGenerators.Where(x=>x.LicKey==lickey).Where(x=>x.IsActive==true).FirstOrDefault();
                if(list!=null)
                {
                    return list.IsActive;
                }
                else
                {
                    return false;
                }
            }
        }
        [Route("api/LisansOlustur")]
        [HttpPost]
        public List<Models.LicKeyGenerator> LisansOlustur(Models.LicKeyGenerator lisans)
        {
            //var request = (HttpWebRequest)WebRequest.Create(url);
            //var response = (HttpWebResponse)request.GetResponse();
            //var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            List<Models.LicKeyGenerator> g=new List<Models.LicKeyGenerator>();
            Models.LicKeyGenerator l=new Models.LicKeyGenerator
            {
                IsActive=lisans.IsActive,
                FirmaAdi=lisans.FirmaAdi,
                Email=lisans.Email,
                Id=Guid.NewGuid(),
                LicKey=Guid.NewGuid(),
                Telefon=lisans.Telefon,
                VDNo=lisans.VDNo,
                VergiDairesi=lisans.VergiDairesi
            };
            g.Add(l);
            using (VTContext db=new VTContext())
            {
                db.LicKeyGenerators.Add(l);
                db.SaveChanges();
                return g.ToList();
            }
        }
        [Route("api/MusteriListesi")]
        [HttpGet]
        public List<Models.LicKeyGenerator> MusteriListesi()
        {
            using (VTContext db=new VTContext())
            {
                var list=db.LicKeyGenerators.ToList();
                return list;
            }
        }
        [Route("api/LisansDevreDisi")]
        [HttpPost]
        public void LisansDevreDisi(string VdNo)
        {
            using (VTContext db=new VTContext())
            {
                var list=db.LicKeyGenerators.Where(x=>x.VDNo==VdNo).FirstOrDefault();
                list.IsActive=false;
                db.SaveChanges();
            }
        }
        [Route("api/LisansDevreActive")]
        [HttpPost]
        public void LisansDevreActive(string VdNo)
        {
            using (VTContext db=new VTContext())
            {
                var list=db.LicKeyGenerators.Where(x=>x.VDNo==VdNo).FirstOrDefault();
                list.IsActive=true;
                db.SaveChanges();
            }
        }
    }
}
