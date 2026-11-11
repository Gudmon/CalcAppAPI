using CalcAppAPI.Models.Machine.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Cranes
{
    public static class KrpanCranesWithGrapples
    {
        public static void ConnectKrpanCranesWithGrapples(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KrpanCrane>()
                .HasMany(c => c.KrpanGrapples)
                .WithMany(g => g.KrpanCranes)
                .UsingEntity(j => j.ToTable("KrpanGrapplesCrane")
                    .HasData(
                        //KRPAN GD 6,6K (GP 8/9/10 S)
                        new { KrpanCranesId = 1, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 1, KrpanGrapplesId = 2 },

                        //KRPAN GD 7,4K (GP 11/13/15 D GP 12/14 DF)
                        new { KrpanCranesId = 2, KrpanGrapplesId = 7 },
                        new { KrpanCranesId = 2, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 2, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 2, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 2, KrpanGrapplesId = 6 },

                        //KRPAN GD 7,6K (GP 8/9/10 S)
                        new { KrpanCranesId = 3, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 3, KrpanGrapplesId = 2 },

                        //KRPAN GD 8,6 K (GP 11/13/15 D)
                        new { KrpanCranesId = 4, KrpanGrapplesId = 7 },
                        new { KrpanCranesId = 4, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 4, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 4, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 4, KrpanGrapplesId = 6 },

                        //KRPAN GD 7,2 Z
                        new { KrpanCranesId = 5, KrpanGrapplesId = 7 },
                        new { KrpanCranesId = 5, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 5, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 5, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 5, KrpanGrapplesId = 6 },

                        //KRPAN GD 8,4 Z
                        new { KrpanCranesId = 6, KrpanGrapplesId = 7 },
                        new { KrpanCranesId = 6, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 6, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 6, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 6, KrpanGrapplesId = 6 },

                        //KRPAN GD 5,6K
                        new { KrpanCranesId = 7, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 7, KrpanGrapplesId = 2 },

                        //KRPAN GD 6,2K
                        new { KrpanCranesId = 8, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 8, KrpanGrapplesId = 2 },

                        // KRPAN GD 6,6K(GP 8 / 9 / 10 DF)
                        new { KrpanCranesId = 9, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 9, KrpanGrapplesId = 2 },
                        new { KrpanCranesId = 9, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 9, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 9, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 9, KrpanGrapplesId = 6 },

                        // KRPAN GD 6,6K(GP 11 D)
                        new { KrpanCranesId = 10, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 10, KrpanGrapplesId = 2 },
                        new { KrpanCranesId = 10, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 10, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 10, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 10, KrpanGrapplesId = 6 },

                        // KRPAN GD 7,6K(GP 8 / 9 / 10 DF)
                        new { KrpanCranesId = 11, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 11, KrpanGrapplesId = 2 },
                        new { KrpanCranesId = 11, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 11, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 11, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 11, KrpanGrapplesId = 6 },

                        // KRPAN GD 7,6K(GP 11 D)
                        new { KrpanCranesId = 12, KrpanGrapplesId = 1 },
                        new { KrpanCranesId = 12, KrpanGrapplesId = 2 },
                        new { KrpanCranesId = 12, KrpanGrapplesId = 3 },
                        new { KrpanCranesId = 12, KrpanGrapplesId = 4 },
                        new { KrpanCranesId = 12, KrpanGrapplesId = 5 },
                        new { KrpanCranesId = 12, KrpanGrapplesId = 6 }
                    ));
        }
    }
}
