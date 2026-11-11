using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class KrpanGrappleConfig
    {
        public static void ConfigureMultipleKrpanGrapples(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanGrapple>().HasData(
                new KrpanGrapple
                {
                    Id = 1,
                    Name = "GR 120 karimával",
                    Code = "",
                    Description = "",
                    Price = "0"
                },
                new KrpanGrapple
                {
                    Id = 2,
                    Name = "GR 130",
                    Code = "",
                    Description = "",
                    Price = "215,83"
                },
                new KrpanGrapple
                {
                    Id = 3,
                    Name = "GR 150",
                    Code = "",
                    Description = "",
                    Price = "403,33"
                },
                new KrpanGrapple
                {
                    Id = 4,
                    Name = "GR 23",
                    Code = "",
                    Description = "",
                    Price = "980,00"
                },
                new KrpanGrapple
                {
                    Id = 5,
                    Name = "GR 27",
                    Code = "",
                    Description = "",
                    Price = "1.275,83"
                },
                new KrpanGrapple
                {
                    Id = 6,
                    Name = "GR 27 BIO",
                    Code = "",
                    Description = "",
                    Price = "2.003,33"
                },
                new KrpanGrapple
                {
                    Id = 7,
                    Name = "GR 130",
                    Code = "",
                    Description = "",
                    Price = "0"
                });
        }
    }
}
