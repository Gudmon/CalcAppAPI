using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanPlatoConfig
    {
        public static void ConfigureMultipleKrpanPlatos(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanPlato>().HasData(
                new KrpanPlato
                {
                    Id = 1,
                    Name = "Plató (GP 15 D pótkocsihoz)",
                    Code = "300015209",
                    Price = "6185",
                }
                );
        }
    }
}
