using NetSatis.Entities.Interface;
using System;

namespace NetSatis.Entities.Tables
{
    public class MasrafHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public int MasrafId { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<decimal> BirimFiyati { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public string Aciklama { get; set; }

      
        //public virtual Masraf Masraf { get; set; }
       
    }
}
