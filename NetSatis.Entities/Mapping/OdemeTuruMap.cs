using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class OdemeTuruMap : EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("OdemeTurleri");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

        }
    }
}
