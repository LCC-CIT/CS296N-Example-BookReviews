using BookReviews.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Repos
{
    public class FakeReviewRepository : IReviewRepository
    {
        List<Review> reviews = new List<Review>();

        public IQueryable<Review> Reviews 
        { 
            get { return reviews.AsQueryable<Review>(); }
        }


#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task AddReviewAsync(Review review)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            review.ReviewID = reviews.Count;
            reviews.Add(review);
        }
    }
}
