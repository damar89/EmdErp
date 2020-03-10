using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class FirmaSabitleri : IEntity
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string MersisNo { get; set; }
        public string TicariSicilNo { get; set; }
        public string Mail { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }

          
    }
}
