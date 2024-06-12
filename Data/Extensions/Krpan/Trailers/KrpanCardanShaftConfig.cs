using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanCardanShaftConfig
    {
        public static void ConfigureMultipleKrpanCardanShafts(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCardanShaft>().HasData(
                new KrpanCardanShaft
                {
                    Id = 1,
                    Name = "Kardántengely Walterscheid WWE 2480-SDF25-910 (egyik oldalon nagy hajlásszögű)",
                    Code = "200004712",
                    Price = "540",
                }
                );
        }
    }
}
