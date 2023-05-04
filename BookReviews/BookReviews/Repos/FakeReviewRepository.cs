using BookReviews.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookReviews.Repos
{
    public class FakeReviewRepository : IReviewRepository
    {
        private readonly ConcurrentBag<Review> reviews = new ConcurrentBag<Review>();
 
        public IQueryable<Review> Reviews 
        { 
            get { return reviews.AsQueryable<Review>(); }
        }

        public async Task AddReviewAsync(Review review)
        {
<<<<<<< HEAD
            await Task.Run(() =>
            {
                review.ReviewId = reviews.Count;
                reviews.Add(review);
            });
=======
            review.ReviewId = reviews.Count;
            reviews.Add(review);
>>>>>>> 7-MoreComplexDomain
        }

        public Task UpdateReviewAsync(Review review)
        {
            throw new NotImplementedException();
        }
    }
}
