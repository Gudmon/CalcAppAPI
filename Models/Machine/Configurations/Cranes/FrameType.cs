using CalcAppAPI.Models.Machine.Configurations.Trailers;

namespace CalcAppAPI.Models.Machine.Configurations.Cranes
{
    public class FrameType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mass { get; set; }
        public string Code { get; set; }
        public string Price { get; set; }
        //public bool? Available { get; set; }
        //public bool? Recommended { get; set; }
        public IEnumerable<TrailerFrameTypeConfiguration> TrailerConfigurations { get; set; }
        public IEnumerable<Crane> Crane { get; set; }
    }
}
