using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Configure.Krpan.Trailers
{
    public static class KrpanAdjustableDriveConfig
    {
        public static void ConfigureMultipleKrpanAdjustableDrives(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanAdjustableDrive>().HasData(
                new KrpanAdjustableDrive
                {
                    Id = 1,
                    Name = "Proporcionális hajtássebesség-állítás",
                    Code = "",
                    Price = "2187,50",
                }
                );
        }
    }
}
