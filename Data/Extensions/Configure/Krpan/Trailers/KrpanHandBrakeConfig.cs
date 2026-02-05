using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanHandBrakeConfig
    {
        public static void ConfigureMultipleKrpanHandBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanHandBrake>().HasData(
                new KrpanHandBrake
                {
                    Id = 1,
                    Name = "Kézifék",
                    Code = "",
                    Price = "0",
                }
                );
        }
    }
}
