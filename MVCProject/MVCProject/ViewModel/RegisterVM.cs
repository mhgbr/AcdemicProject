using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MVCProject.ViewModel
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "User Name")]
        [RegularExpression(pattern: @"[a-zA-z]{3,}", ErrorMessage = "your name must be more than 3 char")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "Exsist", controller: "Account",
            ErrorMessage = "this email already exsist")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm not matched")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
