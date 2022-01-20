using System;
using System.Collections.Generic;
using System.Linq;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;

namespace BookReviews.Controllers
{
    public class ReviewController : Controller
    {
        IReviewRepository repo;

        public ReviewController(IReviewRepository r)
        {
            repo = r;
        }

        // Show the view that has a form for entering a review
        public IActionResult Review()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Review(Review model)
        {
            model.ReviewDate = DateTime.Today;
            // Store the model in the database if it is valid
                repo.AddReview(model);
            return RedirectToAction("FilterReviews", new {bookTitle = model.BookTitle, reviewerName = model.Reviewer.Name});
        }

        // TODO: Can we eliminate this method. Can we make FilterReviews the Index method?
        public IActionResult Index()
        {
            // Get all reviews in the database
            List<Review> reviews = repo.Reviews.ToList<Review>(); // Use ToList to convert the IQueryable to a list
            return View(reviews);
        }

        public IActionResult FilterReviews(string bookTitle, string reviewerName)
        {
            List<Review> reviews = null;

            if (bookTitle != null)
            {
               reviews = (from r in repo.Reviews
                               where r.BookTitle == bookTitle
                               select r).ToList();
            }
            else if (reviewerName != null)
            {
                reviews = (from r in repo.Reviews
                           where r.Reviewer.Name == reviewerName
                           select r).ToList();
            }
            return View("Index", reviews);
        }
    }
};
