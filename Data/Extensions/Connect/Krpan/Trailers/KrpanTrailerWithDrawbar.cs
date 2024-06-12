using CalcAppAPI.Models.Machine.Krpan.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Trailers
{
    public static class KrpanTrailerWithDrawbar
    {
        public static void ConnectKrpanTrailersWithDrawbars(this ModelBuilder modelBuilder)
        {
            // DRAWBAR
            modelBuilder.Entity<KrpanTrailer>()
                .HasMany(t => t.KrpanDrawbar)
                .WithMany(c => c.KrpanTrailer)
                .UsingEntity(j => j.ToTable("KrpanDrawbarTrailer")
                    .HasData
                    (
                        //KRPAN GP 8 DF
                        new { KrpanTrailerId = 1, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 1, KrpanDrawbarId = 2 },

                        //KRPAN GP 9 DF
                        new { KrpanTrailerId = 2, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 2, KrpanDrawbarId = 2 },

                        //KRPAN GP 10 DF
                        new { KrpanTrailerId = 3, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 3, KrpanDrawbarId = 2 },

                        //KRPAN GP 12 DF
                        new { KrpanTrailerId = 4, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 4, KrpanDrawbarId = 2 },

                        //KRPAN GP 14 DF
                        new { KrpanTrailerId = 5, KrpanDrawbarId = 1 },
                        new { KrpanTrailerId = 5, KrpanDrawbarId = 2 },

                        //KRPAN GP 11 D
                        new { KrpanTrailerId = 6, KrpanDrawbarId = 3 },

                        //KRPAN GP 13 D
                        new { KrpanTrailerId = 7, KrpanDrawbarId = 3 },

                        //KRPAN GP 15 D
                        new { KrpanTrailerId = 8, KrpanDrawbarId = 3 }
                    )
                );
        }
    }
}
