using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanTrailerCouplingDeviceConfig
    {
        public static void ConfigureMultipleKrpanTrailerCouplingDevices(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailerCouplingDevice>().HasData(
                new KrpanTrailerCouplingDevice
                {
                    Id = 1,
                    Name = "Alsó vonórúd",
                    Code = "",
                    Price = "0",
                },
                new KrpanTrailerCouplingDevice
                {
                    Id = 2,
                    Name = "Felső vonórúd",
                    Code = "",
                    Price = "142,50",
                }
                );
        }
    }
}
