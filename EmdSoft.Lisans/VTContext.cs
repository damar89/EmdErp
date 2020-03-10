using System.Data.Entity;

namespace EmdSoft.Lisans
{
    public class VTContext:DbContext
    {
        public VTContext():base(@"Server=185.250.240.229;Database=emdsoftlisans;User=emdsoftlisans;Password=Emd.Soft*;")
        {

        }
        public DbSet<Models.LicKeyGenerator> LicKeyGenerators { get; set; }
        //
    }
}