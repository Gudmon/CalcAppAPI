using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using System.Diagnostics.Metrics;
using static CalcAppAPI.Domain.Entities.Errors.Errors;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace CalcAppAPI.Data.Extensions.Configure.Palms.Cranes
{
    public static class PalmsCraneTurningDeviceCounterPlateConfig
    {
        public static void ConfigureMultiplePalmsCraneTurningDeviceCounterPlates(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TurningDeviceCounterPlate>().HasData(
              new TurningDeviceCounterPlate
              {
                  Id = 1,
                  Name = "Fedőlap a fordító szerkezethez",
                  Code = "PL",
                  Price = "340",
                  ImageUrls = ["PALMS-crane-turning-device-counter-plate-1"]
              }
              );
        }
    }
}
