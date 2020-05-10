using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Tables
{
   public class OzelKodMap : EntityTypeConfiguration<OzelKod>
    {
        public OzelKodMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OzelKodAdi).HasMaxLength(120);
            this.Property(p => p.Kod).HasMaxLength(75);

            this.ToTable("OzelKod");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.OzelKodAdi).HasColumnName("OzelKodAdi");
            this.Property(p => p.Kod).HasColumnName("Kod");
        }
    }
}
