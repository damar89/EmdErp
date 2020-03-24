using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class IndirimMap : EntityTypeConfiguration<Indirim>
    {
        public IndirimMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(75);
            this.Property(p => p.StokAdi).HasMaxLength(75);
            this.Property(p => p.Barkodu).HasMaxLength(20);
            this.Property(p => p.IndirimTuru).HasMaxLength(20);
            this.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("Indirimler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkodu).HasColumnName("Barkodu");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.IndirimTuru).HasColumnName("IndirimTuru");
            this.Property(p => p.BaslangicTarihi).HasColumnName("BaslangicTarihi");
            this.Property(p => p.BitisTarihi).HasColumnName("BitisTarihi");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");

        }
    }
}
