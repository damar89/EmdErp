using DevExpress.DataAccess.ObjectBinding;
using System;

namespace NetSatis.Entities.Tables
{
    [HighlightedClass]
    public class KooperatifEkstreModel
    {
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string Aciklama { get; set; }
        public decimal? SatirTutari { get; set; }
        public decimal? FisTutari { get; set; }
        public decimal? BirimFiyat { get; set; }
          public decimal? IndirimTutari { get; set; }
          public decimal? DipIndirim { get; set; }

        public string UrunAdi { get; set; }
        public string FisKodu { get; set; }
        public decimal? Miktar { get; set; }
        public string Birim { get; set; }
        public decimal? ZiraiToplam { get; set; }
        public decimal? MeraToplam { get; set; }
        public decimal? BagkurToplam { get; set; }
        public decimal? BorsaToplam { get; set; }

    }
}
