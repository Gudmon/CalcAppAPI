using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanPropulsionConfig
    {
        public static void ConfigureMultipleKrpanPropulsions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanPropulsion>().HasData(
                new KrpanPropulsion
                {
                    Id = 1,
                    Name = "2WD belső dobos hajtás (2WD BB4)",
                    Code = "",
                    Price = "9681,67",
                },
                new KrpanPropulsion
                {
                    Id = 2,
                    Name = "2WD belső dobos hajtás (2WD BB5)",
                    Code = "",
                    Price = "12111,67",
                },
                new KrpanPropulsion
                {
                    Id = 3,
                    Name = "Dupla belső dobos hajtás (4WD BB4)",
                    Code = "",
                    Price = "19363,34",
                },
                new KrpanPropulsion
                {
                    Id = 4,
                    Name = "Dupla belső dobos hajtás (4WD BB5)",
                    Code = "",
                    Price = "24223,34",
                }
                );
        }
    }
}
