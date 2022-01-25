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
            // Get a random review to display on the home page
            var maxId = repo.Reviews.Max(r => r.ReviewID);
            var random = new Random();
            var id = random.Next(maxId + 1);
            var review = repo.Reviews.Where(r => r.ReviewID == maxId).FirstOrDefault();

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
