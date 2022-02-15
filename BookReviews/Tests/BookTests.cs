using BookReviews.Controllers;
using BookReviews.Models;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    // Tests for the BookController
    public class BookTests
    {

        [Fact]
        public void IndexTest()
        {
            // We're only testing the query, not the controller method because all the logic is in the query.
            // Test to see if titles of all books are returned without duplicates

            // Arrange
            var reviews = new List<Review>();
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { BookTitle = "Book 1" };
            reviews.Add(review1);
            reviews.Add(review1);
            var review2 = new Review() { BookTitle = "Book 2" };
            reviews.Add(review2);
            reviews.Add(review2);
            var review3 = new Review() { BookTitle = "Book 3" };
            reviews.Add(review3);
            reviews.Add(review3);

            var controller = new BookController(null);  // I don't need a repository

            // Act
            var titles = controller.BookQuery(reviews.AsQueryable()).ToList<string>();

            // Assert
            Assert.Equal(3, titles.Count);
            Assert.Equal(titles[0], review1.BookTitle);
            Assert.Equal(titles[1], review2.BookTitle);
            Assert.Equal(titles[2], review3.BookTitle);
        }
    }
}
