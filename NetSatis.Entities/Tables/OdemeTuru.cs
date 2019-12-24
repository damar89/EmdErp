using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interface;

namespace NetSatis.Entities.Tables
{
    public class OdemeTuru : IEntity
    {
        public int Id { get; set; }
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string Aciklama { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }

        public virtual ICollection<KasaHareket> KasaHareket { get; set; }
    }
}
