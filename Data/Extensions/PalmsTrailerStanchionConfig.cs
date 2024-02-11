using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions
{
    public static class PalmsTrailerStanchionConfig
    {
        public static void ConfigureMultiplePalmsStanchions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stanchion>().HasData(
               new Stanchion
               {
                   Id = 1,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "5285",
               },
               new Stanchion
               {
                   Id = 2,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "5800",
               },
                new Stanchion
                {
                    Id = 3,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "6930",
                },
                new Stanchion
                {
                    Id = 4,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "7390",
                },
                new Stanchion
                {
                    Id = 5,
                    Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                    Code = "A4Ex",
                    Price = "7700",
                },
                new Stanchion
                {
                    Id = 6,
                    Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                    Code = "A5Ex",
                    Price = "8160",
                },
                new Stanchion
                {
                    Id = 7,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "7340",
                },
                new Stanchion
                {
                    Id = 8,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "7710",
                },
                new Stanchion
                {
                    Id = 9,
                    Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                    Code = "A4Ex",
                    Price = "8330",
                },
                new Stanchion
                {
                    Id = 10,
                    Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                    Code = "A5Ex",
                    Price = "8695",
                }
               );
        }
    }
}
