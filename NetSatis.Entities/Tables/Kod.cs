using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Kod:IEntity
    {
        public int Id { get; set; }
        public string Tablo { get; set; }
        public string OnEki { get; set; }
        public int SonDeger { get; set; }

    }
}
