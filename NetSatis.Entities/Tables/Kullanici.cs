using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public int? DepoId { get; set; }
        public int? KasaId { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Gorevi { get; set; }
        public string Parola { get; set; }
        public string HatirlatmaSorusu { get; set; }
        public string Cevap { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? SonGirisTarihi { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

    }
}
