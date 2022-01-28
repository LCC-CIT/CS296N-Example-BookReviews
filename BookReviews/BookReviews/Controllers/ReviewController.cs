using System;
using System.Collections.Generic;
using System.Linq;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookReviews.Controllers
{
    public class ReviewController : Controller
    {
        IReviewRepository repo;
        UserManager<AppUser> userManager;

        public ReviewController(IReviewRepository r, UserManager<AppUser> u)
        {
            repo = r;
            userManager = u;
        }

        // Show the view that has a form for entering a review
        public IActionResult Review()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Review(Review model)
        {
            // Store the model in the database if it is valid
            if(ModelState.IsValid)
            {
                model.ReviewDate = DateTime.Today;
                // Get the AppUser object for the current user
                model.Reviewer = userManager.GetUserAsync(User).Result;
                repo.AddReview(model);
            }
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
