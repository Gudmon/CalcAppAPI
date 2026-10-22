using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanWheelChockConfig
    {
        public static void ConfigureMultipleKrpanWheelChocks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanWheelChock>().HasData(
                new KrpanWheelChock
                {
                    Id = 1,
                    Name = "Kerékékek",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
