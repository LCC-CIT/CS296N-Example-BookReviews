using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookReviews.Models
{
    public class Review
    {
        // private List<Comment> _comments = new List<Comment>();
        public int ReviewId { get; set; }

        [Required]
        public string BookTitle { get; set; }

        public string AuthorName { get; set; }

        public AppUser Reviewer { get; set; }

        [StringLength(500, MinimumLength = 10)]
        [Required]
        public string ReviewText { get; set; }

        [Range(1,5)]
        public int Rating { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime ReviewDate { get; set; }
        public ICollection<Comment> Comments  { get; set; }
       
        /*
        ICollection<Comment> Comments 
        {
            get { return Comments; }
        }
       */
    }
}
