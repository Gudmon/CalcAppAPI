using CalcAppAPI.Models.Machine.Configurations.Common;
using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
{
    public abstract class TrailerOption: MachineOption
    {
        public IEnumerable<Trailer> Trailer { get; set; } = Enumerable.Empty<Trailer>();
    }
}
