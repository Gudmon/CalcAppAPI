using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
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
               },
               new Brake
               {
                   Id = 3,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "1810",
               },
               new Brake
               {
                   Id = 4,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "1615",
               },
               new Brake
               {
                   Id = 5,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "2640",
               },
               new Brake
               {
                   Id = 6,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "2095",
               },
               new Brake
               {
                   Id = 7,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "3450",
               },

               new Brake
               {
                   Id = 8,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "3125",
               },
               new Brake
               {
                   Id = 9,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "4295",
               },

               new Brake
               {
                   Id = 10,
                   Name = "2 keréken hidraulikus fék",
                   Code = "B1",
                   Price = "1255",
               },
               new Brake
               {
                   Id = 11,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "4545",
               },
               new Brake
               {
                   Id = 12,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "1915",
               },
               new Brake
               {
                   Id = 13,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "5385",
               },
               new Brake
               {
                   Id = 14,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "5605",
               },
               new Brake
               {
                   Id = 15,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "6770",
               },
               new Brake
               {
                   Id = 16,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "2415",
               },
               new Brake
               {
                   Id = 17,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "3255",
               },
               new Brake
               {
                   Id = 18,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "3740",
               },
               new Brake
               {
                   Id = 19,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "4905",
               },
               new Brake
               {
                   Id = 20,
                   Name = "2 keréken hidraulikus fék",
                   Code = "B1",
                   Price = "3390",
               },
               new Brake
               {
                   Id = 21,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "6670",
               },
               new Brake
               {
                   Id = 22,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "4045",
               },
               new Brake
               {
                   Id = 23,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "7510",
               },
               new Brake
               {
                   Id = 24,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "7465",
               },
               new Brake
               {
                   Id = 25,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "8635",
               },
               new Brake
               {
                   Id = 26,
                   Name = "4 keréken hidraulikus fék",
                   Code = "B2",
                   Price = "2305",
               },
               new Brake
               {
                   Id = 27,
                   Name = "2 keréken légfék",
                   Code = "B3",
                   Price = "1860",
               },
               new Brake
               {
                   Id = 28,
                   Name = "4 keréken légfék",
                   Code = "B4",
                   Price = "3145",
               },
               new Brake
               {
                   Id = 29,
                   Name = "Légfék",
                   Code = "BA-EU",
                   Price = "3620",
               },
               new Brake
               {
                   Id = 30,
                   Name = "Hidraulikus fék",
                   Code = "BH-EU",
                   Price = "4795",
               },

               new Brake
               {
                   Id = 31,
                   Name = "4 keréken hidraulikus többtárcsás fék (sebességváltón keresztül)",
                   Code = "B2",
                   Price = "250",
               },
               new Brake
               {
                   Id = 32,
                   Name = "4 kerék légfék (hidraulikusan működtetett, többtárcsás, sebességváltón keresztül)",
                   Code = "B4",
                   Price = "3035",
               }
               );
        }
    }
}
