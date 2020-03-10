using DevExpress.DataAccess.ObjectBinding;
using System;

namespace NetSatis.Entities.Tables
{
    [HighlightedClass]
    public class FisKooperatif
    {
        public string FisKodu { get; set; }
        public string FisTuru { get; set; }
        public string FaturaUnvani { get; set; }
        public string CariAdi { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Semt { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string BelgeNo { get; set; }
        public DateTime? Tarih { get; set; }
        public decimal? AraToplam_ { get; set; }
        public decimal? Borsa { get; set; }
        public decimal? Bagkur { get; set; }
        public decimal? Zirai { get; set; }
        public decimal? Mera { get; set; }
        public decimal? ToplamTutar { get; set; }
        public string ToplamTutarYazi { get; set; }
        public string Aciklama { get; set; }
    }
}
