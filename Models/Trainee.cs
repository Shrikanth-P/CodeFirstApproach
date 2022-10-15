using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models
{
    public class Trainee
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Enter the Trainee Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "Name must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Enter the city Name")]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "City name must consist of minimum 4 characters")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string? city { get; set; }
    }
}
