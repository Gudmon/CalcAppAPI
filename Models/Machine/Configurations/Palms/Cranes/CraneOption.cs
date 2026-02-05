using CalcAppAPI.Models.Machine.Configurations.Common;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Cranes
{
    public abstract class CraneOption : MachineOption
    {
        public ICollection<Crane> Crane { get; set; } = new List<Crane>();
    }
}
