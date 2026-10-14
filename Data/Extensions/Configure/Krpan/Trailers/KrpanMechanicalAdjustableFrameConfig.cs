using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanMechanicalAdjustableFrameConfig
    {
        public static void ConfigureMultipleKrpanMechanicalAdjustableFrames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanMechanicalAdjustableFrame>().HasData(
                new KrpanMechanicalAdjustableFrame
                {
                    Id = 1,
                    Name = "Mechanikusan állítható keret",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
