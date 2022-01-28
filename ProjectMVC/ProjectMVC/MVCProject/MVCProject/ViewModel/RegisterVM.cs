using System.ComponentModel.DataAnnotations;

namespace MVCProject.ViewModel
{
    public class RegisterVM
    {
        [Required]
        [Display(Name = "User Name")]
        [RegularExpression(pattern: @"[a-zA-z]{3,}", ErrorMessage = "your name must be more than 3 char")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
