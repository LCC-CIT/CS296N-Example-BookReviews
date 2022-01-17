using System;
using System.ComponentModel.DataAnnotations;

namespace BookReviews.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        [Required]
        public string BookTitle { get; set; }
        public string AuthorName { get; set; }
        public User Reviewer { get; set; }
        [StringLength(500, MinimumLength = 10)]
        [Required]
        public string ReviewText { get; set; }
        [Range(1,5)]
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
