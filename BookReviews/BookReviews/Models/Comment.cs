using System;
namespace BookReviews.Models
{
<<<<<<< HEAD
    public class Comment
    {
        public int CommentId { get; set; }
        public String CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public AppUser Commenter { get; set; }
        public int ReviewId { get; set; }  // FK to cause cascade delete
    }
=======
	public class Comment
	{
		public int CommentId {get; set;}
        public string CommentText { get; set; }
		public DateTime CommentDate { get; set; }
		public AppUser Commenter { get; set; }
	}
>>>>>>> 7-MoreComplexDomain
}

