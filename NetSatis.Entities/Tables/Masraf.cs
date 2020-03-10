using NetSatis.Entities.Interface;
using System;
namespace NetSatis.Entities.Tables
{
    public class Masraf : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string MasrafKodu { get; set; }
        public string MasrafAdi { get; set; }
        public string Aciklama { get; set; }
        public string Grubu { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

        //public virtual ICollection<MasrafHareket> MasrafHareket { get; set; }
    }
}
