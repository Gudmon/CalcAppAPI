using CalcAppAPI.Models.Machine.Configurations.Common;
using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Configurations.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Cranes
{
    public class Shipping : MachineOption
    {
        public IEnumerable<Crane> Cranes { get; set; } = Enumerable.Empty<Crane>();
        public IEnumerable<Trailer> Trailers { get; set; } = Enumerable.Empty<Trailer>();
    }
}
