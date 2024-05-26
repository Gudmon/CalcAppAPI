using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Trailers
{
    public static class PalmsTrailerMOTConfig
    {
        public static void ConfigureMultiplePalmsMOTs(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MOT>().HasData(
               new MOT
               {
                   Id = 1,
                   Name = "Pótkocsi műszaki vizsga",
                   Code = "",
                   Price = "500",
               });
        }
    }
}
