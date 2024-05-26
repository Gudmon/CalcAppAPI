using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithStanchions
    {
        public static void ConnectTrailersWithStanchions(this ModelBuilder modelBuilder)
        {
            // STANCHIONS
            modelBuilder.Entity<Trailer>()
                .HasMany(t => t.Stanchion)
                .WithMany(c => c.Trailer)
                .UsingEntity(j => j.ToTable("StanchionTrailer")
                    .HasData
                    (
                        //PALMS 6S
                        new { TrailerId = 1, StanchionId = 1 },
                        new { TrailerId = 1, StanchionId = 2 },

                        //PALMS 8SX
                        new { TrailerId = 2, StanchionId = 3 },
                        new { TrailerId = 2, StanchionId = 4 },
                        new { TrailerId = 2, StanchionId = 5 },
                        new { TrailerId = 2, StanchionId = 6 },

                        //PALMS 8D
                        new { TrailerId = 3, StanchionId = 7 },
                        new { TrailerId = 3, StanchionId = 8 },
                        new { TrailerId = 3, StanchionId = 9 },
                        new { TrailerId = 3, StanchionId = 10 },

                        //PALMS 8DWD
                        new { TrailerId = 4, StanchionId = 11 },
                        new { TrailerId = 4, StanchionId = 12 },
                        new { TrailerId = 4, StanchionId = 13 },
                        new { TrailerId = 4, StanchionId = 14 },

                        //PALMS 9SC
                        new { TrailerId = 5, StanchionId = 15 },
                        new { TrailerId = 5, StanchionId = 16 },
                        new { TrailerId = 5, StanchionId = 17 },
                        new { TrailerId = 5, StanchionId = 18 },

                        //PALMS 10D
                        new { TrailerId = 6, StanchionId = 19 },
                        new { TrailerId = 6, StanchionId = 20 },
                        new { TrailerId = 6, StanchionId = 21 },
                        new { TrailerId = 6, StanchionId = 22 },

                        //PALMS 10DWD
                        new { TrailerId = 7, StanchionId = 23 },
                        new { TrailerId = 7, StanchionId = 24 },
                        new { TrailerId = 7, StanchionId = 25 },
                        new { TrailerId = 7, StanchionId = 26 },

                        //PALMS 12D
                        new { TrailerId = 8, StanchionId = 27 },
                        new { TrailerId = 8, StanchionId = 28 },
                        new { TrailerId = 8, StanchionId = 29 },
                        new { TrailerId = 8, StanchionId = 30 },

                        //PALMS 12DWD
                        new { TrailerId = 9, StanchionId = 31 },
                        new { TrailerId = 9, StanchionId = 32 },
                        new { TrailerId = 9, StanchionId = 33 },
                        new { TrailerId = 9, StanchionId = 34 },

                        //PALMS 14D
                        new { TrailerId = 10, StanchionId = 35 },
                        new { TrailerId = 10, StanchionId = 36 },
                        new { TrailerId = 10, StanchionId = 37 },
                        new { TrailerId = 10, StanchionId = 38 },

                        //PALMS 14DWD
                        new { TrailerId = 11, StanchionId = 39 },
                        new { TrailerId = 11, StanchionId = 40 },
                        new { TrailerId = 11, StanchionId = 41 },
                        new { TrailerId = 11, StanchionId = 42 },

                        //PALMS 10U
                        new { TrailerId = 12, StanchionId = 43 },
                        new { TrailerId = 12, StanchionId = 44 },
                        new { TrailerId = 12, StanchionId = 45 },
                        new { TrailerId = 12, StanchionId = 46 },
                        new { TrailerId = 12, StanchionId = 47 },
                        new { TrailerId = 12, StanchionId = 48 },
                        new { TrailerId = 12, StanchionId = 49 },
                        new { TrailerId = 12, StanchionId = 50 },

                        //PALMS 10UWD
                        new { TrailerId = 13, StanchionId = 51 },
                        new { TrailerId = 13, StanchionId = 52 },
                        new { TrailerId = 13, StanchionId = 53 },
                        new { TrailerId = 13, StanchionId = 54 },
                        new { TrailerId = 13, StanchionId = 55 },
                        new { TrailerId = 13, StanchionId = 56 },
                        new { TrailerId = 13, StanchionId = 57 },
                        new { TrailerId = 13, StanchionId = 58 },

                        //PALMS 12U
                        new { TrailerId = 14, StanchionId = 59 },
                        new { TrailerId = 14, StanchionId = 60 },
                        new { TrailerId = 14, StanchionId = 61 },
                        new { TrailerId = 14, StanchionId = 62 },
                        new { TrailerId = 14, StanchionId = 63 },
                        new { TrailerId = 14, StanchionId = 64 },
                        new { TrailerId = 14, StanchionId = 65 },
                        new { TrailerId = 14, StanchionId = 66 },

                        //PALMS 12UWD
                        new { TrailerId = 15, StanchionId = 67 },
                        new { TrailerId = 15, StanchionId = 68 },
                        new { TrailerId = 15, StanchionId = 69 },
                        new { TrailerId = 15, StanchionId = 70 },
                        new { TrailerId = 15, StanchionId = 71 },
                        new { TrailerId = 15, StanchionId = 72 },
                        new { TrailerId = 15, StanchionId = 73 },
                        new { TrailerId = 15, StanchionId = 74 },

                        //PALMS 12UAWD
                        new { TrailerId = 16, StanchionId = 75 },
                        new { TrailerId = 16, StanchionId = 76 },
                        new { TrailerId = 16, StanchionId = 77 },
                        new { TrailerId = 16, StanchionId = 78 },
                        new { TrailerId = 16, StanchionId = 79 },
                        new { TrailerId = 16, StanchionId = 80 },
                        new { TrailerId = 16, StanchionId = 81 },
                        new { TrailerId = 16, StanchionId = 82 },

                        //PALMS 15U
                        new { TrailerId = 17, StanchionId = 83 },
                        new { TrailerId = 17, StanchionId = 84 },
                        new { TrailerId = 17, StanchionId = 85 },
                        new { TrailerId = 17, StanchionId = 86 },
                        new { TrailerId = 17, StanchionId = 87 },
                        new { TrailerId = 17, StanchionId = 88 },
                        new { TrailerId = 17, StanchionId = 89 },
                        new { TrailerId = 17, StanchionId = 90 },

                        //PALMS 15UWD
                        new { TrailerId = 18, StanchionId = 91 },
                        new { TrailerId = 18, StanchionId = 92 },
                        new { TrailerId = 18, StanchionId = 93 },
                        new { TrailerId = 18, StanchionId = 94 },
                        new { TrailerId = 18, StanchionId = 95 },
                        new { TrailerId = 18, StanchionId = 96 },
                        new { TrailerId = 18, StanchionId = 97 },
                        new { TrailerId = 18, StanchionId = 98 },

                        //PALMS 15UAWD
                        new { TrailerId = 19, StanchionId = 99 },
                        new { TrailerId = 19, StanchionId = 100 },
                        new { TrailerId = 19, StanchionId = 101 },
                        new { TrailerId = 19, StanchionId = 102 },
                        new { TrailerId = 19, StanchionId = 103 },
                        new { TrailerId = 19, StanchionId = 104 },
                        new { TrailerId = 19, StanchionId = 105 },
                        new { TrailerId = 19, StanchionId = 106 },

                        //PALMS MWD3.2
                        new { TrailerId = 20, StanchionId = 107 },
                        new { TrailerId = 20, StanchionId = 108 },
                        new { TrailerId = 20, StanchionId = 109 },
                        new { TrailerId = 20, StanchionId = 110 },

                        //PALMS HMWD3.2
                        new { TrailerId = 21, StanchionId = 115 },
                        new { TrailerId = 21, StanchionId = 116 },
                        new { TrailerId = 21, StanchionId = 117 },
                        new { TrailerId = 21, StanchionId = 118 },

                        //PALMS 2D
                        new { TrailerId = 22, StanchionId = 123 },
                        new { TrailerId = 22, StanchionId = 124 },
                        new { TrailerId = 22, StanchionId = 125 }
                    )
                );
        }
    }
}
