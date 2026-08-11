using System.ComponentModel.DataAnnotations;

namespace Core_Project.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter your surname.")]
        public string? Surname { get; set; }
        [Required(ErrorMessage = "Please enter your Image URL.")]
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage = "Please enter your username.")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Please re-enter your password.")]
        [Compare("Password", ErrorMessage = "Passwords are not compatible.")]
        public string? ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter your mail.")]
        public string? Mail { get; set; }
    }
}
