using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Cranes
{
    public static class ConnectKrpanCraneOptions
    {
        public static void ConnectAllKrpanCranesOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConnectKrpanCranesWithCraneControl();
            modelBuilder.ConnectKrpanCranesWithSlewingDrive();
            modelBuilder.ConnectKrpanCranesWithRotators();
        }
    }
}
