using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class HizliSatisGrup:IEntity
    {
        public int Id { get; set; }
        public string GrupAdi { get; set; }
        public string Aciklama { get; set; }
   

    }
}
