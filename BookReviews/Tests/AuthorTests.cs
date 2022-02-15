using BookReviews.Controllers;
using BookReviews.Models;
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
        public void AuthorQueryTest()
        {
            // I'm just testing the query, not the controller method, because the query does all the work.
            // Test to see if names of all authors are returned without duplicates 

            // Arrange
            var reviews = new List<Review>();
            // We don't need need to add all the properties to the models since we aren't testing that.
            var review1 = new Review() { AuthorName = "Author 1" };
            reviews.Add(review1);
            reviews.Add(review1);
            var review2 = new Review() { AuthorName = "Author 2" };
            reviews.Add(review2);
            reviews.Add(review2);
            var review3 = new Review() { AuthorName = "Author 3" };
            reviews.Add(review3);
            reviews.Add(review3);

            var controller = new AuthorController(null);  // I don't need a repository

            // Act
            var names = controller.AuthorQuery(reviews.AsQueryable()).ToList<string>();

            // Assert
            Assert.Equal(3, names.Count);
            Assert.Equal(names[0], review1.AuthorName);
            Assert.Equal(names[1], review2.AuthorName);
            Assert.Equal(names[2], review3.AuthorName);
        }
    }
}

