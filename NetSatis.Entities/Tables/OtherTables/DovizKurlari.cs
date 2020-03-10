using System;

namespace NetSatis.Entities.Tables.OtherTables
{
    public class DovizKurlari
    {
        public string CurrencyCode { get; set; }
        public string Isim { get; set; }
        public Nullable<decimal> ForexBuying { get; set; }
        public Nullable<decimal> ForexSelling { get; set; }
        public Nullable<decimal> BanknoteBuying { get; set; }
        public Nullable<decimal> BanknoteSelling { get; set; }

    }
}
