using System;
namespace BookReviews.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public String CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public virtual AppUser Commenter { get; set; }
        public int ReviewId { get; set; }  // FK to cause cascade delete
    }
}

