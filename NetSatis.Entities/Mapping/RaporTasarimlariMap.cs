using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class RaporTasarimlariMap : EntityTypeConfiguration<RaporTasarimlari>
    {
        public RaporTasarimlariMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.DizaynAraci).IsRequired();
            this.Property(p => p.DizaynAraci).HasColumnName("DizaynAraci");
            this.Property(p => p.DizaynIsmi).IsRequired();
            this.Property(p => p.DizaynIsmi).HasColumnName("DizaynIsmi");
            this.Property(p => p.DizaynIsmi).HasMaxLength(750);
            this.Property(p => p.DizaynTipi).HasColumnName("DizaynTipi");
            this.Property(p => p.DizaynTipi).HasMaxLength(100);
            this.Property(p => p.Dizayn).HasColumnType("varbinary(MAX)");
            this.Property(p => p.Dizayn).HasColumnName("Dizayn");

            this.ToTable("RaporTasarimlari");
             
        }
    }
}
