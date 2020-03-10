using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class KasaHareketMap : EntityTypeConfiguration<KasaHareket>
    {
        public KasaHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.Hareket).HasMaxLength(20);
            this.Property(p => p.Tutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("KasaHareketleri");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.KasaId).HasColumnName("KasaId"); ;
            this.Property(p => p.OdemeTuruId).HasColumnName("OdemeTuruId");
            this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.VadeTarihi).HasColumnName("VadeTarihi");
            this.Property(p => p.Tutar).HasColumnName("Tutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");
            this.HasRequired(c => c.Kasa).WithMany(c => c.KasaHareket).HasForeignKey(c => c.KasaId);
            this.HasRequired(c => c.OdemeTuru).WithMany(c => c.KasaHareket).HasForeignKey(c => c.OdemeTuruId);
            this.HasOptional(c => c.Cari).WithMany(c => c.KasaHareket).HasForeignKey(c => c.CariId);



        }
    }
}
