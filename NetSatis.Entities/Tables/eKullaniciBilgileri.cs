using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class eKullaniciBilgileri:IEntity
    {
         public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
