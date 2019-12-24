using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class StokMap : EntityTypeConfiguration<Stok>
    {
        public StokMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StokKodu).HasMaxLength(75);
            this.Property(p => p.StokAdi).HasMaxLength(1500);
            this.Property(p => p.Barkodu).HasMaxLength(200);
            this.Property(p => p.BarkodTuru).HasMaxLength(170);
            this.Property(p => p.Birim).HasMaxLength(150);
            this.Property(p => p.Kategori).HasMaxLength(300);
            this.Property(p => p.AnaGrup).HasMaxLength(300);
            this.Property(p => p.AltGrup).HasMaxLength(300);
            this.Property(p => p.Marka).HasMaxLength(300);
            this.Property(p => p.Uretici).HasMaxLength(300);
            this.Property(p => p.Modeli).HasMaxLength(300);
            this.Property(p => p.Proje).HasMaxLength(300);
            this.Property(p => p.Pozisyon).HasMaxLength(300);
            this.Property(p => p.SezonYil).HasMaxLength(300);
            //this.Property(p => p.ResimUrl).HasMaxLength(16);
            this.Property(p => p.OzelKodu).HasMaxLength(300);
            this.Property(p => p.GarantiSuresi).HasMaxLength(105);
            this.Property(p => p.AlisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.AlisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati1).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati2).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati3).HasPrecision(12, 2);
            this.Property(p => p.SatisFiyati4).HasPrecision(12, 2);
            this.Property(p => p.WebSatisFiyati).HasPrecision(12, 2);
            this.Property(p => p.WebBayiSatisFiyati).HasPrecision(12, 2);
            this.Property(p => p.MaxmumStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.MinmumStokMiktari).HasPrecision(12, 3);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.ToTable("Stoklar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durumu).HasColumnName("Durumu");
            this.Property(p => p.WebAcikMi).HasColumnName("WebAcikMi");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.Barkodu).HasColumnName("Barkodu");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Birim).HasColumnName("Birim");
            this.Property(p => p.Kategori).HasColumnName("Kategori");
            this.Property(p => p.AnaGrup).HasColumnName("AnaGrup");
            this.Property(p => p.AltGrup).HasColumnName("AltGrup");
            this.Property(p => p.Marka).HasColumnName("Marka");
            this.Property(p => p.Uretici).HasColumnName("Uretici");
            this.Property(p => p.Modeli).HasColumnName("Modeli");
            this.Property(p => p.Proje).HasColumnName("Proje");
            this.Property(p => p.Pozisyon).HasColumnName("Pozisyon");
            this.Property(p => p.SezonYil).HasColumnName("SezonYil");
            this.Property(p => p.OzelKodu).HasColumnName("OzelKodu");
            this.Property(p => p.GarantiSuresi).HasColumnName("GarantiSuresi");
            this.Property(p => p.AlisKdv).HasColumnName("AlisKdv");
            this.Property(p => p.SatisKdv).HasColumnName("SatisKdv");
            this.Property(p => p.Zirai).HasColumnName("Zirai");
            this.Property(p => p.Mera).HasColumnName("Mera");
            this.Property(p => p.Borsa).HasColumnName("Borsa");
            this.Property(p => p.Bagkur).HasColumnName("Bagkur");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.AlisFiyati1).HasColumnName("AlisFiyati1");
            this.Property(p => p.AlisFiyati2).HasColumnName("AlisFiyati2");
            this.Property(p => p.AlisFiyati3).HasColumnName("AlisFiyati3");
            this.Property(p => p.SatisFiyati1).HasColumnName("SatisFiyati1");
            this.Property(p => p.SatisFiyati2).HasColumnName("SatisFiyati2");
            this.Property(p => p.SatisFiyati3).HasColumnName("SatisFiyati3");
            this.Property(p => p.SatisFiyati4).HasColumnName("SatisFiyati4");
            this.Property(p => p.WebSatisFiyati).HasColumnName("WebSatisFiyati");
            this.Property(p => p.WebBayiSatisFiyati).HasColumnName("WebBayiSatisFiyati");
            this.Property(p => p.MinmumStokMiktari).HasColumnName("MinmumStokMiktari");
            this.Property(p => p.MaxmumStokMiktari).HasColumnName("MaxmumStokMiktari");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");







        }
    }
}
