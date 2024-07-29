using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanChockConfig
    {
        public static void ConfigureMultipleKrpanChocks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanChock>().HasData(
                new KrpanChock
                {
                    Id = 1,
                    Name = "Ékek",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
