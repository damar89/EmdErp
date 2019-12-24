using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class KasaHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string Hareket { get; set; }
        public int KasaId { get; set; }
        public int OdemeTuruId { get; set; }
        public Nullable<int> CariId { get; set; }
        public DateTime? Tarih { get; set; }
        public Nullable<DateTime> VadeTarihi { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Aciklama { get; set; }
        public virtual Kasa Kasa { get; set; }
        public virtual OdemeTuru OdemeTuru { get; set; }
        public virtual Cari Cari { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

    }
}
