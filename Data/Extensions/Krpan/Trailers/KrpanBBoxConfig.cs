using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanBBoxConfig
    {
        public static void ConfigureMultipleKrpanBBoxes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanBBox>().HasData(
                new KrpanBBox
                {
                    Id = 1,
                    Name = "Biomasszás vájú",
                    Code = "300014957",
                    Price = "3450",
                },
                new KrpanBBox
                {
                    Id = 2,
                    Name = "Biomasszás vájú",
                    Code = "300010813",
                    Price = "3450",
                },
                new KrpanBBox
                {
                    Id = 3,
                    Name = "Biomasszás vájú",
                    Code = "300011065",
                    Price = "3450",
                },
                new KrpanBBox
                {
                    Id = 4,
                    Name = "Biomasszás vájú",
                    Code = "300006476",
                    Price = "3450",
                }
                );
        }
    }
}
