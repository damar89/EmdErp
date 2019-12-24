using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class AnaGrupMap : EntityTypeConfiguration<AnaGrup>
    {
        public AnaGrupMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.AnaGrupAdi).HasMaxLength(75);
            this.Property(p => p.Kod).HasMaxLength(75);

            this.ToTable("Stok_AnaGruplar");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.AnaGrupAdi).HasColumnName("AltGrupiAdi");
            this.Property(p => p.Kod).HasColumnName("Kod");
               this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
                   this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");

        }
    }
}
