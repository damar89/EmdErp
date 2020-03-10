using DevExpress.DataAccess.ObjectBinding;
using System;

namespace NetSatis.Entities.Tables
{
    [HighlightedClass]
    public class FisKooperatifKalemler
    {
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Birim { get; set; }
        public Nullable<decimal> IskontoOrani1 { get; set; }
        public Nullable<decimal> IskontoTutari1 { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }
    }
}
