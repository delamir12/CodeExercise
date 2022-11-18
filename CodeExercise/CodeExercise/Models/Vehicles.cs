using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeExercise.Models
{
    public class Vehicles
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Vin { get; set; }
        public string? Color { get; set; }
        public string? Year { get; set; }
        [ForeignKey("Owners")]
        public int? OwnerId { get; set; }

    }
}
