using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCProject.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Remote(action: "IsExist", controller: "Course", ErrorMessage = "Course Name is already exists", AdditionalFields = "Id")]
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(pattern: "^[a-zA-Z]{1,30}$", ErrorMessage = "Course Name must be between 1 and 30 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        [Range(minimum: 20, maximum: 200, ErrorMessage = "Duration must be between 20 and 200")]
        public int Duration { get; set; }

        [ForeignKey("Track")]
        public int TrackId { get; set; }
        public Track Track { get; set; }
    }
}
