using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class KrpanCraneControlLevelProtectionConfig
    {
        public static void ConfigureMultipleKrpanCraneControlLeverProtections(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneControlLeverProtection>().HasData(
                new KrpanCraneControlLeverProtection
                {
                    Id = 1,
                    Name = "Vezérlőkar védelem",
                    Code = "",
                    Description = "",
                    Price = "0"
                });
        }
    }
}
