﻿using BookReviews.Controllers;
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
            var review1 = new Review() { BookTitle = "Book 1" };
            await fakeRepo.AddReviewAsync(review1);
            await fakeRepo.AddReviewAsync(review1);
            var review2 = new Review() { BookTitle = "Book 2" };
            await fakeRepo.AddReviewAsync(review2);
            await fakeRepo.AddReviewAsync(review2);
            var review3 = new Review() { BookTitle = "Book 3" };
            await fakeRepo.AddReviewAsync(review3);
            await fakeRepo.AddReviewAsync(review3);

            // Act
            var viewResult = (ViewResult)controller.Index().Result;
            // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var titles = (List<string>)viewResult.ViewData.Model;
            Assert.Equal(3, titles.Count);
            Assert.Contains<string>(review1.BookTitle, titles);
            Assert.Contains<string>(review2.BookTitle, titles);
            Assert.Contains<string>(review3.BookTitle, titles);
        }
    }
    
}
