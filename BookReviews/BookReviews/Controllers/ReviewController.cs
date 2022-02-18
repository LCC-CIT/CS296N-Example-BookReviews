using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [Authorize]
        public IActionResult Review()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Review(Review model)
        {
            // Store the model in the database if it is valid
            if (ModelState.IsValid)
            {
                model.ReviewDate = DateTime.Today;
                // Get the AppUser object for the current user
                model.Reviewer = await userManager.GetUserAsync(User);
                await repo.AddReviewAsync(model);
            }
            return RedirectToAction("FilterReviews", new { bookTitle = model.BookTitle, reviewerName = model.Reviewer.Name });
        }

        // TODO: Can we eliminate this method. Can we make FilterReviews the Index method?
        public async Task<IActionResult> Index()
        {
            // Get all reviews in the database
            List<Review> reviews = await repo.Reviews.ToListAsync<Review>(); // Use ToList to convert the IQueryable to a list
            return View(reviews);
        }

        public async Task<IActionResult> FilterReviews(string bookTitle, string reviewerName)
        {
            List<Review> reviews = null;

            // We can filter by title, reviewer, or both
            if (!string.IsNullOrEmpty(bookTitle))
            {
                await Task.Run(() =>
                    reviews = (from r in repo.Reviews
                                   where r.BookTitle == bookTitle
                                   select r).ToList()
                    );
            }
            if (!string.IsNullOrEmpty(reviewerName))
            {
                await Task.Run(() =>
                    reviews = (from r in repo.Reviews
                               where r.Reviewer.Name == reviewerName
                               select r).ToList()
                 );
            }
            return View("Index", reviews);
            // TODO: Do A/B load tests to see if using .ToListAsync() gives better performance than Task.Run() and .ToList()
        }
    }
};
