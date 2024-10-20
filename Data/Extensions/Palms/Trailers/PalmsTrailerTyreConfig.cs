using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerTyreConfig
    {
        public static void ConfigureMultiplePalmsTyres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tyre>().HasData(
               new Tyre
               {
                   Id = 1,
                   Name = "400/60-15,5 standard felni, 6 lyukas, Starco",
                   Code = "WH2.6e",
                   Price = "1220",
               },
               new Tyre
               {
                   Id = 2,
                   Name = "400/60-15,5 RF-felni, 6 lyukas, Starco",
                   Code = "WH2.6",
                   Price = "1450",
               },
               new Tyre
               {
                   Id = 3,
                   Name = "480/45-17 RF-felni, 6 lyukas, Starco",
                   Code = "WH4.6",
                   Price = "2310",
               },
               new Tyre
               {
                   Id = 4,
                   Name = "500/50-17 RF-felni, 6 lyukas, BKT",
                   Code = "WH3.6",
                   Price = "2500"
               },
               new Tyre
               {
                   Id = 5,
                   Name = "500/50-17 RF-felni, 8 lyukas, BKT",
                   Code = "WH3.8",
                   Price = "2500",
               },
               new Tyre
               {
                   Id = 6,
                   Name = "400/55-22,5 RF-felni, 6 lyukas, Alliance",
                   Code = "WH5.6",
                   Price = "3215",
               },
               new Tyre
               {
                   Id = 7,
                   Name = "500/55-22,5 RF-felni, 8 lyukas, BKT",
                   Code = "WH8.8",
                   Price = "3770",
               },
               new Tyre
               {
                   Id = 8,
                   Name = "550/45-22,5 RF-felni, 8 lyukas, BKT",
                   Code = "WH6.8",
                   Price = "4010",
               },
               new Tyre
               {
                   Id = 9,
                   Name = "550/45-22,5 RF-felni, 8 lyukas, BKT - traktor mintás",
                   Code = "WH6.8V",
                   Price = "4410",
               },
               new Tyre
               {
                   Id = 10,
                   Name = "600/40-22,5 RF-felni, 8 lyukas, BKT - traktor mintás",
                   Code = "WH9.8V",
                   Price = "6425",
               },
               new Tyre
               {
                   Id = 11,
                   Name = "600/50-22,5 RF-felni, 8 lyukas, Alliance",
                   Code = "WH7.8",
                   Price = "5410",
               },
               new Tyre
               {
                   Id = 12,
                   Name = "600/50-22,5 RF-felni, 10 lyukas, Nokian",
                   Code = "WH7.10",
                   Price = "11020",
               },
               new Tyre
               {
                   Id = 13,
                   Name = "710/40-22,5 RF-felni, 10 lyukas, Nokian",
                   Code = "WH9.10",
                   Price = "11150",
               },
               new Tyre
               {
                   Id = 14,
                   Name = "22/11-8",
                   Code = "WH1.4",
                   Price = "465",
               }
               );
        }
    }
}
