using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanHydraulicAdjustableChassisConfig
    {
        public static void ConfigureMultipleKrpanHydraulicAdjustableChassis(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanHydraulicAdjustableChassis>().HasData(
                new KrpanHydraulicAdjustableChassis
                {
                    Id = 1,
                    Name = "Hidraulikusan állítható futómű",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
