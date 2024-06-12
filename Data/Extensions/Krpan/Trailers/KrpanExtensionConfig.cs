using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanExtensionConfig
    {
        public static void ConfigureMultipleKrpanExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanExtension>().HasData(
                new KrpanExtension
                {
                    Id = 1,
                    Name = "Hosszabbítás (GP15D pótkocsihoz 1,8 m)",
                    Code = "300015365",
                    Price = "675",
                }
                );
        }
    }
}
