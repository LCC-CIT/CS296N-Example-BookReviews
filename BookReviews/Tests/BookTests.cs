using BookReviews.Controllers;
using BookReviews.Models;
using BookReviews.Repos;
using System.Linq;
using Xunit;

namespace Tests
{
    using BookReviews.Controllers;
    using BookReviews.Models;
    using BookReviews.Repos;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    namespace Tests
    {
        // Tests for the BookController
        public class BookTests
        {
            [Fact]
            public void AddReviewTest()
            {
                /* The only processing the Review method does
                    is add a date to the model, so that's all we're testing */

                // Arrange
                var fakeRepo = new FakeReviewRepository();
                var controller = new BookController(fakeRepo);
                var review = new Review();
                // We don't need to add any properties to the model since we aren't testing them.

                // Act
                controller.Review(review);

                // Assert

                var repoReview = fakeRepo.Reviews.ToList()[0];
                Assert.Equal(0, System.DateTime.Now.Date.CompareTo(
                    repoReview.ReviewDate.Date));
            }

            [Fact]
            public void IndexTest()
            {
                /* Test to see if all reviews are returned */

                // Arrange
                var fakeRepo = new FakeReviewRepository();
                var controller = new BookController(fakeRepo);
                // We don't need need to add all the properties to the models since we aren't testing that.
                var review1 = new Review() { BookTitle = "Book 1" };
                fakeRepo.AddReview(review1);
                fakeRepo.AddReview(review1);
                var review2 = new Review() { BookTitle = "Book 2" };
                fakeRepo.AddReview(review2);
                fakeRepo.AddReview(review2);
                var review3 = new Review() { BookTitle = "Book 3" };
                fakeRepo.AddReview(review3);
                fakeRepo.AddReview(review3);
                // Act
                var viewResult = (ViewResult)controller.Index();
                // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

                // Assert
                var titles = (List<string>)viewResult.ViewData.Model;
                Assert.Equal(3, titles.Count);
                Assert.Equal(titles[0], review1.BookTitle);
                Assert.Equal(titles[1], review2.BookTitle);
                Assert.Equal(titles[2], review3.BookTitle);
            }
        }
        // Note: The Reviews method is not being tested because it doesn't do any
        // processing; it just calls a method on the repository.
    }
}
