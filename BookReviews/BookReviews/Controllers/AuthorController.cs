
using System.Collections.Generic;
using System.Linq;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;

namespace BookReviews.Controllers
{
    public class AuthorController : Controller
    {
        IReviewRepository repo;

        public AuthorController(IReviewRepository r)
        {
            repo = r;
        }

        public IActionResult Index()
        {
            List<string> names = repo.Reviews
                .Select(review => review.Book.Author.Name)
                .Distinct()
                .ToList();

            return View(names);
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Quiz(QuizVM quiz)
        {
            if (ModelState.IsValid)
            {
                quiz.CheckAnswers();
            }
            return View(quiz);
        }

    }
}
