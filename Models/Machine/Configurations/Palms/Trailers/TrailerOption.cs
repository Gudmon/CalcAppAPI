using CalcAppAPI.Models.Machine.Configurations.Common;
using CalcAppAPI.Models.Machine.Palms.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
{
    public abstract class TrailerOption: MachineOption
    {
        public ICollection<Trailer> Trailer { get; set; } = new List<Trailer>();
    }
}
