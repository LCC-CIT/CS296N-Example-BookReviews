using System;
namespace BookReviews.Models
{
	public class Comment
	{
		public int CommentId {get; set;}
        public string CommentText { get; set; }
		public DateTime CommentDate { get; set; }
		public AppUser Commenter { get; set; }
	}
}

