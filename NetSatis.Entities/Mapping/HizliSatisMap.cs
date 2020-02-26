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
   public class HizliSatisMap:EntityTypeConfiguration<HizliSatis>
    {
        public HizliSatisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(65);
            this.Property(p => p.UrunAdi).HasMaxLength(120);
            this.Property(p => p.Fiyati).HasPrecision(12, 2);


            this.ToTable("HizliSatislar");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.UrunAdi).HasColumnName("UrunAdi");
            this.Property(p => p.Fiyati).HasColumnName("Fiyati");

        }
    }
}
