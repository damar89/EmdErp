using NetSatis.Entities.Mapping;
using NetSatis.Entities.Migrations;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Tools;
using System.Data.Entity;

namespace NetSatis.Entities.Context
{
    public class NetSatisContext : DbContext
    {
        public NetSatisContext() : base(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi) ?? "Bağlantı Yok")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer<NetSatisContext>(new MigrateDatabaseToLatestVersion<NetSatisContext, Configuration>());
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<Barkod> Barkodlar { get; set; }
        public DbSet<HizliSatisGrup> HizliSatisGruplari { get; set; }
        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciRol> KullaniciRolleri { get; set; }
        public DbSet<Kod> Kodlar { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<Masraf> Masraflar { get; set; }
        public DbSet<BarkodEtiket> BarkodEtiketOlustur { get; set; }
        public DbSet<MasrafHareket> MasrafHareketleri { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<AnaGrup> AnaGruplar { get; set; }
        public DbSet<AltGrup> AltGruplar { get; set; }
        public DbSet<Ayar> Ayarlar { get; set; }
        public DbSet<FirmaSabitleri> FirmaSabitleri { get; set; }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<OzelKod> OzelKodlar { get; set; }
        public DbSet<eKullaniciBilgileri> EKullaniciBilgileri { get; set; }
        public DbSet<Api> Api { get; set; }
        public DbSet<RaporTasarimlari> RaporTasarimlari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new IndirimMap());
            modelBuilder.Configurations.Add(new BarkodMap());
            modelBuilder.Configurations.Add(new HizliSatisGrupMap());
            modelBuilder.Configurations.Add(new HizliSatisMap());
            modelBuilder.Configurations.Add(new PersonelHareketMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new KodMap());
            modelBuilder.Configurations.Add(new MasrafMap());
            modelBuilder.Configurations.Add(new MasrafHareketMap());
            modelBuilder.Configurations.Add(new BarkodEtiketMap());
            modelBuilder.Configurations.Add(new AyarMap());
            modelBuilder.Configurations.Add(new ApiMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new AnaGrupMap());
            modelBuilder.Configurations.Add(new AltGrupMap());
            modelBuilder.Configurations.Add(new FirmaSabitMap());
            modelBuilder.Configurations.Add(new ProjeMap());
            modelBuilder.Configurations.Add(new OzelKodMap());
            modelBuilder.Configurations.Add(new eKullaniciBilgileriMap());
            modelBuilder.Configurations.Add(new RaporTasarimlariMap());
            

        }

    }
}
