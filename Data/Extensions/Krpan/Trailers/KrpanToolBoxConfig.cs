using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanToolBoxConfig
    {
        public static void ConfigureMultipleKrpanToolBoxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanToolBox>().HasData(
                new KrpanToolBox
                {
                    Id = 1,
                    Name = "Szerszámos láda",
                    Code = "300015651",
                    Price = "0",
                },
                new KrpanToolBox
                {
                    Id = 2,
                    Name = "Szerszámos láda",
                    Code = "300015651",
                    Price = "145",
                }
                );
        }
    }
}
