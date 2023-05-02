using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookReviews.Models;
using BookReviews.Repos;
using System.Linq;

namespace BookReviews.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IReviewRepository repo;

        public HomeController(ILogger<HomeController> logger, IReviewRepository r)
        {
            _logger = logger;
            repo = r;
        }

        public IActionResult Index()
        {
            // Get a random book to display on the home page
            int reviewCount = repo.Reviews.Count();
            var random = new Random();
            var skipCount = random.Next(reviewCount);
            var review = repo.Reviews.Skip(skipCount).FirstOrDefault();

            // Get the number of reviews for the book and average rating
            var reviews = repo.Reviews.Where(r => r.Book.Title == review.Book.Title).ToList();
            ViewBag.reviewCount = reviews.Count();
            ViewBag.averageRating = reviews.Average(r => r.Rating);

            return View(review);
        }

        /*
            // Find the most popular book.
            // That is the book with the most reviews
            // Note in EF core 3.1 groupby doesn't work, but it does in 6.0. So change this whey you upgrade.
            var mostPopular = repo.Reviews
                .ToList()  // We have to do this first to use GroupBy
                .GroupBy(r => r.BookTitle, r => r)
                .Select(g => new { Title = g.Key, Count = g.Count(), AvgRating = g.Average(r => r.Rating) })
                .Cast<object>()
                .OrderbyDescending(x => x.AvgRating)
                .FirstOrDefault();
                // This isn't working
        */

        public IActionResult Recommended()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
