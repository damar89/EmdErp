using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class IskontoTanimlari: IEntity
    {
        public int Id { get; set; }
        public string StokIskontoKodu { get; set; }
        public string CariSinifKodu { get; set; }
        public string Aciklama { get; set; }

        public decimal Iskonto1 { get; set; }
        public decimal Iskonto2 { get; set; }
        public decimal Iskonto3 { get; set; }


    }
}
