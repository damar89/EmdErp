using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class KategoriMap : EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KategoriAdi).HasMaxLength(75);
            this.Property(p => p.Kod).HasMaxLength(75);

            this.ToTable("Stok_Kategoriler");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.KategoriAdi).HasColumnName("KategoriAdi");
            this.Property(p => p.Kod).HasColumnName("Kod");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.GuncellemeTarihi).HasColumnName("GuncellemeTarihi");
              this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");
        }
    }
}
