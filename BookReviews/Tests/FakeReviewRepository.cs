using BookReviews.Models;
using BookReviews.Repos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Tests
{
    public class FakeReviewRepository : IReviewRepository
    {

        TestAsyncQueryableDataSource reviews =
            new TestAsyncQueryableDataSource();

       public IQueryable<Review> Reviews
        {
           get { return reviews; }
        }

        public async Task AddReviewAsync(Review review)
        {
            review.ReviewID = reviews.Count();
            reviews.Add(review);
        }
    }
}
