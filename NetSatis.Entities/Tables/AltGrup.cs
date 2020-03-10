using NetSatis.Entities.Interface;
using System;

namespace NetSatis.Entities.Tables
{
    public class AltGrup : IEntity
    {
         public int Id { get; set; }
        public string AltGrupAdi { get; set; }
        public string Kod { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }
    }
}
