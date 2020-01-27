using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class eKullaniciBilgileriMap : EntityTypeConfiguration<eKullaniciBilgileri>
    {
        public eKullaniciBilgileriMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KullaniciAdi).HasMaxLength(500);
            this.Property(p => p.Sifre).HasMaxLength(500);

            this.ToTable("EKullaniciBilgileri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(p => p.Sifre).HasColumnName("Sifre");
        }
    }
}
