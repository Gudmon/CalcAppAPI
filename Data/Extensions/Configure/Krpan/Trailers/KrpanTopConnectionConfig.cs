using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanTopConnectionConfig
    {
        public static void ConfigureMultipleKrpanTopConnections(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTopConnection>().HasData(
                new KrpanTopConnection
                {
                    Id = 1,
                    Name = "Felső csatlakozás",
                    Code = "",
                    Price = "145",
                }
                );
        }
    }
}
