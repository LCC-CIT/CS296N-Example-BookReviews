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
            if(ModelState.IsValid)
            {
                model.ReviewDate = DateTime.Today;
                // Get the AppUser object for the current user
                model.Reviewer = await userManager.GetUserAsync(User);
                await repo.AddReviewAsync(model);
            }
            return RedirectToAction("FilterReviews", new {bookTitle = model.BookTitle, reviewerName = model.Reviewer.Name});
        }

        // TODO: Can we eliminate this method. Can we make FilterReviews the Index method?
        public async Task<IActionResult> Index()
        {
            // Get all reviews in the database
            List<Review> reviews = await repo.Reviews.ToListAsync<Review>(); // Use ToList to convert the IQueryable to a list
            return View(reviews);
        }

        public IQueryable<Review> TitleQuery(IQueryable<Review> reviews, string bookTitle)
        {
            return (IQueryable<Review>)reviews
                .Where(r => r.BookTitle == bookTitle)
                .Select(r => r);
        }

        public IQueryable<Review> ReviewerQuery(IQueryable<Review> reviews, string reviewerName)
        {
            return (IQueryable<Review>)reviews
                .Where(r => r.Reviewer.Name == reviewerName)
                .Select(r => r);
        }

        public async Task<IActionResult> FilterReviews(string bookTitle, string reviewerName)
        {
            List<Review> reviews = null;

            if (bookTitle != null)
            {
               reviews = await TitleQuery(repo.Reviews, bookTitle).ToListAsync();
            }
            else if (reviewerName != null)
            {
                reviews = await ReviewerQuery(repo.Reviews, reviewerName).ToListAsync();
            }
            return View("Index", reviews);
        }
    }
};
