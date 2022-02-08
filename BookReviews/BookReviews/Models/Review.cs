﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookReviews.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required(ErrorMessage = "Author is required")]
        [StringLength(100, MinimumLength = 3)]
        public string AuthorName { get; set; }
        public AppUser Reviewer { get; set; }
        [Required]
        public string ReviewText { get; set; }
        public DateTime ReviewDate { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
