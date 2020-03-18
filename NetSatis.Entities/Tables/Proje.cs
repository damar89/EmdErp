using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class Proje : IEntity
    {
        public int Id { get; set; }
        public string ProjeAdi { get; set; }
        public string Kod { get; set; }
    }
}
