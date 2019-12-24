using NetSatis.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class Kategori : IEntity
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Kod { get; set; }
         public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public int SaveUser { get; set; }
        public int EditUser { get; set; }
    }
}
