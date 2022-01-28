using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Instructor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "name is required")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}", ErrorMessage = "name must be more than two char")]
        public string Name { get; set; }

        [Required(ErrorMessage = "age is required")]
        [Range(minimum: 26, maximum: 70, ErrorMessage = "age must be between range 26 and 70")]
        public int Age { get; set; }

        [Required(ErrorMessage = "address is required")]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required(ErrorMessage = "salary is required")]
        [Range(minimum: 3000, maximum: 7000, ErrorMessage = "salary must be between range 3000 and 7000")]
        public int Salary { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public int Password { get; set; }

        [ForeignKey("Track")]
        public int Track_Id { get; set; }
        public Track Track { get; set; }

    }
}
