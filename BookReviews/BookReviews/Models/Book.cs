using System;
namespace BookReviews.Models
{
	public class Book
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public DateTime PrintDate { get; set; }
		public Writer Author { get; set; }
	}
}

