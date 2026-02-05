using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanExtraForwarderStanchionConfig
    {
        public static void ConfigureMultipleKrpanExtraForwarderStanchions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanExtraForwarderStanchion>().HasData(
                new KrpanExtraForwarderStanchion
                {
                    Id = 1,
                    Name = "Extra forwarder rakonca pár",
                    Code = "300019196",
                    Price = "1025",
                }
                );
        }
    }
}
