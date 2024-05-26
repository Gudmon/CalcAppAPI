using CalcAppAPI.Models.Machine.Configurations.Palms.Cranes;
using CalcAppAPI.Models.Machine.Palms.Trailers;
using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models.Machine.Configurations.Palms.Trailers
{
    public class TrailerFrameTypeConfiguration
    {
        [Key]
        public int Id { get; set; }

        public int TrailerId { get; set; }
        public Trailer Trailer { get; set; }

        public int FrameTypeId { get; set; }
        public FrameType FrameType { get; set; }
    }
}
