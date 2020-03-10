using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class HizliSatisGrupMap:EntityTypeConfiguration<HizliSatisGrup>
    {
        public HizliSatisGrupMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.GrupAdi).HasMaxLength(75);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            
            this.ToTable("HizliSatisGruplari");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.GrupAdi).HasColumnName("GrupAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
          
          
        }
    }
}
