using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models
{
    public class Track
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tarck Name")]
        [Remote(controller: "Track", action: "Exisit",
            AdditionalFields = "Id", ErrorMessage = "this name is already exsist")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Manager Name")]
        [RegularExpression(pattern: "[a-zA-Z]{3,}",
            ErrorMessage = "name must be char only and more than 2 char")]
        public string Manager { get; set; }
    }
}
