using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanDrawbarConfig
    {
        public static void ConfigureMultipleKrpanDrawbars(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanDrawbar>().HasData(
                new KrpanDrawbar
                {
                    Id = 1,
                    Name = "Rögzített vonószem Ø 50",
                    Code = "300012585",
                    Price = "150",
                },
                new KrpanDrawbar
                {
                    Id = 2,
                    Name = "Forgó vonószem Ø 50",
                    Code = "300012587",
                    Price = "325",
                },
                new KrpanDrawbar
                {
                    Id = 3,
                    Name = "Forgó vonószem Ø 50",
                    Code = "300012587",
                    Price = "400",
                }
                );
        }
    }
}
