using NetSatis.Entities.Interface;
using System;
using System.Collections.Generic;

namespace NetSatis.Entities.Tables
{
    public class Kasa : IEntity
    {
        public int Id { get; set; }
        public string KasaKodu { get; set; }
        public string KasaAdi { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string YetkiliKodu { get; set; }
        public string YetkiliAdi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }
    }
}
