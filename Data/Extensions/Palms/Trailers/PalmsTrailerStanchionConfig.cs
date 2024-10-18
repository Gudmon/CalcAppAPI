using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerStanchionConfig
    {
        public static void ConfigureMultiplePalmsStanchions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stanchion>().HasData(
                //PALMS 6S
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

               //PALMS 8SX
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
                    Price = "7450",
                },
                new Stanchion
                {
                    Id = 5,
                    Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                    Code = "A4Ex",
                    Price = "7785",
                },
                new Stanchion
                {
                    Id = 6,
                    Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással ",
                    Code = "A5Ex",
                    Price = "8305",
                },

                //PALMS 8D
                new Stanchion
                {
                    Id = 7,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "6930",
                },
                new Stanchion
                {
                    Id = 8,
                    Name = "Pótkocsi 3 pár forwarder rakoncával",
                    Code = "A3F",
                    Price = "6930",
                },
                new Stanchion
                {
                    Id = 9,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "7450",
                },
                new Stanchion
                {
                    Id = 10,
                    Name = "Pótkocsi 4 pár forwarder rakoncával",
                    Code = "A4F",
                    Price = "7450",
                },
                new Stanchion
                {
                    Id = 11,
                    Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                    Code = "A4Ex",
                    Price = "7785",
                },
                new Stanchion
                {
                    Id = 12,
                    Name = "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással",
                    Code = "A4FEx",
                    Price = "7785",
                },
                new Stanchion
                {
                    Id = 13,
                    Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                    Code = "A5Ex",
                    Price = "8305",
                },
                new Stanchion
                {
                    Id = 14,
                    Name = "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással",
                    Code = "A5FEx",
                    Price = "8305",
                },

                //PALMS 9SC
                new Stanchion
                {
                    Id = 15,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "7920",
                },
                new Stanchion
                {
                    Id = 16,
                    Name = "Pótkocsi 4 pár rakoncával",
                    Code = "A4",
                    Price = "8465",
                },
                new Stanchion
                {
                    Id = 17,
                    Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                    Code = "A4Ex",
                    Price = "8920",
                },
                new Stanchion
                {
                    Id = 18,
                    Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                    Code = "A5Ex",
                    Price = "9465",
                },

                //PALMS 10D
                new Stanchion
                {
                    Id = 19,
                    Name = "Pótkocsi 3 pár rakoncával",
                    Code = "A3",
                    Price = "8400",
                },
               new Stanchion
               {
                   Id = 20,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "8795",
               },
               new Stanchion
               {
                   Id = 21,
                   Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                   Code = "A4Ex",
                   Price = "9415",
               },
               new Stanchion
               {
                   Id = 22,
                   Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                   Code = "A5Ex",
                   Price = "9810",
               },

               //PALMS 12D
               new Stanchion
               {
                   Id = 23,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "10500",
               },
               new Stanchion
               {
                   Id = 24,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "10895",
               },
               new Stanchion
               {
                   Id = 25,
                   Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                   Code = "A4Ex",
                   Price = "11515",
               },
               new Stanchion
               {
                   Id = 26,
                   Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                   Code = "A5Ex",
                   Price = "11910",
               },


               //PALMS 14D
               new Stanchion
               {
                   Id = 27,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "11970",
               },
               new Stanchion
               {
                   Id = 28,
                   Name = "Pótkocsi 4 pár rakoncával",
                   Code = "A4",
                   Price = "12470",
               },
               new Stanchion
               {
                   Id = 29,
                   Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                   Code = "A4Ex",
                   Price = "13240",
               },
               new Stanchion
               {
                   Id = 30,
                   Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                   Code = "A5Ex",
                   Price = "13740",
               },


               //PALMS 10U
               new Stanchion
               {
                   Id = 31,
                   Name = "Pótkocsi 3 pár rakoncával",
                   Code = "A3",
                   Price = "10495",
               },
               new Stanchion
               {
                   Id = 32,
                   Name = "Pótkocsi 3 pár forwarder rakoncával",
                   Code = "A3F",
                   Price = "10495",
               },
              new Stanchion
              {
                  Id = 33,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "11125",
              },
              new Stanchion
              {
                  Id = 34,
                  Name = "Pótkocsi 4 pár forwarder rakoncával",
                  Code = "A4F",
                  Price = "11125",
              },
              new Stanchion
              {
                  Id = 35,
                  Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                  Code = "A4Ex",
                  Price = "11850",
              },
              new Stanchion
              {
                  Id = 36,
                  Name = "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A4FEx",
                  Price = "11850",
              },
              new Stanchion
              {
                  Id = 37,
                  Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                  Code = "A5Ex",
                  Price = "12480",
              },
              new Stanchion
              {
                  Id = 38,
                  Name = "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A5FEx",
                  Price = "12480",
              },

              //PALMS 12U
              new Stanchion
              {
                  Id = 39,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "11760",
              },
               new Stanchion
               {
                   Id = 40,
                   Name = "Pótkocsi 3 pár forwarder rakoncával",
                   Code = "A3F",
                   Price = "11760",
               },
              new Stanchion
              {
                  Id = 41,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "12430",
              },
              new Stanchion
              {
                  Id = 42,
                  Name = "Pótkocsi 4 pár forwarder rakoncával",
                  Code = "A4F",
                  Price = "12430",
              },
              new Stanchion
              {
                  Id = 43,
                  Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                  Code = "A4Ex",
                  Price = "13155",
              },
              new Stanchion
              {
                  Id = 44,
                  Name = "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A4FEx",
                  Price = "13155",
              },
              new Stanchion
              {
                  Id = 45,
                  Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                  Code = "A5Ex",
                  Price = "13820",
              },
              new Stanchion
              {
                  Id = 46,
                  Name = "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A5FEx",
                  Price = "13820",
              },

              //PALMS 12UAWD
              new Stanchion
              {
                  Id = 47,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "37160",
              },
               new Stanchion
               {
                   Id = 48,
                   Name = "Pótkocsi 3 pár forwarder rakoncával",
                   Code = "A3F",
                   Price = "37160",
               },
              new Stanchion
              {
                  Id = 49,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "37830",
              },
              new Stanchion
              {
                  Id = 50,
                  Name = "Pótkocsi 4 pár forwarder rakoncával",
                  Code = "A4F",
                  Price = "37830",
              },
              new Stanchion
              {
                  Id = 51,
                  Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                  Code = "A4Ex",
                  Price = "38550",
              },
              new Stanchion
              {
                  Id = 52,
                  Name = "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A4FEx",
                  Price = "38550",
              },
              new Stanchion
              {
                  Id = 53,
                  Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                  Code = "A5Ex",
                  Price = "39220",
              },
              new Stanchion
              {
                  Id = 54,
                  Name = "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A5FEx",
                  Price = "39220",
              },

              //PALMS 15U
              new Stanchion
              {
                  Id = 55,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "14070",
              },
               new Stanchion
               {
                   Id = 56,
                   Name = "Pótkocsi 3 pár forwarder rakoncával",
                   Code = "A3F",
                   Price = "14070",
               },
              new Stanchion
              {
                  Id = 57,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "14990",
              },
              new Stanchion
              {
                  Id = 58,
                  Name = "Pótkocsi 4 pár forwarder rakoncával",
                  Code = "A4F",
                  Price = "14990",
              },
              new Stanchion
              {
                  Id = 59,
                  Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                  Code = "A4Ex",
                  Price = "15715",
              },
              new Stanchion
              {
                  Id = 60,
                  Name = "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A4FEx",
                  Price = "15715",
              },
              new Stanchion
              {
                  Id = 61,
                  Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                  Code = "A5Ex",
                  Price = "16635",
              },
              new Stanchion
              {
                  Id = 62,
                  Name = "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A5FEx",
                  Price = "16635",
              },

              //PALMS 15UAWD
              new Stanchion
              {
                  Id = 63,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "39470",
              },
               new Stanchion
               {
                   Id = 64,
                   Name = "Pótkocsi 3 pár forwarder rakoncával",
                   Code = "A3F",
                   Price = "39470",
               },
              new Stanchion
              {
                  Id = 65,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "40390",
              },
              new Stanchion
              {
                  Id = 66,
                  Name = "Pótkocsi 4 pár forwarder rakoncával",
                  Code = "A4F",
                  Price = "40390",
              },
              new Stanchion
              {
                  Id = 67,
                  Name = "Pótkocsi 4 pár rakoncával és raktérhosszabbítással",
                  Code = "A4Ex",
                  Price = "41115",
              },
              new Stanchion
              {
                  Id = 68,
                  Name = "Pótkocsi 4 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A4FEx",
                  Price = "41115",
              },
              new Stanchion
              {
                  Id = 69,
                  Name = "Pótkocsi 5 pár rakoncával és raktérhosszabbítással",
                  Code = "A5Ex",
                  Price = "42030",
              },
              new Stanchion
              {
                  Id = 70,
                  Name = "Pótkocsi 5 pár forwarder rakoncával és raktérhosszabbítással",
                  Code = "A5FEx",
                  Price = "42030",
              },

              //PALMS MWD3.2
              new Stanchion
              {
                  Id = 71,
                  Name = "Pótkocsi 4 pár forwarder típusú rakoncával",
                  Code = "A4F",
                  Price = "52325",
              },
              new Stanchion
              {
                  Id = 72,
                  Name = "Pótkocsi 5 pár forwarder típusú rakoncával",
                  Code = "A5F",
                  Price = "53455",
              },
              new Stanchion
              {
                  Id = 73,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FHEx",
                  Price = "55025",
              },
              new Stanchion
              {
                  Id = 74,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FHEx",
                  Price = "56155",
              },

              //PALMS HMWD3.2
              new Stanchion
              {
                  Id = 75,
                  Name = "Pótkocsi 4 pár forwarder típusú rakoncával",
                  Code = "A4F",
                  Price = "56815",
              },
              new Stanchion
              {
                  Id = 76,
                  Name = "Pótkocsi 5 pár forwarder típusú rakoncával",
                  Code = "A5F",
                  Price = "57945",
              },
              new Stanchion
              {
                  Id = 77,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FHEx",
                  Price = "59515",
              },
              new Stanchion
              {
                  Id = 78,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FHEx",
                  Price = "60645",
              },

              //PALMS 2D
              new Stanchion
              {
                  Id = 79,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "2490",
              },
              new Stanchion
              {
                  Id = 80,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "2595",
              },
              new Stanchion
              {
                  Id = 81,
                  Name = "Pótkocsi 5 pár rakoncával",
                  Code = "A5",
                  Price = "2700",
              }
              );
        }
    }
}
