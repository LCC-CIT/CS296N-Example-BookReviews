using BookReviews.Controllers;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Collections.Generic;
using System.Linq;
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
            // Test to see if names of all authors are returned without duplicates 

            // Arrange
            var fakeRepo = new FakeReviewRepository();
            
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { AuthorName = "Author 1" };
            fakeRepo.AddReviewAsync(review1);
            fakeRepo.AddReviewAsync(review1);
            var review2 = new Review() { AuthorName = "Author 2" };
            fakeRepo.AddReviewAsync(review2);
            fakeRepo.AddReviewAsync(review2);
            var review3 = new Review() { AuthorName = "Author 3" };
            fakeRepo.AddReviewAsync(review3);
            fakeRepo.AddReviewAsync(review3);
            
            // Act
            var controller = new AuthorController(fakeRepo);
            var viewResult = (ViewResult)controller.Index().Result; // ViewResult is the type of ActionResult that is returned by the View() method in the controller

            // Assert
            var names = (List<string>)viewResult.ViewData.Model;
            Assert.Equal(3, names.Count);
            Assert.Equal(names[0], review1.AuthorName);
            Assert.Equal(names[1], review2.AuthorName);
            Assert.Equal(names[2], review3.AuthorName);
        }

        /*
        public static async IAsyncEnumerable<Review> GetReviews()
        {
            yield return "foo";
            yield return "bar";
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { AuthorName = "Author 1" };
            yield return review1;
            yield return review1;
            var review2 = new Review() { AuthorName = "Author 2" };
            yield return review2;
            yield return review2;
            var review3 = new Review() { AuthorName = "Author 3" };
            yield return review3;
            yield return review3;

            await Task.CompletedTask; // to make the compiler warning go away
        }
        */
    }
}

