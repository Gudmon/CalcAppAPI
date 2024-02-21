using CalcAppAPI.Models.Machine.Configurations.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Trailers;
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
                   Description = "",
                   Mass = ""
               },
               new FrameType
               {
                   Id = 2,
                   Name = "A típusú kis letalpaló, 3 pontos csatlakozással",
                   Code = "B2.1",
                   Price = "1680",
                   Description = "Kisebb PALMS erdészeti darukhoz megfelelő típusú támasztólábak",
                   Mass = "174"
               },
               new FrameType
               {
                   Id = 3,
                   Name = "A típusú normál méretű letalpaló, 3 pontos csatlakozással",
                   Code = "B3",
                   Price = "2100",
                   Description = "A típusú támasztólábak közepes méretű PALMS darukhoz",
                   Mass = "313"
               },
               new FrameType
               {
                   Id = 4,
                   Name = "FD típusú economy letalpaló",
                   Code = "B4e",
                   Price = "2100",
                   Description = "FD típusú támasztólábak",
                   Mass = "237"
               },
               new FrameType
               {
                   Id = 5,
                   Name = "FD típusú letalpaló, 3 pontos csatlakozással",
                   Code = "B6.1",
                   Price = "3090",
                   Description = "FD típusú támasztólábak",
                   Mass = "449"
               },
               new FrameType
               {
                   Id = 6,
                   Name = "Különösen erős alap, talpaló lábak nélkül",
                   Code = "B09",
                   Price = "1155",
                   Description = "Nagy teherbírású talp támasztólábak nélkül",
                   Mass = "231"
               },
               new FrameType
               {
                   Id = 7,
                   Name = "FD típusú, különösen erős letalpaló (HD)",
                   Code = "B9",
                   Price = "3530",
                   Description = "FD nagy teherbírású (HD) típusú támaszlábak",
                   Mass = "474"
               },
               new FrameType
               {
                   Id = 8,
                   Name = "Talpaló Z daruhoz",
                   Code = "B10",
                   Price = "3685",
                   Description = "FD típusú támasztólábak PALMS 5.87Z daruhoz",
                   Mass = "520"
               });
        }
    }
}
