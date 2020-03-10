using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class BarkodMap : EntityTypeConfiguration<Barkod>
    {
        public BarkodMap()
        {
            this.HasKey(p => p.Id);
            //this.Property(p => p.StokId).IsOptional();
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Barkodu).HasMaxLength(20);
           

            this.ToTable("Barkodlar");

            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Barkodu).HasColumnName("Barkodu");
            this.Property(p => p.StokId).HasColumnName("StokId");

            this.HasOptional(t => t.Stok).WithMany(t => t.Barkod).HasForeignKey(d => d.StokId);
        }

    }
}
