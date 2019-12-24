using System;
using System.Collections.Generic;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class StokHareket : IEntity
    {
        public int Id { get; set; }
        public string FisKodu { get; set; }
        public string FisSeri { get; set; }
        public string Sira { get; set; }
        public string Tipi { get; set; }
        public string Hareket { get; set; }
        public string StokIrsaliye { get; set; }
        public string FisTuru { get; set; }
        public int StokId { get; set; }
        //public int CariId { get; set; }
        public decimal? Miktar { get; set; }
        public int Kdv { get; set; }
        public decimal? Borsa { get; set; }
        public decimal? Bagkur { get; set; }
        public decimal? Zirai { get; set; }
        public decimal? Mera { get; set; }
        public decimal? BirimFiyati { get; set; }
        public decimal? IndirimOrani { get; set; }
        public decimal? IndirimOrani2 { get; set; }
        public decimal? IndirimOrani3 { get; set; }
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
        public decimal? KdvHaric_ { get; set; }
        public decimal? KdvToplam { get; set; }
        public decimal? ToplamTutar { get; set; }
        public decimal? IndirimTutar { get; set; }
        public decimal? IndirimTutar2 { get; set; }
        public decimal? IndirimTutar3 { get; set; }
        public decimal? AraToplam { get; set; }
        public decimal? MaliyetFiyati { get; set; }
        public decimal? DipIskontoPayi { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

    }
}
