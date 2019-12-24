using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetSatis.Entities.Tables
{
    [Table("tbApi")]
    public class Api
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Key { get; set; }
        public Guid ValidKey { get; set; }
        public bool IsActivate { get; set; }
    }
}
