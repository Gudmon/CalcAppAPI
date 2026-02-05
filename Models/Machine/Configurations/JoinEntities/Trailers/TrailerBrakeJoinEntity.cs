using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;
using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.JoinEntities.Trailers
{
    public class TrailerBrakeJoinEntity
    {
        public int TrailerId { get; set; }
        public Trailer Trailer { get; set; } = null!;

        public int BrakeId { get; set; }
        public Brake Brake { get; set; } = null!;
    }
}
