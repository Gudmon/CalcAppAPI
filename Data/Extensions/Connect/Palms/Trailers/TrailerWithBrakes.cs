using CalcAppAPI.Models.Machine.Configurations.JoinEntities.Trailers;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Trailers;
using Microsoft.EntityFrameworkCore;

namespace CalcAppAPI.Data.Extensions.Connect.Palms.Trailers
{
    public static class TrailerWithBrakes
    {
        public static void ConnectTrailersWithBrakes(this ModelBuilder modelBuilder)
        {
            modelBuilder.ConnectMachineOptionManyToMany<
             Trailer,
             Brake,
             TrailerBrakeJoinEntity>(
             machineNavigation: t => t.Brake,
             optionNavigation: b => b.Trailer,
             compositeKeyExpression: x => new { x.TrailerId, x.BrakeId },
             joinToMachine: x => x.Trailer,
             joinToOption: x => x.Brake,
             machineFk: x => x.TrailerId,
             optionFk: x => x.BrakeId,
             seedData: new[]
             {
                //PALMS 6S
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 2 },
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 3 },
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 4 },
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 5 },
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 6 },
                new TrailerBrakeJoinEntity { TrailerId = 1, BrakeId = 7 },

                //PALMS 8SX
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 2 },
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 3 },
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 4 },
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 5 },
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 6 },
                new TrailerBrakeJoinEntity { TrailerId = 2, BrakeId = 7 },


                //PALMS 8D
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 2 },
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 3 },
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 4 },
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 5 },
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 8 },
                new TrailerBrakeJoinEntity { TrailerId = 3, BrakeId = 9 },

                //PALMS 9SC
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 2 },
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 3 },
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 4 },
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 5 },
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 6 },
                new TrailerBrakeJoinEntity { TrailerId = 4, BrakeId = 7 },
                
                //PALMS 10D
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 2 },
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 3 },
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 4 },
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 5 },
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 8 },
                new TrailerBrakeJoinEntity { TrailerId = 5, BrakeId = 9 },

                //PALMS 12D
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 10 },
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 11 },
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 12 },
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 13 },
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 14 },
                new TrailerBrakeJoinEntity { TrailerId = 6, BrakeId = 15 },

                //PALMS 14D
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 10 },
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 11 },
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 12 },
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 13 },
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 14 },
                new TrailerBrakeJoinEntity { TrailerId = 7, BrakeId = 15 },

                 //PALMS 10UX
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 2 },
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 3 },
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 4 },
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 5 },
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 8 },
                new TrailerBrakeJoinEntity { TrailerId = 8, BrakeId = 9 },

                //PALMS 12U
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 10 },
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 11 },
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 12 },
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 13 },
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 14 },
                new TrailerBrakeJoinEntity { TrailerId = 9, BrakeId = 15 },

                //PALMS 12UAWD
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 16 },
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 17 },
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 18 },
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 19 },
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 20 },
                new TrailerBrakeJoinEntity { TrailerId = 10, BrakeId = 21 },

                //PALMS 15U
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 10 },
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 11 },
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 12 },
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 13 },
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 14 },
                new TrailerBrakeJoinEntity { TrailerId = 11, BrakeId = 15 },

                //PALMS 15UAWD
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 16 },
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 17 },
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 18 },
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 19 },
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 20 },
                new TrailerBrakeJoinEntity { TrailerId = 12, BrakeId = 21 },

                //PALMS MWD3.2
                new TrailerBrakeJoinEntity { TrailerId = 13, BrakeId = 23 },
                new TrailerBrakeJoinEntity { TrailerId = 13, BrakeId = 24 },

                //PALMS HMWD3.2
                new TrailerBrakeJoinEntity { TrailerId = 14, BrakeId = 23 },
                new TrailerBrakeJoinEntity { TrailerId = 14, BrakeId = 24 },

                //PALMS 11UX
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 1 },
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 10 },
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 11 },
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 12 },
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 13 },
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 14 },
                new TrailerBrakeJoinEntity { TrailerId = 16, BrakeId = 15 },
            });
        }
    }
}
