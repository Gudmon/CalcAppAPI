using CalcAppAPI.Models.Machine.Configurations.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Cranes
{
    public static class KrpanCraneSlewingDriveConfig
    {
        public static void ConfigureMultipleKrpanCraneSlewingDrive(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCraneSlewingDrive>().HasData(
                new KrpanCraneSlewingDrive
                {
                    Id = 1,
                    Name = "Olajfürdős daruforgató hajtómű",
                    Code = "",
                    Description = "",
                    Price = "0"
                });
        }
    }
}
