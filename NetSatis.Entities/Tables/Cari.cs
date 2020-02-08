using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Cari : IEntity
    {
        public int Id { get; set; }
        public bool Durum { get; set; }
        public string CariTuru { get; set; }
        public string CariSinif { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string YetkiliKisi { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string CepTelefonu2 { get; set; }
        public string CepTelefonu3 { get; set; }
        public string Telefon { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string EMail2 { get; set; }
        public string Web { get; set; }
        public string Adres { get; set; }
         public string Adres2 { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string CariGrubu { get; set; }
        public string CariAltGrubu { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
        public string OzelKod4 { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public decimal? IskontoOrani { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public decimal? RiskLimiti { get; set; }
        public string AlisOzelFiyati { get; set; }
        public string SatisOzelFiyati { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
        //public virtual ICollection<StokHareket> StokHareket { get; set; }
        public virtual ICollection<Fis> Fis { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

    }
}
