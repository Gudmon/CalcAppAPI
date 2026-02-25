using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
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
                  Price = "0",
                  ImageUrls = ["PALMS-crane-high-performance-filter-1", "PALMS-crane-high-performance-filter-2"]
              },
              new HighPerformanceOilFilter
              {
                  Id = 2,
                  Name = "Nagynyomású olajszűrő",
                  Code = "HPF",
                  Price = "395",
                  ImageUrls = ["PALMS-crane-high-performance-filter-1", "PALMS-crane-high-performance-filter-2"]
              }
              );
        }
    }
}
