using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Mapping
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(120);
            this.Property(p => p.FisSeri).HasMaxLength(120);
            this.Property(p => p.Sira).HasMaxLength(120);
            this.Property(p => p.Tipi).HasMaxLength(120);
            this.Property(p => p.Hareket).HasMaxLength(100);
            this.Property(p => p.FisTuru).HasMaxLength(300);
            this.Property(p => p.StokIrsaliye).HasMaxLength(120);
            this.Property(p => p.Miktar).HasPrecision(12, 2);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 2);
            this.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.IndirimOrani2).HasPrecision(5, 2);
            this.Property(p => p.IndirimOrani3).HasPrecision(5, 2);
            this.Property(p => p.SeriNo).HasMaxLength(2000);
            this.Property(p => p.Aciklama).HasMaxLength(2000);
            this.Property(p => p.KdvHaric_).HasPrecision(12, 2);
            this.Property(p => p.KdvToplam).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.MaliyetFiyati).HasPrecision(12, 2);
            this.Property(p => p.IndirimTutar).HasPrecision(12, 2);

            this.ToTable("StokHareketleri");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisSeri).HasColumnName("FisSeri");
            this.Property(p => p.Sira).HasColumnName("Sira");
            this.Property(p => p.Tipi).HasColumnName("Tipi");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.StokIrsaliye).HasColumnName("StokIrsaliye");
            this.Property(p => p.StokId).HasColumnName("StokId");
            //this.Property(p => p.CariId).HasColumnName("CariId");
            this.Property(p => p.Miktar).HasColumnName("Miktar");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");
            this.Property(p => p.Borsa).HasColumnName("Borsa");
            this.Property(p => p.Mera).HasColumnName("Mera");
            this.Property(p => p.Zirai).HasColumnName("Zirai");
            this.Property(p => p.Bagkur).HasColumnName("Bagkur");

            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
            this.Property(p => p.IndirimOrani2).HasColumnName("IndirimOrani2");
            this.Property(p => p.IndirimOrani3).HasColumnName("IndirimOrani3");

            this.Property(p => p.DepoId).HasColumnName("DepoId");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");

            this.Property(p => p.KdvHaric_).HasColumnName("KdvHaric");
            this.Property(p => p.KdvToplam).HasColumnName("KdvToplam");
            this.Property(p => p.MaliyetFiyati).HasColumnName("MaliyetFiyati");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.DipIskontoPayi).HasColumnName("DipIskontoPayi");
            this.Property(p => p.IndirimTutar).HasColumnName("IndirimTutar");
            this.Property(p => p.IndirimTutar2).HasColumnName("IndirimTutar2");
            this.Property(p => p.IndirimTutar3).HasColumnName("IndirimTutar3");

            this.HasRequired(c => c.Stok).WithMany(c => c.StokHareket).HasForeignKey(c => c.StokId);
            this.HasRequired(c => c.Depo).WithMany(c => c.StokHareket).HasForeignKey(c => c.DepoId);
            //this.HasRequired(c => c.Cari).WithMany(c => c.StokHareket).HasForeignKey(c => c.CariId);

        }
    }
}
