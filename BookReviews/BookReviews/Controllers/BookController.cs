using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReviews.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Index()
        {
            List<string> titles = await repo.Reviews
                .Select(review => review.BookTitle)
                .Distinct()
                .ToListAsync();

            return View(titles);
            // TODO: Upgrade to .netcore 6.0 so that the query below can be used.
            //       I think the query below will operate more efficiently in the database
            /* Note: .GroupBy is not supported by EF Core 3.1 so this doesn't work:
                List<Review> reviews = repo.Reviews
                    .GroupBy(review => review.BookTitle)
                    .Select(group => group.FirstOrDefault())
                    .ToList();
            */
        }
    }
};
