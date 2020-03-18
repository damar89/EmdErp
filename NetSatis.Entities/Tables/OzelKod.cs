using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class OzelKod : IEntity
    {
        public int Id { get; set; }
        public string OzelKodAdi { get; set; }
        public string Kod { get; set; }
    }
}
