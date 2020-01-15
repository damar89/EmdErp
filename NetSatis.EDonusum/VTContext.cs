using NetSatis.EDonusum.Migrations;
using System.Data.Entity;

namespace NetSatis.EDonusum
{
    public class VTContext : DbContext
    {
        public VTContext() : base(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi) ?? "Bağlantı Yok")
        {
            Database.SetInitializer<VTContext>(new MigrateDatabaseToLatestVersion<VTContext, Configuration>());
        }
        public DbSet<Models.Donusum.HareketTipi> HareketTipi { get; set; }
        public DbSet<Models.Donusum.Master> Master { get; set; }
        public DbSet<Models.Donusum.Details> Detail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Database.SetInitializer<VTContext>(DbContext);
            base.OnModelCreating(modelBuilder);
        }

    }
}
