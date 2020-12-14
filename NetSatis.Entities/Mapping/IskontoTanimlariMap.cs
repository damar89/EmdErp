using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class IskontoTanimlariMap: EntityTypeConfiguration<IskontoTanimlari>
    {
        public IskontoTanimlariMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokIskontoKodu).HasMaxLength(10);
            this.Property(p => p.CariSinifKodu).HasMaxLength(10);
            this.Property(p => p.Aciklama).HasMaxLength(95);
            this.Property(p => p.Iskonto1).HasPrecision(5,2);
            this.Property(p => p.Iskonto2).HasPrecision(5, 2);
            this.Property(p => p.Iskonto3).HasPrecision(5, 2); 
            this.ToTable("IskontoTanimlari");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.StokIskontoKodu).HasColumnName("StokIskontoKodu");
            this.Property(p => p.CariSinifKodu).HasColumnName("CariSinifKodu");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.Iskonto1).HasColumnName("Iskonto1");
            this.Property(p => p.Iskonto2).HasColumnName("Iskonto2");
            this.Property(p => p.Iskonto3).HasColumnName("Iskonto3");



        }
    }
}
