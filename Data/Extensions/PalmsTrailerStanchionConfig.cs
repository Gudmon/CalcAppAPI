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
                },

                new Stanchion
                {
                    Id = 11,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "20215",
                },
                new Stanchion
                {
                    Id = 12,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "20580",
                },
                new Stanchion
                {
                    Id = 13,
                    Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                    Code = "A4Ex",
                    Price = "21200",
                },
                new Stanchion
                {
                    Id = 14,
                    Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                    Code = "A5Ex",
                    Price = "21570",
                },

                new Stanchion
                {
                    Id = 15,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "8080",
                },
                new Stanchion
                {
                    Id = 16,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "8540",
                },
                new Stanchion
                {
                    Id = 17,
                    Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                    Code = "A4Ex",
                    Price = "8755",
                },
                new Stanchion
                {
                    Id = 18,
                    Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                    Code = "A5Ex",
                    Price = "9210",
                },

                new Stanchion
                {
                     Id = 19,
                     Name = "Pótkocsi 3 pár rakoncával",
                     Code = "A3",
                     Price = "8830",
                },
               new Stanchion
               {
                    Id = 20,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "9240",
               },
               new Stanchion
               {
                    Id = 21,
                    Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                    Code = "A4Ex",
                    Price = "9860",
               },
               new Stanchion
               {
                    Id = 22,
                    Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                    Code = "A5Ex",
                    Price = "10270",
               },


               new Stanchion
               {
                   Id = 23,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "21315",
               },
               new Stanchion
               {
                   Id = 24,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "21725",
               },
               new Stanchion
               {
                   Id = 25,
                   Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                   Code = "A4Ex",
                   Price = "22345",
               },
               new Stanchion
               {
                   Id = 26,
                   Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                   Code = "A5Ex",
                   Price = "22755",
               },

               new Stanchion
               {
                   Id = 27,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "10880",
               },
               new Stanchion
               {
                   Id = 28,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "11290",
               },
               new Stanchion
               {
                   Id = 29,
                   Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                   Code = "A4Ex",
                   Price = "11910",
               },
               new Stanchion
               {
                   Id = 30,
                   Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                   Code = "A5Ex",
                   Price = "12320",
               },

               new Stanchion
               {
                    Id = 31,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "22955",
               },
              new Stanchion
              {
                   Id = 32,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "23365",
              },
              new Stanchion
              {
                   Id = 33,
                   Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                   Code = "A4Ex",
                   Price = "23985",
              },
              new Stanchion
              {
                   Id = 34,
                   Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                   Code = "A5Ex",
                   Price = "24395",
              },

              new Stanchion
              {
                  Id = 35,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "12665",
              },
              new Stanchion
              {
                  Id = 36,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "13160",
              },
              new Stanchion
              {
                  Id = 37,
                  Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "13810",
              },
              new Stanchion
              {
                  Id = 38,
                  Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "14305",
              },

              new Stanchion
              {
                  Id = 39,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "24740",
              },
              new Stanchion
              {
                  Id = 40,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "25235",
              },
              new Stanchion
              {
                  Id = 41,
                  Name = "Pótkocsi raktérhosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "25885",
              },
              new Stanchion
              {
                  Id = 42,
                  Name = "Pótkocsi raktérhosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "26380",
              }
              );
        }
    }
}
