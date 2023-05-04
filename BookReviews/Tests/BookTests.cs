using BookReviews.Controllers;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{

    // Tests for the BookController
    [Collection("All Tests")]
    public class BookTests
    {
        [Fact]
        public async Task IndexTest()
        {
            // Test to see if titles of all books are returned without duplicates

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            var controller = new BookController(fakeRepo);
            // We don't need need to add all the properties to the models since we aren't testing that.
<<<<<<< HEAD
            var review1 = new Review() { BookTitle = "Book 1" };
            await fakeRepo.AddReviewAsync(review1);
            await fakeRepo.AddReviewAsync(review1);
            var review2 = new Review() { BookTitle = "Book 2" };
            await fakeRepo.AddReviewAsync(review2);
            await fakeRepo.AddReviewAsync(review2);
            var review3 = new Review() { BookTitle = "Book 3" };
            await fakeRepo.AddReviewAsync(review3);
            await fakeRepo.AddReviewAsync(review3);

=======
            var review1 = new Review() { Book = new Book { Title = "Book 1" } };
            fakeRepo.AddReview(review1);
            fakeRepo.AddReview(review1);
            var review2 = new Review() { Book = new Book { Title = "Book 2" } };
            fakeRepo.AddReview(review2);
            fakeRepo.AddReview(review2);
            var review3 = new Review() { Book = new Book { Title = "Book 3" } };
            fakeRepo.AddReview(review3);
            fakeRepo.AddReview(review3);
>>>>>>> 7-MoreComplexDomain
            // Act
            var viewResult = (ViewResult)controller.Index().Result;
            // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var titles = (List<string>)viewResult.ViewData.Model;
            Assert.Equal(3, titles.Count);
<<<<<<< HEAD
            Assert.Contains<string>(review1.BookTitle, titles);
            Assert.Contains<string>(review2.BookTitle, titles);
            Assert.Contains<string>(review3.BookTitle, titles);
=======
            Assert.Equal(titles[0], review1.Book.Title);
            Assert.Equal(titles[1], review2.Book.Title);
            Assert.Equal(titles[2], review3.Book.Title);
>>>>>>> 7-MoreComplexDomain
        }
    }
    
}
