using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanDrawheadConfig
    {
        public static void ConfigureMultipleKrpanDrawheads(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawhead>().HasData(
                new KrpanDrawhead
                {
                    Id = 1,
                    Name = "Vonófej K80",
                    Code = "300012588",
                    Price = "340",
                },
                new KrpanDrawhead
                {
                    Id = 2,
                    Name = "Vonófej K80",
                    Code = "300012588",
                    Price = "415",
                }
                );
        }
    }
}
