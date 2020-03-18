using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Mapping
{
    public class ProjeMap : EntityTypeConfiguration<Proje>
    {
        public ProjeMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.ProjeAdi).HasMaxLength(75);
            this.Property(p => p.Kod).HasMaxLength(75);

            this.ToTable("Proje");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.ProjeAdi).HasColumnName("ProjeAdi");
            this.Property(p => p.Kod).HasColumnName("Kod");
        }
    }
}
