using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
  public class Indirim:IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Barkodu { get; set; }
        public string IndirimTuru { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public DateTime? BaslangicTarihi { get; set; }
        public DateTime? BitisTarihi { get; set; }
        public decimal IndirimOrani { get; set; }
        public string Aciklama { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

    }
}
