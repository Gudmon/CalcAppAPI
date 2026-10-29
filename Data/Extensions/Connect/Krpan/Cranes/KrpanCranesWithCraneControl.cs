using CalcAppAPI.Models.Machine.Krpan.Cranes;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Krpan.Cranes
{
    public static class KrpanCranesWithCraneControl
    {
        public static void ConnectKrpanCranesWithCraneControl(this ModelBuilder modelBuilder)
        {
            // DRAWBAR
            modelBuilder.Entity<KrpanCrane>()
                .HasMany(c => c.KrpanCraneControls)
                .WithMany(t => t.KrpanCrane)
                .UsingEntity(j => j.ToTable("KrpanCraneControlsCrane")
                    .HasData
                    (
                        //KRPAN GD 6,6K (GP 8/9/10 S)
                        new { KrpanCraneId = 1, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 1, KrpanCraneControlsId = 2 },

                        //KRPAN GD 7,4K (GP 11/13/15 D GP 12/14 DF)
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 12 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 13 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 11 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 14 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 15 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 16 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 17 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 18 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 19 },
                        new { KrpanCraneId = 2, KrpanCraneControlsId = 20 },

                        //KRPAN GD 7,6K (GP 8/9/10 S)
                        new { KrpanCraneId = 3, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 3, KrpanCraneControlsId = 2 },

                        //KRPAN GD 8,6 K (GP 11/13/15 D)
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 11 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 12 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 13 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 14 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 15 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 16 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 17 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 18 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 19 },
                        new { KrpanCraneId = 4, KrpanCraneControlsId = 20 },

                        //KRPAN GD 7,2 Z
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 11 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 12 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 13 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 14 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 15 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 16 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 17 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 18 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 19 },
                        new { KrpanCraneId = 5, KrpanCraneControlsId = 20 },

                        //KRPAN GD 8,4 Z
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 11 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 12 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 13 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 14 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 15 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 16 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 17 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 18 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 19 },
                        new { KrpanCraneId = 6, KrpanCraneControlsId = 20 },

                        //KRPAN GD 5,6K
                        new { KrpanCraneId = 7, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 7, KrpanCraneControlsId = 2 },

                        //KRPAN GD 6,2K
                        new { KrpanCraneId = 8, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 8, KrpanCraneControlsId = 2 },

                        // KRPAN GD 6,6K(GP 8 / 9 / 10 DF)
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 2 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 3 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 4 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 5 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 6 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 7 },
                        new { KrpanCraneId = 9, KrpanCraneControlsId = 8 },

                        // KRPAN GD 6,6K(GP 11 D)
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 2 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 3 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 4 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 9 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 10 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 7 },
                        new { KrpanCraneId = 10, KrpanCraneControlsId = 8 },

                        // KRPAN GD 7,6K(GP 8 / 9 / 10 DF)
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 2 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 3 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 4 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 5 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 6 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 7 },
                        new { KrpanCraneId = 11, KrpanCraneControlsId = 8 },

                        // KRPAN GD 7,6K(GP 11 D)
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 1 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 2 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 3 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 4 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 9 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 10 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 7 },
                        new { KrpanCraneId = 12, KrpanCraneControlsId = 8 }
                    )
                );
        }
    }
}
