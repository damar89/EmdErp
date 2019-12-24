using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.ObjectBinding;

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
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> AraToplam_ { get; set; }
        public Nullable<decimal> Borsa { get; set; }
        public Nullable<decimal> Bagkur { get; set; }
        public Nullable<decimal> Zirai { get; set; }
        public Nullable<decimal> Mera { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public string ToplamTutarYazi { get; set; }
        public string Aciklama { get; set; }
    }
}
