using NetSatis.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
    public class RaporTasarimlari : IEntity
    {
        public int Id { get; set; }
        public string DizaynIsmi { get; set; }
        public string DizaynTipi { get; set; }
        public byte[] Dizayn { get; set; }
    }
}
