using CalcAppAPI.Models;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
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
              },
              new Stanchion
              {
                  Id = 43,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "10495",
              },
              new Stanchion
              {
                  Id = 44,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "10495",
              },
              new Stanchion
              {
                  Id = 45,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "11125",
              },
              new Stanchion
              {
                  Id = 46,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "11125",
              },
              new Stanchion
              {
                  Id = 47,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "11850",
              },
              new Stanchion
              {
                  Id = 48,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "11850",
              },
              new Stanchion
              {
                  Id = 49,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "12480",
              },
              new Stanchion
              {
                  Id = 50,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "12480",
              },
              new Stanchion
              {
                  Id = 51,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "23260",
              },
              new Stanchion
              {
                  Id = 52,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "23260",
              },
              new Stanchion
              {
                  Id = 53,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "23890",
              },
              new Stanchion
              {
                  Id = 54,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "23890",
              },
              new Stanchion
              {
                  Id = 55,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "24615",
              },
              new Stanchion
              {
                  Id = 56,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "24615",
              },
              new Stanchion
              {
                  Id = 57,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "25245",
              },
              new Stanchion
              {
                  Id = 58,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "25245",
              },
              new Stanchion
              {
                  Id = 59,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "12580",
              },
              new Stanchion
              {
                  Id = 60,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "12580",
              },
              new Stanchion
              {
                  Id = 61,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "13295",
              },
              new Stanchion
              {
                  Id = 62,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "13295",
              },
              new Stanchion
              {
                  Id = 63,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "14020",
              },
              new Stanchion
              {
                  Id = 64,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "14020",
              },
              new Stanchion
              {
                  Id = 65,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "14735",
              },
              new Stanchion
              {
                  Id = 66,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "14735",
              },
              new Stanchion
              {
                  Id = 67,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "24665",
              },
              new Stanchion
              {
                  Id = 68,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "24665",
              },
              new Stanchion
              {
                  Id = 69,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "25380",
              },
              new Stanchion
              {
                  Id = 70,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "25380",
              },
              new Stanchion
              {
                  Id = 71,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "26105",
              },
              new Stanchion
              {
                  Id = 72,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "26105",
              },
              new Stanchion
              {
                  Id = 73,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "26820",
              },
              new Stanchion
              {
                  Id = 74,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "26820",
              },
              new Stanchion
              {
                  Id = 75,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "37980",
              },
              new Stanchion
              {
                  Id = 76,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "37980",
              },
              new Stanchion
              {
                  Id = 77,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "38695",
              },
              new Stanchion
              {
                  Id = 78,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "38695",
              },
              new Stanchion
              {
                  Id = 79,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "39420",
              },
              new Stanchion
              {
                  Id = 80,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "39420",
              },
              new Stanchion
              {
                  Id = 81,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "40135",
              },
              new Stanchion
              {
                  Id = 82,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "40135",
              },
              new Stanchion
              {
                  Id = 83,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "14595",
              },
              new Stanchion
              {
                  Id = 84,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "14595",
              },
              new Stanchion
              {
                  Id = 85,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "15515",
              },
              new Stanchion
              {
                  Id = 86,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "15515",
              },
              new Stanchion
              {
                  Id = 87,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "16240",
              },
              new Stanchion
              {
                  Id = 88,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "16240",
              },
              new Stanchion
              {
                  Id = 89,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "17160",
              },
              new Stanchion
              {
                  Id = 90,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "17160",
              },
              new Stanchion
              {
                  Id = 91,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "26680",
              },
              new Stanchion
              {
                  Id = 92,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "26680",
              },
              new Stanchion
              {
                  Id = 93,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "27600",
              },
              new Stanchion
              {
                  Id = 94,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "27600",
              },
              new Stanchion
              {
                  Id = 95,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "28325",
              },
              new Stanchion
              {
                  Id = 96,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "28325",
              },
              new Stanchion
              {
                  Id = 97,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "29245",
              },
              new Stanchion
              {
                  Id = 98,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "29245",
              },
              new Stanchion
              {
                  Id = 99,
                  Name = "Pótkocsi 3 pár rakoncával",
                  Code = "A3",
                  Price = "39995",
              },
              new Stanchion
              {
                  Id = 100,
                  Name = "Pótkocsi 3 pár forwader típusú rakoncával",
                  Code = "A3F",
                  Price = "39995",
              },
              new Stanchion
              {
                  Id = 101,
                  Name = "Pótkocsi 4 pár rakoncával",
                  Code = "A4",
                  Price = "40915",
              },
              new Stanchion
              {
                  Id = 102,
                  Name = "Pótkocsi 4 pár forwader típusú rakoncával",
                  Code = "A4F",
                  Price = "40915",
              },
              new Stanchion
              {
                  Id = 103,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár rakoncával",
                  Code = "A4Ex",
                  Price = "41640",
              },
              new Stanchion
              {
                  Id = 104,
                  Name = "Pótkocsi raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FEx",
                  Price = "41640",
              },
              new Stanchion
              {
                  Id = 105,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár rakoncával",
                  Code = "A5Ex",
                  Price = "42560",
              },
              new Stanchion
              {
                  Id = 106,
                  Name = "Pótkocsi raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FEx",
                  Price = "42560",
              },

              new Stanchion
              {
                  Id = 107,
                  Name = "Pótkocsi 4 pár forwarder típusú rakoncával",
                  Code = "A4F",
                  Price = "52325",
              },
              new Stanchion
              {
                  Id = 108,
                  Name = "Pótkocsi 5 pár forwarder típusú rakoncával",
                  Code = "A5F",
                  Price = "53455",
              },
              new Stanchion
              {
                  Id = 109,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FHEx",
                  Price = "55025",
              },
              new Stanchion
              {
                  Id = 110,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FHEx",
                  Price = "56155",
              },

              new Stanchion
              {
                  Id = 111,
                  Name = "Pótkocsi 4 pár forwarder típusú rakoncával",
                  Code = "A4F",
                  Price = "52985",
              },
              new Stanchion
              {
                  Id = 112,
                  Name = "Pótkocsi 5 pár forwarder típusú rakoncával",
                  Code = "A5F",
                  Price = "54115",
              },
              new Stanchion
              {
                  Id = 113,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FHEx",
                  Price = "55685",
              },
              new Stanchion
              {
                  Id = 114,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FHEx",
                  Price = "56815",
              },

              new Stanchion
              {
                  Id = 115,
                  Name = "Pótkocsi 4 pár forwarder típusú rakoncával",
                  Code = "A4F",
                  Price = "56815",
              },
              new Stanchion
              {
                  Id = 116,
                  Name = "Pótkocsi 5 pár forwarder típusú rakoncával",
                  Code = "A5F",
                  Price = "57945",
              },
              new Stanchion
              {
                  Id = 117,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FHEx",
                  Price = "59515",
              },
              new Stanchion
              {
                  Id = 118,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FHEx",
                  Price = "60645",
              },

              new Stanchion
              {
                  Id = 119,
                  Name = "Pótkocsi 4 pár forwarder típusú rakoncával",
                  Code = "A4F",
                  Price = "57475",
              },
              new Stanchion
              {
                  Id = 120,
                  Name = "Pótkocsi 5 pár forwarder típusú rakoncával",
                  Code = "A5F",
                  Price = "58605",
              },
              new Stanchion
              {
                  Id = 121,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 4 pár forwarder típusú rakoncával",
                  Code = "A4FHEx",
                  Price = "60175",
              },
              new Stanchion
              {
                  Id = 122,
                  Name = "Pótkocsi hidraulikus raktér hosszabbítással és 5 pár forwarder típusú rakoncával",
                  Code = "A5FHEx",
                  Price = "61305",
              }
              );
        }
    }
}
