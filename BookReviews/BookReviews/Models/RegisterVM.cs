using System.ComponentModel.DataAnnotations;

namespace BookReviews.Models
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}