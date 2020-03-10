using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class BarkodEtiketMap : EntityTypeConfiguration<BarkodEtiket>
    {
        public BarkodEtiketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(150);
            this.Property(p => p.StokAdi).HasMaxLength(500);
            this.Property(p => p.Barkodu).HasMaxLength(35);
            this.Property(p => p.AlisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.Miktar).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati3).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati4).HasPrecision(12, 2);
            this.Property(p => p.Birim).HasMaxLength(50);
            this.Property(p => p.Kategori).HasMaxLength(60);
            this.Property(p => p.AnaGrup).HasMaxLength(30);
            this.Property(p => p.AltGrup).HasMaxLength(30);
            this.Property(p => p.Marka).HasMaxLength(30);
            this.Property(p => p.Uretici).HasMaxLength(30);
            this.Property(p => p.Modeli).HasMaxLength(30);
            this.Property(p => p.Proje).HasMaxLength(30);
            this.Property(p => p.Pozisyon).HasMaxLength(30);
            this.Property(p => p.SezonYil).HasMaxLength(30);
            this.Property(p => p.OzelKodu).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("BarkodEtiketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkodu).HasColumnName("Barkodu");
            this.Property(p => p.Birim).HasColumnName("Birim");
            this.Property(p => p.Kategori).HasColumnName("Kategori");
            this.Property(p => p.AnaGrup).HasColumnName("AnaGrup");
            this.Property(p => p.AltGrup).HasColumnName("AltGrup");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Marka).HasColumnName("Marka");
            this.Property(p => p.Uretici).HasColumnName("Uretici");
            this.Property(p => p.Modeli).HasColumnName("Modeli");
            this.Property(p => p.Proje).HasColumnName("Proje");
            this.Property(p => p.Pozisyon).HasColumnName("Pozisyon");
            this.Property(p => p.SezonYil).HasColumnName("SezonYil");
            this.Property(p => p.OzelKodu).HasColumnName("OzelKodu");
            this.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
            this.Property(p => p.AlisFiyati1).HasColumnName("AlisFiyati1");
            this.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
            this.Property(p => p.SatisFiyati1).HasColumnName("SatisFiyati1");
            this.Property(p => p.SatisFiyati2).HasColumnName("SatisFiyati2");
            this.Property(p => p.SatisFiyati3).HasColumnName("SatisFiyati3");
            this.Property(p => p.SatisFiyati4).HasColumnName("SatisFiyati4");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }

    }
}
