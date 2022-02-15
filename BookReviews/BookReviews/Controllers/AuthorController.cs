﻿
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Controllers
{
    public class AuthorController : Controller
    {
        IReviewRepository repo;

        public AuthorController(IReviewRepository r)
        {
            repo = r;
        }

        public IQueryable<string> AuthorQuery(IQueryable<Review> reviews)
        {
            return (IQueryable<string>)reviews.Select(review => review.AuthorName)
                .Distinct();
        }

        public async Task<IActionResult> Index()
        {
            var names = await AuthorQuery(repo.Reviews)
                .ToListAsync();

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
                return View(quiz);
            }
            return RedirectToAction("Quiz");
        }

    }
}
