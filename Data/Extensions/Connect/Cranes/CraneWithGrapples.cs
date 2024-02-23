using CalcAppAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Cranes
{
    public static class CraneWithGrapples
    {
        public static void ConnectCranesWithGrapples(this ModelBuilder modelBuilder)
        {
            //ROTATORS
            modelBuilder.Entity<Crane>()
                .HasMany(t => t.Grapple)
                .WithMany(c => c.Crane)
                .UsingEntity(j => j.ToTable("GrappleCrane")
                    .HasData
                    (
                        //PALMS 2.42
                        new { CraneId = 1, GrappleId = 1 },
                        new { CraneId = 1, GrappleId = 2 },
                        new { CraneId = 1, GrappleId = 3 },
                        new { CraneId = 1, GrappleId = 4 },

                        //PALMS 2.54
                        new { CraneId = 2, GrappleId = 1 },
                        new { CraneId = 2, GrappleId = 2 },
                        new { CraneId = 2, GrappleId = 3 },
                        new { CraneId = 2, GrappleId = 4 },

                        //PALMS 3.61
                        new { CraneId = 3, GrappleId = 1 },
                        new { CraneId = 3, GrappleId = 2 },
                        new { CraneId = 3, GrappleId = 3 },
                        new { CraneId = 3, GrappleId = 4 }
                    )
                );
        }
    }
}
