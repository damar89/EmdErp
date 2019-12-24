using System.Data.Entity;

namespace NetSatis.EDonusum
{
    public class VTContext : DbContext
    {
        public VTContext() : base(SettingsTool.AyarOku(SettingsTool.Ayarlar.DatabaseAyarlar_BaglantiCumlesi) ?? "Bağlantı Yok")
        {

        }
        public DbSet<Models.Donusum.HareketTipi> HareketTipi { get; set; }
        public DbSet<Models.Donusum.Master> Master { get; set; }
        public DbSet<Models.Donusum.Details> Detail { get; set; }
    }
}
