using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanHydraulicSupportLegSupport
    {
        public static void ConfigureMultipleKrpanHydraulicSupportLegs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanHydraulicSupportLeg>().HasData(
                new KrpanHydraulicSupportLeg
                {
                    Id = 1,
                    Name = "Hidraulikus támasztóláb GP pótkocsihoz (Z darunál kötelező)",
                    Code = "300013635",
                    Price = "530",
                }
                );
        }
    }
}
