using System.ComponentModel.DataAnnotations;

namespace CalcAppAPI.Models
{
    public class Machine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
