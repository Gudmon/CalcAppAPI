using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class KrpanCraneTractorHydraulicsConfig
    {
        public static void ConfigureMultipleKrpanCraneTractorHydraulics(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneTractorHydraulics>().HasData(
                new KrpanCraneTractorHydraulics
                {
                    Id = 1,
                    Name = "Traktor hidraulika",
                    Code = "",
                    Description = "",
                    Price = "0"
                });
        }
    }
}
