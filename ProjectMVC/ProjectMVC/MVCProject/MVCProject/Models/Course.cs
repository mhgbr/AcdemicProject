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
        [RegularExpression(pattern: "^[a-zA-Z]{3,30}$", ErrorMessage = "Course Name must be between 3 and 30 letters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Duration is required")]
        [Range(minimum: 50, maximum: 200, ErrorMessage = "Duration must be between 0 and 100")]
        public int Duration { get; set; }

        [ForeignKey("Track")]
        public int TrackId { get; set; }
        public Track Track { get; set; }
    }
}
