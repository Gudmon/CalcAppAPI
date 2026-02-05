using CalcAppAPI.Models.Machine.Configurations.Common;

namespace CalcAppAPI.Data.Extensions.Connect.Palms
{
    public abstract class MachineOptionLink<TMachine, TOption>
    where TMachine : class
    where TOption : MachineOption
    {
        public int MachineId { get; set; }
        public TMachine Machine { get; set; } = null!;

        public int OptionId { get; set; }
        public TOption Option { get; set; } = null!;
    }
}
