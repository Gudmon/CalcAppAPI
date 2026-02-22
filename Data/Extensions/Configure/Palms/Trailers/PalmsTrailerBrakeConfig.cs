using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerBrakeConfig
    {
        public static void ConfigureMultiplePalmsBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brake>().HasData(
               new Brake
               {
                   Id = 1,
                   Name = "Fék nélkül",
                   Code = "B0",
                   Price = "0",
               },
               new Brake
               {
                   Id = 2,
                   Name = "2 keréken hidraulikus fék",
                   Code = "B1",
                   Price = "960",
                   ImageUrls = ["PALMS-trailer-brake-1"]
               },
               new Brake
               {
                   Id = 3,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "1870",
                   ImageUrls = ["PALMS-trailer-brake-2"]
               },
               new Brake
               {
                   Id = 4,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "1620",
                   ImageUrls = ["PALMS-trailer-brake-3"]
               },
               new Brake
               {
                   Id = 5,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "2710",
                   ImageUrls = ["PALMS-trailer-brake-4"]
               },
               new Brake
               {
                   Id = 6,
                   Name = "EU jóváhagyott szett, légfék 2 keréken, PB1",
                   Code = "BA-EU",
                   Price = "2100",
               },
               new Brake
               {
                   Id = 7,
                   Name = "EU jóváhagyott szett, hidraulikus fék, PB1",
                   Code = "BH-EU",
                   Price = "3450",
               },

               new Brake
               {
                   Id = 8,
                   Name = "EU jóváhagyott szett, légfék 4 keréken, PB1",
                   Code = "BA-EU",
                   Price = "3195",
               },
               new Brake
               {
                   Id = 9,
                   Name = "EU jóváhagyott szett, hidraulikus fék, PB1",
                   Code = "BH-EU",
                   Price = "4360",
               },
               new Brake
               {
                   Id = 10,
                   Name = "2 keréken hidraulikus fék",
                   Code = "B1",
                   Price = "1155",
                   ImageUrls = ["PALMS-trailer-brake-1"]
               },
               new Brake
               {
                   Id = 11,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "2205",
                   ImageUrls = ["PALMS-trailer-brake-2"]
               },
               new Brake
               {
                   Id = 12,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "1815",
                   ImageUrls = ["PALMS-trailer-brake-3"]
               },
               new Brake
               {
                   Id = 13,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "3045",
                   ImageUrls = ["PALMS-trailer-brake-4"]
               },
               new Brake
               {
                   Id = 14,
                   Name = "EU jóváhagyott szett, légfék 4 keréken, PB1",
                   Code = "BA-EU",
                   Price = "3530",
               },
               new Brake
               {
                   Id = 15,
                   Name = "EU jóváhagyott szett, hidraulikus fék, PB1",
                   Code = "BH-EU",
                   Price = "4695",
               },
               new Brake
               {
                   Id = 16,
                   Name = "2 keréken hidraulikus fék",
                   Code = "B1",
                   Price = "3150",
                   ImageUrls = ["PALMS-trailer-brake-1"]
               },
               new Brake
               {
                   Id = 17,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "6195",
                   ImageUrls = ["PALMS-trailer-brake-2"]
               },
               new Brake
               {
                   Id = 18,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "3810",
                   ImageUrls = ["PALMS-trailer-brake-3"]
               },
               new Brake
               {
                   Id = 19,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "7035",
                   ImageUrls = ["PALMS-trailer-brake-4"]
               },
               new Brake
               {
                   Id = 20,
                   Name = "EU jóváhagyott szett, légfék 4 keréken, PB1",
                   Code = "BA-EU",
                   Price = "7520",
               },
               new Brake
               {
                   Id = 21,
                   Name = "EU jóváhagyott szett, hidraulikus fék, PB1",
                   Code = "BH-EU",
                   Price = "8685",
               },
               new Brake
               {
                   Id = 22,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "3625",
                   ImageUrls = ["PALMS-trailer-brake-3"]
               },

               new Brake
               {
                   Id = 23,
                   Name = "4 keréken hidraulikus többtárcsás fék (sebességváltón keresztül)",
                   Code = "B2",
                   Price = "250",
                   ImageUrls = ["PALMS-trailer-brake-2"]
               },
               new Brake
               {
                   Id = 24,
                   Name = "4 kerék légfék (hidraulikusan működtetett, többtárcsás, sebességváltón keresztül)",
                   Code = "B4",
                   Price = "3035",
                   ImageUrls = ["PALMS-trailer-brake-4"]
               }
               );
        }
    }
}
