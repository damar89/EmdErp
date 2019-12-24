using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interface;

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
