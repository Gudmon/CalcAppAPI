using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class ConnectPalmsTrailerOptions
    {
        public static void ConnectAllPalmsTrailerOptions(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConnectTrailersWithBrakes();
        }
    }
}
