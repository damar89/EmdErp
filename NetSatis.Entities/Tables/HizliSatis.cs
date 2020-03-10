using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class HizliSatis:IEntity
    {
        public int Id { get; set; }
        public string StokKodu { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyati { get; set; }
        public int GrupId { get; set; }
        public byte[] Resim { get; set; }
        

    }
} 
