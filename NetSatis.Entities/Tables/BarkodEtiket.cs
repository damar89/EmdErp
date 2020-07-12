using NetSatis.Entities.Interface;
using System;

namespace NetSatis.Entities.Tables
{
    public class BarkodEtiket : IEntity
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string StokAdi { get; set; }
        public string Barkodu { get; set; }
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
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<decimal> MevcutStok { get; set; }
        public Nullable<decimal> AlisFiyati1 { get; set; }
        public Nullable<decimal> AlisFiyati2 { get; set; }
        public Nullable<decimal> AlisFiyati3 { get; set; }
        public Nullable<decimal> SatisFiyati1 { get; set; }
        public Nullable<decimal> SatisFiyati2 { get; set; }
        public Nullable<decimal> SatisFiyati3 { get; set; }
        public Nullable<decimal> SatisFiyati4 { get; set; }
        public string Aciklama { get; set; }
        public int SatisKdv { get; set; }

    }
}
