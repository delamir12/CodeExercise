using System.ComponentModel.DataAnnotations;
namespace CodeExercise.Models
{
    public class Owners
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DriverLicence { get; set; }

    }
}
