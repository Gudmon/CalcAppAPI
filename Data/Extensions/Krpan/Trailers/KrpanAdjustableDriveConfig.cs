using CalcAppAPI.Models.Machine.Configurations.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Krpan.Trailers
{
    public static class KrpanAdjustableDriveConfig
    {
        public static void ConfigureMultipleKrpanAdjustableDrives(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanAdjustableDrive>().HasData(
                new KrpanAdjustableDrive
                {
                    Id = 1,
                    Name = "Proporcionálisan állítható meghajtás (BB5 esetén kötelező)",
                    Code = "",
                    Price = "2235",
                }
                );
        }
    }
}
