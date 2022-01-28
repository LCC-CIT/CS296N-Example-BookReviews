using BookReviews.Controllers;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    // Tests for the ReviewController
    public class ReviewTests
    {
        /* This test was broken when we started using the UserManager
         * to get the logged in user to put in AppUser.UserName
        [Fact]
        public void AddReviewTest()
        {
            // The only processing the Review method does
            //    is add a date to the model, so that's all we're testing

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            var controller = new ReviewController(fakeRepo, null);   // I'm passing a null instead of a UserManager object
            var review = new Review()
            {
                BookTitle = "A Book",
                Reviewer = new AppUser() { Name = "A Reviewer" }  // This is now done by code in the controller method using UserManager
            };
            // We only need these properties so the RedirectToAction doesn't complain
            // We aren't testing any model proeprties

            // Act
            controller.Review(review);

            // Assert

            var repoReview = fakeRepo.Reviews.ToList()[0];
            Assert.Equal(0, System.DateTime.Now.Date.CompareTo(
                repoReview.ReviewDate.Date));
        }
    */

        [Fact]
        public void FilterByTitleTest()
        {
            /* Test to see if only reviews with the selected title are returned */

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            var controller = new ReviewController(fakeRepo, null);
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
            var viewResult = (ViewResult)controller.FilterReviews(review2.BookTitle, "");
            // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var reviews = (List<Review>)viewResult.ViewData.Model;
            Assert.Equal(2, reviews.Count);
            Assert.Equal(reviews[0].BookTitle, review2.BookTitle);
            Assert.Equal(reviews[1].BookTitle, review2.BookTitle);
        }

        [Fact]
        public void FilterByReviewerTest()
        {
            /* Test to see if only reviews with the selected title are returned */

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            var controller = new ReviewController(fakeRepo, null);
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { Reviewer = new AppUser() { Name = "Reviewer 1" } };
            fakeRepo.AddReview(review1);
            fakeRepo.AddReview(review1);
            var review2 = new Review() { Reviewer = new AppUser() { Name = "Reviewer 2" } };
            fakeRepo.AddReview(review2);
            fakeRepo.AddReview(review2);
            var review3 = new Review() { Reviewer = new AppUser() { Name = "Reviewer 3" } };
            fakeRepo.AddReview(review3);
            fakeRepo.AddReview(review3);
            // Act
            var viewResult = (ViewResult)controller.FilterReviews(null, review2.Reviewer.Name);
            // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var reviews = (List<Review>)viewResult.ViewData.Model;
            Assert.Equal(2, reviews.Count);
            Assert.Equal(reviews[0].Reviewer.Name, review2.Reviewer.Name);
            Assert.Equal(reviews[1].Reviewer.Name, review2.Reviewer.Name);
        }

        // Note: The Index method is not being tested because it doesn't do any
        // processing; it just calls a method on the repository.
    }
}
