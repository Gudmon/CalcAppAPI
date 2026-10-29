using CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan
{
    public static class ConfigureKrpanCraneOptions
    {
        public static void ConfigureAllKrpanCraneOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMultipleKrpanCranes();
            modelBuilder.ConfigureMultipleKrpanCraneControlConfigs();
            modelBuilder.ConfigureMultipleKrpanCraneSlewingDrive();
        }
    }
}
