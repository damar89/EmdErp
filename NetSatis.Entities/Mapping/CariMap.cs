using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class CariMap : EntityTypeConfiguration<Cari>
    {
        public CariMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CariTuru).HasMaxLength(50);
            this.Property(p => p.CariSinif).HasMaxLength(50);
            this.Property(p => p.CariKodu).HasMaxLength(50);
            this.Property(p => p.CariAdi).HasMaxLength(500);
            this.Property(p => p.YetkiliKisi).HasMaxLength(500);
            this.Property(p => p.FaturaUnvani).HasMaxLength(1500);
            this.Property(p => p.CepTelefonu).HasMaxLength(200);
            this.Property(p => p.CepTelefonu2).HasMaxLength(200);
            this.Property(p => p.CepTelefonu3).HasMaxLength(200);
            this.Property(p => p.Telefon).HasMaxLength(200);
            this.Property(p => p.Telefon2).HasMaxLength(200);
            this.Property(p => p.Telefon3).HasMaxLength(200);
            this.Property(p => p.Fax).HasMaxLength(200);
            this.Property(p => p.EMail).HasMaxLength(500);
            this.Property(p => p.EMail2).HasMaxLength(500);
            this.Property(p => p.Web).HasMaxLength(500);
            this.Property(p => p.Il).HasMaxLength(200);
            this.Property(p => p.Ilce).HasMaxLength(200);
            this.Property(p => p.Semt).HasMaxLength(200);
            this.Property(p => p.Adres).HasMaxLength(1000);
            this.Property(p => p.Adres2).HasMaxLength(1000);
            this.Property(p => p.CariGrubu).HasMaxLength(300);
            this.Property(p => p.CariAltGrubu).HasMaxLength(300);
            this.Property(p => p.OzelKod1).HasMaxLength(300);
            this.Property(p => p.OzelKod2).HasMaxLength(300);
            this.Property(p => p.OzelKod3).HasMaxLength(300);
            this.Property(p => p.OzelKod4).HasMaxLength(300);
            this.Property(p => p.VergiDairesi).HasMaxLength(400);
            this.Property(p => p.VergiNo).HasMaxLength(200);
            this.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            this.Property(p => p.RiskLimiti).HasPrecision(12, 2);
            this.Property(p => p.AlisOzelFiyati).HasMaxLength(15);
            this.Property(p => p.SatisOzelFiyati).HasMaxLength(15);
            this.Property(p => p.Aciklama).HasMaxLength(2000);

            this.ToTable("Cariler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Durum).HasColumnName("Durum");
            this.Property(p => p.Efatura).HasColumnName("Efatura");
            this.Property(p => p.CariTuru).HasColumnName("CariTuru");
            this.Property(p => p.CariSinif).HasColumnName("CariSinif");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.YetkiliKisi).HasColumnName("YetkiliKisi");
            this.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.CepTelefonu2).HasColumnName("CepTelefonu2");
            this.Property(p => p.CepTelefonu3).HasColumnName("CepTelefonu3");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Telefon2).HasColumnName("Telefon2");
            this.Property(p => p.Telefon3).HasColumnName("Telefon3");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.EMail2).HasColumnName("EMail2");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.Adres2).HasColumnName("Adres2");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.CariGrubu).HasColumnName("CariGrubu");
            this.Property(p => p.CariAltGrubu).HasColumnName("CariAltGrubu");
            this.Property(p => p.OzelKod1).HasColumnName("OzelKod1");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
            this.Property(p => p.OzelKod3).HasColumnName("OzelKod3");
            this.Property(p => p.OzelKod4).HasColumnName("OzelKod4");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.RiskLimiti).HasColumnName("RiskLimiti");
            this.Property(p => p.AlisOzelFiyati).HasColumnName("AlisOzelFiyati");
            this.Property(p => p.SatisOzelFiyati).HasColumnName("SatisOzelFiyati");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");






        }
    }
}
