using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class MasrafHareketMap : EntityTypeConfiguration<MasrafHareket>
    {
        public MasrafHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(10);
            this.Property(p => p.Aciklama).HasMaxLength(200);
            this.Property(p => p.Miktar).HasPrecision(12, 3);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 3);

            this.ToTable("MasrafHareketleri");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.MasrafId).HasColumnName("StokId");
                   this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");

            //this.HasRequired(c => c.Masraf).WithMany(c => c.MasrafHareket).HasForeignKey(c => c.MasrafId);
        }
    }
}
