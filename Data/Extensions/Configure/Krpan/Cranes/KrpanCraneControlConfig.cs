using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class KrpanCraneControlConfig
    {
        public static void ConfigureMultipleKrpanCraneControlConfigs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneControl>().HasData(
                // GP 8/9/10 DF GD 6,6/7,6K 
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 1,
                    Name = "Mechanikus EURO vezérlés ergonomikus karokkal",
                    Code = "",
                    Description = "",
                    Price = "0",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 2,
                    Name = "Keresztkaros vezérlés el. ON/OFF funkciókkal",
                    Code = "",
                    Description = "",
                    Price = "702,50",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 3,
                    Name = "Proporcionális hidraulikus (alacsony nyomású) Joystick vezérlés",
                    Code = "",
                    Description = "BASIC csomaggal elérhető",
                    Price = "2469,17",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 4,
                    Name = "Proporcionális elektromos joystick vezérlés",
                    Code = "",
                    Description = "BASIC csomaggal elérhető",
                    Price = "4022,50",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 5,
                    Name = "LX6 alacsony nyomású szelepek",
                    Code = "",
                    Description = "PROFI 1 csomaggal elérhető",
                    Price = "4656,67",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 6,
                    Name = "LX6 elektroszelepek",
                    Code = "",
                    Description = "PROFI 1 csomaggal elérhető",
                    Price = "6210,00",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 7,
                    Name = "LX6 alacsony nyomású (LS) szelepek",
                    Code = "",
                    Description = "PROFI+ csomaggal elérhető",
                    Price = "4656,67",
                },
                // GP 8/9/10 DF GD 6,6/7,6K
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 8,
                    Name = "LX6 elektro (LS) szelepek",
                    Code = "",
                    Description = "PROFI+ csomaggal elérhető",
                    Price = "6210,00",
                },
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 9,
                    Name = "LX6 alacsony nyomású szelepek",
                    Code = "",
                    Description = "PROFI 1 / PROFI 2 csomaggal elérhető",
                    Price = "4656,67",
                },
                // GP 11 D GD 6,6/7,6K
                new KrpanCraneControl
                {
                    Id = 10,
                    Name = "LX6 elektroszelepek",
                    Code = "",
                    Description = "PROFI 1 / PROFI 2 csomaggal elérhető",
                    Price = "6210,00",
                },
                //  GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 11,
                    Name = "Proporcionális hidraulikus (alacsony nyomású) Joystick vezérlés",
                    Code = "",
                    Description = "",
                    Price = "0",
                },
                //  GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 12,
                    Name = "Vezérlés mechanikus EURO karokkal",
                    Code = "",
                    Description = "BASIC csomaggal elérhető",
                    Price = "-1235,00",
                },
                //  GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 13,
                    Name = "Keresztkaros vezérlés el. ON/OFF funkciókkal",
                    Code = "",
                    Description = "BASIC csomaggal elérhető",
                    Price = "-532,50",
                },
                //  GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 14,
                    Name = "Proporcionális elektromos joystick vezérlés",
                    Code = "",
                    Description = "BASIC/ SEMI PROFI csomaggal elérhető",
                    Price = "1552,50",
                },
                //  GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 15,
                    Name = "Proporcionális hidraulikus (alacsony nyomású) osztott Joystick vezérlés",
                    Code = "",
                    Description = "SEMI PROFI csomaggal elérhető",
                    Price = "1045,00",
                },
                //  GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 16,
                    Name = "Proporcionális elektromos osztott joystick vezérlés",
                    Code = "",
                    Description = "SEMI PROFI csomaggal elérhető",
                    Price = "2597,50",
                },
                // GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 17,
                    Name = "LX6 alacsony nyomású szelepek",
                    Code = "",
                    Description = "PROFI 1 / PROFI 2 csomaggal elérhető",
                    Price = "2187,50",
                },
                // GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 18,
                    Name = "LX6 elektroszelepek",
                    Code = "",
                    Description = "PROFI 1 / PROFI 2 csomaggal elérhető",
                    Price = "3740,00",
                },
                // GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 19,
                    Name = "LX6 alacsony nyomású (LS) szelepek",
                    Code = "",
                    Description = "PROFI+ csomaggal elérhető",
                    Price = "1231,67",
                },
                // GP 11 D GD 7,4K
                new KrpanCraneControl
                {
                    Id = 20,
                    Name = "LX6 elektro (LS) szelepek",
                    Code = "",
                    Description = "PROFI+ csomaggal elérhető",
                    Price = "2784,17",
                }
                );
        }
    }
}
