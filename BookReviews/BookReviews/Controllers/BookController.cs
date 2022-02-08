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
    public class BookController : Controller
    {
        IReviewRepository repo;
        UserManager<AppUser> userManager;

        public BookController(IReviewRepository r, UserManager<AppUser> u)
        {
            repo = r;
            userManager = u;
        }


        public async Task<IActionResult> Index()
        {
            
            return View();
        }

        // Show the view that contains a form for entering a review
        [Authorize]
        public async Task<IActionResult> Review()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Review(Review model)
        {
            model.Reviewer = await userManager.GetUserAsync(User);
            // TODO: get the user's real name in registration
            model.Reviewer.Name = model.Reviewer.UserName;  // temporary hack
            model.ReviewDate = DateTime.Now;
            // Store the model in the database
            await repo.AddReviewAsync(model);

            return View(model);
        }

        public async Task<IActionResult> Reviews()
        {
            // Get all reviews in the database
            List<Review> reviews = await repo.Reviews.ToListAsync<Review>(); // Use ToList to convert the IQueryable to a list
            return View(reviews);
        }

        [HttpPost]
        public async Task<IActionResult> Reviews(string bookTitle, string reviewerName)
        {
            List<Review> reviews = null;

            if (bookTitle != null)
            {
               reviews = await (from r in repo.Reviews
                               where r.BookTitle == bookTitle
                               select r).ToListAsync();
            }
            else if (reviewerName != null)
            {
                reviews = await (from r in repo.Reviews
                           where r.Reviewer.Name == reviewerName
                           select r).ToListAsync();
            }

            return View(reviews);
        }

        // Open the form for entering a comment
        [Authorize]
        public IActionResult Comment(int reviewId)
        {
            var commentVM = new CommentVM { ReviewID = reviewId };
            return View(commentVM);
        }

        [HttpPost]
        [Authorize]
        public async Task<RedirectToActionResult> Comment(CommentVM commentVM)
        {
            // Comment is the domain model
            var comment = new Comment { CommentText = commentVM.CommentText };
            comment.Commenter = await userManager.GetUserAsync(User);
            comment.CommentDate = DateTime.Now;

            // Retrieve the review that this comment is for
            var review = await (from r in repo.Reviews
                          where r.ReviewID == commentVM.ReviewID
                          select r).FirstAsync<Review>();

            review.Comments.Add(comment);

            // Store the review with the comment in the database
            await repo.UpdateReviewAsync(review);

            return RedirectToAction("Reviews");
        }

    }
};
