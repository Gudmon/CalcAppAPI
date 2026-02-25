using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneGrappleConfig
    {
        public static void ConfigureMultiplePalmsGrapples(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grapple>().HasData(
                new Grapple
                {
                    Id = 1,
                    Name = "Rönkfogó kanál nélkül",
                    Code = "C0",
                    Price = "0"
                },
              new Grapple
              {
                 Id = 2,
                 Name = "Kanál 0,16 Palms (FL)",
                 Code = "C02",
                 Price = "1085",
                 Mass = "66",
                 Area = "0.16",
                 A = "1040",
                 B = "670",
                 C = "410",
                 D = "55",
                 E = "305",
                 ImageUrls = ["PALMS-crane-grapple-C02-1", "PALMS-crane-grapple-C02-2"]
              },
              new Grapple
              {
                 Id = 3,
                 Name = "Kanál 0,18 Palms (FL)",
                 Code = "C1",
                 Price = "1395",
                 Mass = "88",
                 Area = "0.18",
                 A = "1230",
                 B = "690",
                 C = "480",
                 D = "80",
                 E = "315",
                 ImageUrls = ["PALMS-crane-grapple-C1-1", "PALMS-crane-grapple-C2-2"]
              },
              new Grapple
              {
                 Id = 4,
                 Name = "Kanál 0,23 Palms (FL)",
                 Code = "C3",
                 Price = "1745",
                 Mass = "114",
                 Area = "0.23",
                 A = "1465",
                 B = "760",
                 C = "500",
                 D = "69",
                 E = "340",
                 ImageUrls = ["PALMS-crane-grapple-C3-1", "PALMS-crane-grapple-C3-2", "PALMS-crane-grapple-C3-3", "PALMS-crane-grapple-C3-4"]
              },
              new Grapple
              {
                  Id = 5,
                  Name = "Kanál 0,25 Grippen (FL)",
                  Code = "C5.1",
                  Price = "3380",
                  Area = "0.25"
              },
              new Grapple
              {
                  Id = 6,
                  Name = "Kanál 0,26 Palms (FL)",
                  Code = "C5.2",
                  Price = "2615",
                  Mass = "174",
                  Area = "0.26",
                  A = "1530",
                  B = "870",
                  C = "525",
                  D = "70",
                  E = "430",
                  ImageUrls = ["PALMS-crane-grapple-C5.2-1", "PALMS-crane-grapple-C5.2-2"]
              },
              new Grapple
              {
                  Id = 7,
                  Name = "Biomasszás kanál 0,21 Palms (FL)",
                  Code = "C36",
                  Price = "2230",
                  Mass = "127",
                  Area = "0.21",
                A = "1475",
                B = "760",
                C = "500",
                D = "60",
                E = "370",
                ImageUrls = ["PALMS-crane-grapple-C36-1", "PALMS-crane-grapple-C36-2", "PALMS-crane-grapple-C36-3"]
              },
              new Grapple
              {
                  Id = 8,
                  Name = "Biomasszás kanál 0,25 Grippen (FL)",
                  Code = "C7.1",
                  Price = "3715",
                  Area = "0.25"
              },
              new Grapple
              {
                  Id = 9,
                  Name = "Biomasszás kanál 0,23 Palms (FL)",
                  Code = "C7.2",
                  Price = "3020",
                  Mass = "118",
                  Area = "0.23",
                 A = "1550",
                 B = "870",
                 C = "525",
                 D = "70",
                 E = "455",
                  ImageUrls = ["PALMS-crane-grapple-C7.2-1", "PALMS-crane-grapple-C7.2-2"]
              },
              new Grapple
              {
                  Id = 10,
                  Name = "Biomasszás kanál 0,25 Palms (FL)",
                  Code = "C11",
                  Price = "3450",
                  Mass = "223",
                  Area = "0.25",
                  A = "1635",
                  B = "895",
                  C = "570",
                  D = "85",
                  E = "505",
                  ImageUrls = ["PALMS-crane-grapple-C11-1", "PALMS-crane-grapple-C11-2"]
              },
              new Grapple
              {
                  Id = 11,
                  Name = "Palms 0,28-as kanál (FL)",
                  Code = "C10",
                  Price = "3125",
                  Mass = "205",
                  Area = "0.28",
                  A = "1615",
                  B = "895",
                  C = "570",
                  D = "85",
                  E = "475",
                  ImageUrls = ["PALMS-crane-grapple-C10-1", "PALMS-crane-grapple-C10-2", "PALMS-crane-grapple-C10-3"]
              },
              new Grapple
              {
                  Id = 12,
                  Name = "Palms vágó kanál a Nisula-tól",
                  Code = "C175",
                  Price = "6500"
              },
              new Grapple
              {
                  Id = 13,
                  Name = "Aprítékos kiegészítő 0,16 Palms (FL) kanálhoz",
                  Code = "GB16",
                  Price = "475",
                  Mass = "99",
                  ImageUrls = ["PALMS-crane-grapple-GB16-1", "PALMS-crane-grapple-GB16-2", "PALMS-crane-grapple-GB"],
                  VideoUrls = ["Ff3LQ7rCo0E"]
              },
              new Grapple
              {
                  Id = 14,
                  Name = "Aprítékos kiegészítő 0,18 Palms (FL) kanálhoz",
                  Code = "GB18",
                  Price = "610",
                  Mass = "130",
                  ImageUrls = ["PALMS-crane-grapple-GB18-1", "PALMS-crane-grapple-GB"],
                  VideoUrls = ["Ff3LQ7rCo0E"]
              },
              new Grapple
              {
                  Id = 15,
                  Name = "Aprítékos kiegészítő 0,23 Palms (FL) kanálhoz",
                  Code = "GB3",
                  Price = "935",
                  Mass = "195",
                  ImageUrls = ["PALMS-crane-grapple-GB3-1", "PALMS-crane-grapple-GB"],
                  VideoUrls = ["JbYq1cykdEc"]
              },
              new Grapple
              {
                  Id = 16,
                  Name = "Palms 0,09 kanál",
                  Code = "C009",
                  Price = "660",
                  Mass = "36",
                  Area = "0.09",
                  A = "870",
                  B = "540",
                  C = "315",
                  D = "40",
                  E = "265",
                  ImageUrls = ["PALMS-crane-grapple-C009-1", "PALMS-crane-grapple-C009-2", "PALMS-crane-grapple-C009-3"]
              }
              );
        }
    }
}
