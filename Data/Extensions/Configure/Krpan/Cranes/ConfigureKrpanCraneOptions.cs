using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class ConfigureKrpanCraneOptions
    {
        public static void ConfigureAllKrpanCraneOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureMultipleKrpanCranes();
        }
    }
}
