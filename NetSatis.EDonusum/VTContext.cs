using System.Data.Entity;

namespace NetSatis.EDonusum
{
    public class VTContext : DbContext
    {
        public VTContext() : base(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi) ?? "Bağlantı Yok")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VTContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Models.Donusum.HareketTipi> HareketTipi { get; set; }
        public DbSet<Models.Donusum.Master> Master { get; set; }
        public DbSet<Models.Donusum.Details> Detail { get; set; }
    }
}
