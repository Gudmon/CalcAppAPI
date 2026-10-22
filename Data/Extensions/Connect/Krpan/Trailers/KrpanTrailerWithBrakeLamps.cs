using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithBrakeLamps
    {
        public static void ConnectKrpanTrailersWithBrakeLamps(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanTrailerBrakeLamps)
                .WithMany(o => o.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanTrailerBrakeLampTrailer")
                    .HasData(
                        // GP 12 DF: LED féklámpák ROM and LED féklámpák RIO
                        new { KrpanTrailerId = 4, KrpanTrailerBrakeLampsId = 1 },
                        new { KrpanTrailerId = 4, KrpanTrailerBrakeLampsId = 2 },

                        // GP 14 DF: LED féklámpák ROM and LED féklámpák RIO
                        new { KrpanTrailerId = 5, KrpanTrailerBrakeLampsId = 1 },
                        new { KrpanTrailerId = 5, KrpanTrailerBrakeLampsId = 2 },

                        // GP 13 D: LED féklámpák RIO
                        new { KrpanTrailerId = 7, KrpanTrailerBrakeLampsId = 3 },

                        // GP 15 D: LED féklámpák RIO
                        new { KrpanTrailerId = 8, KrpanTrailerBrakeLampsId = 3 }));
        }
    }
}
