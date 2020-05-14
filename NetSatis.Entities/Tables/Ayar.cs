using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Ayar:IEntity
    {
        public int Id { get; set; }
        public string HizliSatisOnEki { get; set; }
        public int HizliSatisSiradakiNo { get; set; }
        public string ToptanSatisOnEki { get; set; }
        public int ToptanSatisSiradakiNo { get; set; }
        public int Barkod { get; set; }

    }
}
