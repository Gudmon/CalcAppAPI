using CalcAppAPI.Models.Machine.Configurations.Common;
using CalcAppAPI.Models.Machine.Palms.Cranes;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public abstract class CraneOption : MachineOption
    {
        public IEnumerable<Crane> Crane { get; set; } = Enumerable.Empty<Crane>();
    }
}
