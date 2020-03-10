using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class AyarMap : EntityTypeConfiguration<Ayar>
    {
        public AyarMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.ToTable("Ayarlar");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.HizliSatisOnEki).HasColumnName("HizliSatisOnEki");
            this.Property(p => p.HizliSatisSiradakiNo).HasColumnName("HizliSatisSiradakiNo");
            this.Property(p => p.ToptanSatisOnEki).HasColumnName("ToptanSatisOnEki");
            this.Property(p => p.ToptanSatisSiradakiNo).HasColumnName("ToptanSatisSiradakiNo");
        }

    }
}
