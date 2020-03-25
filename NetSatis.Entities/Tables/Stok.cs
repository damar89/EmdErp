using NetSatis.Entities.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSatis.Entities.Tables
{
    public class Stok : IEntity
    {
        public int Id { get; set; }
        public bool Durumu { get; set; }
        public bool WebAcikMi { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Barkodu { get; set; }
        public string BarkodTuru { get; set; }
        public string Birim { get; set; }
        public string Kategori { get; set; }
        public string AnaGrup { get; set; }
        public string AltGrup { get; set; }
        public string Marka { get; set; }
        public string Uretici { get; set; }
        public string Modeli { get; set; }
        public string Proje { get; set; }
        public string Pozisyon { get; set; }
        public string SezonYil { get; set; }
        public string OzelKodu { get; set; }
        public string GarantiSuresi { get; set; }
        public int AlisKdv { get; set; }
        public int SatisKdv { get; set; }
        public decimal? StokIskontoOrani { get; set; }
        //public byte[] ResimUrl { get; set; }
        public decimal? Bagkur { get; set; }
        public decimal? Borsa { get; set; }
        public decimal? Zirai { get; set; }
        public decimal? Mera { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public decimal? AlisFiyati1 { get; set; }
        public decimal? AlisFiyati2 { get; set; }
        public decimal? AlisFiyati3 { get; set; }
        [NotMapped]
        public decimal? KarOrani
        {
            get
            {
                decimal r = 0;
                r = SatisFiyati1.Value * 100 / AlisFiyati1.Value;
                return 0;
            }
        }
        public decimal? SatisFiyati1 { get; set; }
        public decimal? SatisFiyati2 { get; set; }
        public decimal? SatisFiyati3 { get; set; }
        public decimal? SatisFiyati4 { get; set; }
        public decimal? WebSatisFiyati { get; set; }
        public decimal? WebBayiSatisFiyati { get; set; }
        public decimal? MinmumStokMiktari { get; set; }
        public decimal? MaxmumStokMiktari { get; set; }
        public string Aciklama { get; set; }
        public byte[] Resim { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }
        public virtual ICollection<Barkod> Barkod { get; set; }
        public virtual ICollection<StokHareket> StokHareket { get; set; }

    }
}
