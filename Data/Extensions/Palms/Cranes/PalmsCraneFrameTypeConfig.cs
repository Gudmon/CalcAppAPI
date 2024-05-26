using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneFrameTypeConfig
    {
        public static void ConfigureMultiplePalmsFrameTypes(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrameType>().HasData(
               new FrameType
               {
                   Id = 1,
                   Name = "Talpaló nélkül",
                   Code = "B0",
                   Price = "0",
                   Mass = ""
               },
               new FrameType
               {
                   Id = 2,
                   Name = "A típusú kis letalpaló, 3 pontos csatlakozással",
                   Code = "B2.1",
                   Price = "1680",
                   Mass = "174"
               },
               new FrameType
               {
                   Id = 3,
                   Name = "B3, A típusú normál méretű letalpaló, 3 pontos csatlakozással",
                   Code = "B3",
                   Price = "2100",
                   Mass = "313"
               },
               new FrameType
               {
                   Id = 4,
                   Name = "FD típusú economy letalpaló",
                   Code = "B4e",
                   Price = "2100",
                   Mass = "237"
               },
               new FrameType
               {
                   Id = 5,
                   Name = "B6.1 FD típusú letalpaló, 3 pontos csatlakozással",
                   Code = "B6.1",
                   Price = "3090",
                   Mass = "449"
               },
               new FrameType
               {
                   Id = 6,
                   Name = "B09 Különösen erős alap, talpaló lábak nélkül",
                   Code = "B09",
                   Price = "1155",
                   Mass = "231"
               },
               new FrameType
               {
                   Id = 7,
                   Name = "B9 FD típusú, különösen erős letalpaló (HD)",
                   Code = "B9",
                   Price = "3530",
                   Mass = "474"
               },
               new FrameType
               {
                   Id = 8,
                   Name = "Talpaló Z daruhoz",
                   Code = "B10",
                   Price = "3685",
                   Mass = "520"
               },
               new FrameType
               {
                   Id = 9,
                   Name = "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábak nélkül (csak A21-A42 vezértömbhöz)",
                   Code = "B011",
                   Price = "4830",
                   Mass = "440"
               },
               new FrameType
               {
                   Id = 10,
                   Name = "Különösen erős talp daru billentéssel, vezérléssel, talpaló lábakkal (csak A21-A42 vezértömbhöz)",
                   Code = "B11",
                   Price = "7300",
                   Mass = "772"
               },
               new FrameType
               {
                   Id = 11,
                   Name = "FD talpaló",
                   Code = "B1",
                   Price = "695",
                   Mass = "50"
               }
               );

        }
    }
}
