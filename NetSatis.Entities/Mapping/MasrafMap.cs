using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class MasrafMap : EntityTypeConfiguration<Masraf>
    {
        public MasrafMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.MasrafKodu).HasMaxLength(12);
            this.Property(p => p.MasrafAdi).HasMaxLength(75);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.Grubu).HasMaxLength(15);

            this.ToTable("Masraflar");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.MasrafKodu).HasColumnName("MasrafKodu");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.MasrafAdi).HasColumnName("MasrafAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.Grubu).HasColumnName("Grubu");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");

        }
    }
}
