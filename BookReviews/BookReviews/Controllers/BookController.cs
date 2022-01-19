﻿using System;
using System.Collections.Generic;
using System.Linq;
using BookReviews.Models;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;

namespace BookReviews.Controllers
{
    public class BookController : Controller
    {
        IReviewRepository repo;

        public BookController(IReviewRepository r)
        {
            repo = r;
        }

        /// <summary>
        /// List all books (without duplicates)
        /// </summary>
        public IActionResult Index()
        {
            List<string> titles = repo.Reviews
                .Select(review => review.BookTitle)
                .Distinct()
                .ToList();

            return View(titles);
            /* Note: .GroupBy is not supported by EF Core 3.1 so this doesn't work:
                List<Review> reviews = repo.Reviews
                    .GroupBy(review => review.BookTitle)
                    .Select(group => group.FirstOrDefault())
                    .ToList();
            */
        }

        // Show the view that has a form for entering a review
        public IActionResult Review()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Review(Review model)
        {
            model.ReviewDate = DateTime.Now;
            // Store the model in the database if it is valid
            if(ModelState.IsValid)
            { 
                repo.AddReview(model);
            }
            return RedirectToAction("Reviews");
            // TODO: figure out how to send bookTitle and reviewerName to the Reviews method
            // So that only the review just entered is filtered and shown. 
            // return RedirectToAction("Reviews", new {bookTitle = model.BookTitle, reviewerName = model.Reviewer.Name});
        }

        public IActionResult Reviews()
        {
            // Get all reviews in the database
            List<Review> reviews = repo.Reviews.ToList<Review>(); // Use ToList to convert the IQueryable to a list
            return View(reviews);
        }

        [HttpPost]
        public IActionResult Reviews(string bookTitle, string reviewerName)
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
            return View(reviews);
        }
    }
};
