using NetSatis.Entities.Interface;
using System;

namespace NetSatis.Entities.Tables
{
    public class Barkod:IEntity
    {
        public int Id { get; set; }
        public Nullable<int> StokId { get; set; }
        public string Barkodu { get; set; }
        public virtual Stok Stok { get; set; }
    }
}
