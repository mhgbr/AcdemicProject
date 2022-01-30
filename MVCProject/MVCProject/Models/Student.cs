using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Student
    {
        public int Id { get; set; }


        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "Name Is Required")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}",
            ErrorMessage = "name must be char only and more than 2 char")]
        [Remote(controller: "Student", action: "Exisit",
            AdditionalFields = "Id", ErrorMessage = "this name is already exsist")]
        public string Name { get; set; }

        [Range(minimum: 20, maximum: 80)]
        public int Age { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        //[RegularExpression(pattern: "^01[0125][0-9]{8}$", ErrorMessage = "Invalid Number")]
        public int PhoneNumber { get; set; }

        [ForeignKey("Track")]
        public int Track_Id { get; set; }
        public Track Track { get; set; }

        [ForeignKey("Instructor")]
        public int? Inst_Id { get; set; }
        public Instructor Instructor { get; set; }

    }
}
