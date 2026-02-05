using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Trailers
{
    public static class PalmsTrailerFrameExtensionConfig
    {
        public static void ConfigureMultiplePalmsFrameExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrameExtension>().HasData(
               new FrameExtension
               {
                   Id = 1,
                   Name = "Hidraulikus henger a keret meghosszabbításához",
                   Code = "HEX",
                   Price = "210",
               },
               new FrameExtension
               {
                   Id = 2,
                   Name = "Raktér hosszabbítás (100mm-enként)",
                   Code = "LF",
                   Price = "0",
               });
        }
    }
}
