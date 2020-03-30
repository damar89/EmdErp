using NetSatis.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSatis.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }

        [NotMapped]
        public int SiraNo { get; set; } = 0;
        public string FisKodu { get; set; }
        public string FisSeri { get; set; }
        public string Sira { get; set; }
        public string Tipi { get; set; }
        public string Hareket { get; set; }
        public string Proje { get; set; }
        public string OzelKod { get; set; }
        public string StokIrsaliye { get; set; }
        public string FisTuru { get; set; }
        public int StokId { get; set; }
        //public int CariId { get; set; }
        public decimal? Miktar { get; set; } = 1;
        public int Kdv { get; set; } = 0;
        public decimal? Borsa { get; set; } = 0;
        public decimal? Bagkur { get; set; } = 0;
        public decimal? Zirai { get; set; } = 0;
        public decimal? Mera { get; set; } = 0;
        public decimal? BirimFiyati { get; set; } = 0;
        public decimal? SatisFiyati { get; set; } = 0;
        public decimal? IndirimOrani { get; set; } = 0;
        public decimal? IndirimOrani2 { get; set; } = 0;
        public decimal? IndirimOrani3 { get; set; } = 0;
        public int DepoId { get; set; }
        public string SeriNo { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Barkod> Barkod { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual Depo Depo { get; set; }
        //public virtual Cari Cari { get; set; }
        public decimal? KdvHaric_ { get; set; } = 0;
        public decimal? KdvToplam { get; set; } = 0;
        public decimal? ToplamTutar { get; set; } = 0;
        public decimal? IndirimTutar { get; set; } = 0;
        public decimal? IndirimTutar2 { get; set; } = 0;
        public decimal? IndirimTutar3 { get; set; } = 0;
        public decimal? AraToplam { get; set; } = 0;
        public decimal? MaliyetFiyati { get; set; } = 0;
        public decimal? DipIskontoPayi { get; set; } = 0;

        [NotMapped]
        public decimal? KarOrani
        {
            get {
                if (!SatisFiyati.HasValue)
                    return 0;
                if (!BirimFiyati.HasValue || BirimFiyati.Value == 0)
                    return SatisFiyati.Value * 100;

                var res = (SatisFiyati.Value * 100) / BirimFiyati.Value;
                return res - 100;
            }
        }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

        public Guid TempId { get; set; } = Guid.NewGuid();
    }
}
