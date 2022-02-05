using BookReviews.Data;
using BookReviews.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Repos
{
    public class ReviewRepository : IReviewRepository
    {
        private BookReviewContext context;

        // constructor
        public ReviewRepository(BookReviewContext c)
        {
            context = c;
        }

        public IQueryable<Review> Reviews 
        { 
            get 
            { 
                // Get all the Review objects in the Reviews DbSet
                // and include the related objects.
                return context.Reviews
                    .Include(r => r.Reviewer)
                    .Include(r => r.Book)
                    .ThenInclude(b => b.Author);
            }
        }

        public void AddReview(Review review)
        {
            // See if this user is already in the database
            var user = context.Users
                .Where(u => u.Name == review.Reviewer.Name)
                .FirstOrDefault();

            // If they are, then use the existing record,
            // otherwise a new one will be created
            if (user != null)
            {
                review.Reviewer = user;
            }
            context.Reviews.Add(review);
            context.SaveChanges();
        }

    }
}
