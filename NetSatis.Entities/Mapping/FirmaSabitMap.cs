using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class FirmaSabitMap : EntityTypeConfiguration<FirmaSabitleri>
    {
        public FirmaSabitMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FirmaAdi).HasMaxLength(500);
            this.Property(p => p.Adres).HasMaxLength(500);
            this.Property(p => p.Il).HasMaxLength(500);
            this.Property(p => p.Ilce).HasMaxLength(500);
            this.Property(p => p.Telefon).HasMaxLength(500);
            this.Property(p => p.PostaKodu).HasMaxLength(500);
            this.Property(p => p.Fax).HasMaxLength(500);
            this.Property(p => p.MersisNo).HasMaxLength(500);
            this.Property(p => p.TicariSicilNo).HasMaxLength(500);
            this.Property(p => p.Mail).HasMaxLength(500);
            this.Property(p => p.VergiDairesi).HasMaxLength(500);
            this.Property(p => p.VergiNo).HasMaxLength(500);
            this.ToTable("FirmaSabitler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FirmaAdi).HasColumnName("FirmaAdi");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.PostaKodu).HasColumnName("PostaKodu");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.MersisNo).HasColumnName("MersisNo");
            this.Property(p => p.TicariSicilNo).HasColumnName("TicariSicilNo");
            this.Property(p => p.Mail).HasColumnName("Mail");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");

        }
    }
}
