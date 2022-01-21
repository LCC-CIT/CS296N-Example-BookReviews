
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BookReviews.Models
{
    public class AppUser : IdentityUser
    {
        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Name { get; set; }
    }
}
