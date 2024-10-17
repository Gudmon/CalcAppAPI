using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Palms.Cranes
{
    public static class PalmsCraneHighPerformanceOilFilterConfig
    {
        public static void ConfigureMultiplePalmsCraneHighPerformanceOilFilters(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HighPerformanceOilFilter>().HasData(
              new HighPerformanceOilFilter
              {
                  Id = 1,
                  Name = "Nagynyomású olajszűrő",
                  Code = "HPF",
                  Price = "395"
              }
              );
        }
    }
}
