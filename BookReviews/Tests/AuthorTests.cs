using BookReviews.Controllers;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class AuthorTests
    {
        [Fact]
        // Test when the user gives all the right answers
        public void RightAnswerTest()
        {
            // Arrange
            var quiz = new QuizVM()
            {
                UserAnswer1 = "Victor Hugo",
                UserAnswer2 = "1812",
                UserAnswer3 = "false"
            };

            // Act
            quiz.CheckAnswers();

            // Assert
            Assert.True("Right" == quiz.RightOrWrong1 &&
                "Right" == quiz.RightOrWrong2 && "Right" == quiz.RightOrWrong3);
        }

        // Test when the user gives all wrong answers
        [Fact]
        public void WrongAnswerTest()
        {
            // Arrange
            var quiz = new QuizVM()
            {
                UserAnswer1 = "Victor Huge",
                UserAnswer2 = "",
                UserAnswer3 = "true"
            };

            // Act
            quiz.CheckAnswers();

            // Assert
            Assert.True("Wrong" == quiz.RightOrWrong1 &&
                "Wrong" == quiz.RightOrWrong2 && "Wrong" == quiz.RightOrWrong3);
        }

        [Fact]
        public void IndexTest()
        {
            /* Test to see if names of all authors are returned without duplicates */

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            var controller = new AuthorController(fakeRepo);
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { AuthorName = "Author 1" };
            fakeRepo.AddReview(review1);
            fakeRepo.AddReview(review1);
            var review2 = new Review() { AuthorName = "Author 2" };
            fakeRepo.AddReview(review2);
            fakeRepo.AddReview(review2);
            var review3 = new Review() { AuthorName = "Author 3" };
            fakeRepo.AddReview(review3);
            fakeRepo.AddReview(review3);
            // Act
            var viewResult = (ViewResult)controller.Index();
            // ViewResult is a the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var names = (List<string>)viewResult.ViewData.Model;
            Assert.Equal(3, names.Count);
            Assert.Equal(names[0], review1.AuthorName);
            Assert.Equal(names[1], review2.AuthorName);
            Assert.Equal(names[2], review3.AuthorName);
        }
    }
}

