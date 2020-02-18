using System;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Fis : IEntity
    {
        public int Id { get; set; }
        public string Seri { get; set; }
        public string Sira { get; set; }
        public string Tipi { get; set; }
        public string FisKodu { get; set; }
        public string CariIrsaliye { get; set; }
        public string StokIrsaliye { get; set; }
        public string FisTuru { get; set; }
        public int? CariId { get; set; }
        public string CariAdi { get; set; }
        public string EMail { get; set; }
        public string FaturaUnvani { get; set; }
        public string CepTelefonu { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string BelgeNo { get; set; }
        public DateTime? Tarih { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int? PlasiyerId { get; set; }
        public decimal? IskontoOrani1 { get; set; }
        public decimal? IskontoTutari1 { get; set; }
        public decimal? DipIskOran { get; set; }
        public decimal? DipIskTutari { get; set; }
        public decimal? IskontoOrani2 { get; set; }
        public decimal? IskontoTutari2 { get; set; }
        public decimal? IskontoOrani3 { get; set; }
        public decimal? IskontoTutari3 { get; set; }
        public decimal? DipIskNetTutari { get; set; }
        public decimal? ToplamTutar { get; set; }
        #region Güncellenen KDVDahil Bilgi Alanı
        public bool KDVDahil { get; set; }
        #endregion
        public string Aciklama { get; set; }
        public virtual Cari Cari { get; set; }
        public virtual Personel Personel { get; set; }
        public decimal? AraToplam_ { get; set; }
        public decimal? KdvToplam_ { get; set; }
        public string IrsaliyeFisKodu { get; set; }
        public string SiparisFisKodu { get; set; }
        public string TeklifFisKodu { get; set; }
        public string FaturaFisKodu { get; set; }
        public string ProjeAdi { get; set; }
        public string OzelKod { get; set; }
        public string OzelKod2 { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }
        public bool EfaturaDurumu { get; set; }


    }
}
