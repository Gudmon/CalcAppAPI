using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class KrpanCraneRotatorConfig
    {
        public static void ConfigureMultipleKrpanCraneRotators(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneRotator>().HasData(
                new KrpanCraneRotator
                {
                    Id = 1,
                    Name = "Rotátor 30 kN",
                    Code = "",
                    Description = "",
                    Price = "0"
                },
                new KrpanCraneRotator
                {
                    Id = 2,
                    Name = "Rotátor 45 kN + karima",
                    Code = "",
                    Description = "",
                    Price = "231,66"
                },
                new KrpanCraneRotator
                {
                    Id = 3,
                    Name = "Rotátor 45 kN SF integrált karimával",
                    Code = "",
                    Description = "",
                    Price = "215,00"
                },
                new KrpanCraneRotator
                {
                    Id = 4,
                    Name = "Rotátor 55 kN + karima",
                    Code = "",
                    Description = "",
                    Price = "566,66"
                },
                new KrpanCraneRotator
                {
                    Id = 5,
                    Name = "Rotátor 55 kN integrált karimával",
                    Code = "",
                    Description = "",
                    Price = "626,67"
                },
                new KrpanCraneRotator
                {
                    Id = 6,
                    Name = "Rotátor 45 kN",
                    Code = "",
                    Description = "",
                    Price = "0"
                },
                new KrpanCraneRotator
                {
                    Id = 7,
                    Name = "Rotátor45 kN SF integrált karimával",
                    Code = "",
                    Description = "",
                    Price = "-16,00"
                },
                new KrpanCraneRotator
                {
                    Id = 8,
                    Name = "Rotátor 55 kN + karima",
                    Code = "",
                    Description = "",
                    Price = "335,00"
                },
                new KrpanCraneRotator
                {
                    Id = 9,
                    Name = "Rotátor 55 kN integrált karimával",
                    Code = "",
                    Description = "",
                    Price = "395,01"
                },
                // GD 8,6 K basic
                new KrpanCraneRotator
                {
                    Id = 10,
                    Name = "Indexator GV45 +",
                    Code = "",
                    Description = "",
                    Price = "746,05"
                },
                // GD 8,6 K option
                new KrpanCraneRotator
                {
                    Id = 11,
                    Name = "Indexator GV6 lengéscsillapítóval",
                    Code = "",
                    Description = "",
                    Price = "1592,97"
                }
                );
        }
    }
}
