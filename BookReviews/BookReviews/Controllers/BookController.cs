﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookReviews.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        // Invoke the view with form for entering a review
        public IActionResult Review()
        {
            Review model = new Review();
            User reviewer = new User();
            model.Reviewer = reviewer;
            return View(model);
        }

        [HttpPost]
        public IActionResult Review(Review model)
        {
            return View(model);
        }
    }
}
