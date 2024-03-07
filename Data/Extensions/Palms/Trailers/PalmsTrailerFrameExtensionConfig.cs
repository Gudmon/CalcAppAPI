using CalcAppAPI.Models.Machine.Configurations.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerFrameExtensionConfig
    {
        public static void ConfigureMultiplePalmsFrameExtensions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FrameExtension>().HasData(
               new FrameExtension
               {
                   Id = 1,
                   Name = "Hidraulikus működtetésű raktér hosszabbítás ",
                   Code = "Hex",
                   Price = "210",
               });
        }
    }
}
