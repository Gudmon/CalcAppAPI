using CalcAppAPI.Models.Machine.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Cranes
{
    public static class KrpanCranesWithRotators
    {
        public static void ConnectKrpanCranesWithRotators(this ModelBuilder modelBuilder)
        {
            // DRAWBAR
            modelBuilder.Entity<KrpanCrane>()
                .HasMany(c => c.KrpanCraneRotators)
                .WithMany(t => t.KrpanCranes)
                .UsingEntity(j => j.ToTable("KrpanCraneRotators")
                    .HasData
                    (
                        //KRPAN GD 6,6K (GP 8/9/10 S)
                        new { KrpanCranesId = 1, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 1, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 1, KrpanCraneRotatorsId = 3 },

                        //KRPAN GD 7,4K (GP 11/13/15 D GP 12/14 DF)
                        new { KrpanCranesId = 2, KrpanCraneRotatorsId = 6 },
                        new { KrpanCranesId = 2, KrpanCraneRotatorsId = 7 },
                        new { KrpanCranesId = 2, KrpanCraneRotatorsId = 8 },
                        new { KrpanCranesId = 2, KrpanCraneRotatorsId = 9 },

                        //KRPAN GD 7,6K (GP 8/9/10 S)
                        new { KrpanCranesId = 3, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 3, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 3, KrpanCraneRotatorsId = 3 },

                        //KRPAN GD 8,6 K (GP 11/13/15 D)
                        new { KrpanCranesId = 4, KrpanCraneRotatorsId = 6 },
                        new { KrpanCranesId = 4, KrpanCraneRotatorsId = 7 },
                        new { KrpanCranesId = 4, KrpanCraneRotatorsId = 8 },
                        new { KrpanCranesId = 4, KrpanCraneRotatorsId = 9 },
                        new { KrpanCranesId = 4, KrpanCraneRotatorsId = 10 },
                        new { KrpanCranesId = 4, KrpanCraneRotatorsId = 11 },

                        //KRPAN GD 7,2 Z
                        new { KrpanCranesId = 5, KrpanCraneRotatorsId = 6 },
                        new { KrpanCranesId = 5, KrpanCraneRotatorsId = 7 },
                        new { KrpanCranesId = 5, KrpanCraneRotatorsId = 8 },
                        new { KrpanCranesId = 5, KrpanCraneRotatorsId = 9 },

                        //KRPAN GD 8,4 Z
                        new { KrpanCranesId = 6, KrpanCraneRotatorsId = 6 },
                        new { KrpanCranesId = 6, KrpanCraneRotatorsId = 7 },
                        new { KrpanCranesId = 6, KrpanCraneRotatorsId = 8 },
                        new { KrpanCranesId = 6, KrpanCraneRotatorsId = 9 },

                        //KRPAN GD 5,6K
                        new { KrpanCranesId = 7, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 7, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 7, KrpanCraneRotatorsId = 3 },

                        //KRPAN GD 6,2K
                        new { KrpanCranesId = 8, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 8, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 8, KrpanCraneRotatorsId = 3 },

                        // KRPAN GD 6,6K(GP 8 / 9 / 10 DF)
                        new { KrpanCranesId = 9, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 9, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 9, KrpanCraneRotatorsId = 3 },
                        new { KrpanCranesId = 9, KrpanCraneRotatorsId = 4 },
                        new { KrpanCranesId = 9, KrpanCraneRotatorsId = 5 },

                        // KRPAN GD 6,6K(GP 11 D)
                        new { KrpanCranesId = 10, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 10, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 10, KrpanCraneRotatorsId = 3 },
                        new { KrpanCranesId = 10, KrpanCraneRotatorsId = 4 },
                        new { KrpanCranesId = 10, KrpanCraneRotatorsId = 5 },

                        // KRPAN GD 7,6K(GP 8 / 9 / 10 DF)
                        new { KrpanCranesId = 11, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 11, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 11, KrpanCraneRotatorsId = 3 },
                        new { KrpanCranesId = 11, KrpanCraneRotatorsId = 4 },
                        new { KrpanCranesId = 11, KrpanCraneRotatorsId = 5 },

                        // KRPAN GD 7,6K(GP 11 D)
                        new { KrpanCranesId = 12, KrpanCraneRotatorsId = 1 },
                        new { KrpanCranesId = 12, KrpanCraneRotatorsId = 2 },
                        new { KrpanCranesId = 12, KrpanCraneRotatorsId = 3 },
                        new { KrpanCranesId = 12, KrpanCraneRotatorsId = 4 },
                        new { KrpanCranesId = 12, KrpanCraneRotatorsId = 5 }
                    )
                );
        }
    }
}
