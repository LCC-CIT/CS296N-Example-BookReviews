using System;
namespace BookReviews.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public String CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public AppUser Commenter { get; set; }

    }
}

