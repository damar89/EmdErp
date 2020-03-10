﻿using NetSatis.Entities.Tables;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NetSatis.Entities.Mapping
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.KullaniciAdi).HasMaxLength(20);
            this.Property(p => p.Adi).HasMaxLength(20);
            this.Property(p => p.SoyAdi).HasMaxLength(20);
            this.Property(p => p.HatirlatmaSorusu).HasMaxLength(50);
            this.Property(p => p.Cevap).HasMaxLength(20);
            this.Property(p => p.Gorevi).HasMaxLength(20);
            this.Property(p => p.Parola).HasMaxLength(32);



            this.ToTable("Kullanicilar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.KullaniciAdi).HasColumnName("KullaniciAdi");
            this.Property(p => p.Adi).HasColumnName("Adi");
            this.Property(p => p.SoyAdi).HasColumnName("SoyAdi");
            this.Property(p => p.DepoId).HasColumnName("DepoId");
            this.Property(p => p.KasaId).HasColumnName("KasaId");
            this.Property(p => p.SaveUser).HasColumnName("SaveUser");
            this.Property(p => p.EditUser).HasColumnName("EditUser");
            this.Property(p => p.Gorevi).HasColumnName("Gorevi");
            this.Property(p => p.HatirlatmaSorusu).HasColumnName("HatirlatmaSorusu");
            this.Property(p => p.Cevap).HasColumnName("Cevap");
            this.Property(p => p.Parola).HasColumnName("Parola");
            this.Property(p => p.KayitTarihi).HasColumnName("KayitTarihi");
            this.Property(p => p.SonGirisTarihi).HasColumnName("SonGirisTarihi");




        }
    }
}
