using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class FisMap : EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(120);
            this.Property(p => p.Seri).HasMaxLength(120);
            this.Property(p => p.Sira).HasMaxLength(120);
            this.Property(p => p.Tipi).HasMaxLength(120);
            this.Property(p => p.IrsaliyeFisKodu).HasMaxLength(120);
            this.Property(p => p.SiparisFisKodu).HasMaxLength(120);
            this.Property(p => p.TeklifFisKodu).HasMaxLength(120);
            this.Property(p => p.FaturaFisKodu).HasMaxLength(120);
            this.Property(p => p.FisTuru).HasMaxLength(300);
            this.Property(p => p.CariIrsaliye).HasMaxLength(300);
            this.Property(p => p.StokIrsaliye).HasMaxLength(300);
            this.Property(p => p.CariAdi).HasMaxLength(950);
            this.Property(p => p.EMail).HasMaxLength(750);
            this.Property(p => p.FaturaUnvani).HasMaxLength(950);
            this.Property(p => p.CepTelefonu).HasMaxLength(200);
            this.Property(p => p.Telefon).HasMaxLength(200);
            this.Property(p => p.Il).HasMaxLength(200);
            this.Property(p => p.Ilce).HasMaxLength(200);
            this.Property(p => p.Semt).HasMaxLength(200);
            this.Property(p => p.Adres).HasMaxLength(1000);
            this.Property(p => p.VergiDairesi).HasMaxLength(300);
            this.Property(p => p.VergiNo).HasMaxLength(150);
            this.Property(p => p.BelgeNo).HasMaxLength(200);
            this.Property(p => p.IskontoOrani1).HasPrecision(5, 2);
            this.Property(p => p.IskontoTutari1).HasPrecision(12, 2);
            this.Property(p => p.IskontoOrani2).HasPrecision(5, 2);
            this.Property(p => p.IskontoTutari2).HasPrecision(12, 2);
            this.Property(p => p.IskontoOrani3).HasPrecision(5, 2);
            this.Property(p => p.IskontoTutari3).HasPrecision(12, 2);
            this.Property(p => p.DipIskOran).HasPrecision(5, 2);
            this.Property(p => p.DipIskTutari).HasPrecision(12, 2);
            this.Property(p => p.DipIskNetTutari).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(2000);
            this.Property(p => p.AraToplam_).HasPrecision(12, 2);
            this.Property(p => p.KdvToplam_).HasPrecision(12, 2);
            this.Property(p => p.ProjeAdi).HasMaxLength(750);
            this.Property(p => p.OzelKod).HasMaxLength(750);
            this.Property(p => p.OzelKod2).HasMaxLength(750);
            this.ToTable("Fisler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.Seri).HasColumnName("Seri");
            this.Property(p => p.Sira).HasColumnName("Sira");
            this.Property(p => p.Tipi).HasColumnName("Tipi");
            this.Property(p => p.IrsaliyeFisKodu).HasColumnName("IrsaliyeFisKodu");
            this.Property(p => p.TeklifFisKodu).HasColumnName("TeklifFisKodu");
            this.Property(p => p.SiparisFisKodu).HasColumnName("SiparisFisKodu");
            this.Property(p => p.FaturaFisKodu).HasColumnName("FaturaFisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariIrsaliye).HasColumnName("CariIrsaliye");
            this.Property(p => p.StokIrsaliye).HasColumnName("StokIrsaliye");
            this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Il).HasColumnName("Il");
            this.Property(p => p.Ilce).HasColumnName("Ilce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adres).HasColumnName("Adres");
            this.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            this.Property(p => p.VergiNo).HasColumnName("VergiNo");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.VadeTarihi).HasColumnName("VadeTarihi");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
            this.Property(p => p.PlasiyerId).HasColumnName("PlasiyerId");
            this.Property(p => p.IskontoOrani1).HasColumnName("IskontoOrani1");
            this.Property(p => p.IskontoTutari1).HasColumnName("IskontoTutari1");
            this.Property(p => p.IskontoOrani2).HasColumnName("IskontoOrani2");
            this.Property(p => p.IskontoTutari2).HasColumnName("IskontoTutari2");
            this.Property(p => p.IskontoOrani3).HasColumnName("IskontoOrani3");
            this.Property(p => p.IskontoTutari3).HasColumnName("IskontoTutari3");
            this.Property(p => p.DipIskOran).HasColumnName("DipIskOran");
            this.Property(p => p.DipIskTutari).HasColumnName("DipIskTutari");
            this.Property(p => p.DipIskNetTutari).HasColumnName("DipIskNetTutari");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.AraToplam_).HasColumnName("AraToplam");
            this.Property(p => p.KdvToplam_).HasColumnName("KdvToplam");
            #region Güncellenen KDVDahil alanı
            this.Property(p => p.KDVDahil).HasColumnName("KDVDahil");
            #endregion
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
            this.Property(p => p.ProjeAdi).HasColumnName("ProjeAdi");
            this.Property(p => p.OzelKod).HasColumnName("OzelKod");
            this.Property(p => p.OzelKod2).HasColumnName("OzelKod2");
              this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");
            this.HasOptional(c => c.Cari).WithMany(c => c.Fis).HasForeignKey(c => c.CariId);
            this.HasOptional(c => c.Personel).WithMany(c => c.Fis).HasForeignKey(c => c.PlasiyerId);


        }
    }
}
