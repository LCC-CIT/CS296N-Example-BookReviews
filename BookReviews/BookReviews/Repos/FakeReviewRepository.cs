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


        public async Task<int> AddReviewAsync(Review review)
        {
            review.ReviewID = reviews.Count;
            await Task<int>.Run(() => reviews.Add(review));
            return 1;
        }

		public Task<int> UpdateReviewAsync(Review review)
		{
			throw new NotImplementedException();
		}
	}
}
