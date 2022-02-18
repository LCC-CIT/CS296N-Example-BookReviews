using BookReviews.Data;
using BookReviews.Models;
using Microsoft.EntityFrameworkCore;
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
                // and include the Reivewer object in each Review.
                return context.Reviews.Include(review => review.Reviewer);
            }
        }

        public async Task AddReviewAsync(Review review)
        {
            context.Reviews.Add(review);
            await context.SaveChangesAsync();
        }

        public async Task<int> DeleteRviewAsync(Review review)
        {
            var theReview = await context.Reviews.FindAsync(review.ReviewID);
            context.Reviews.Remove(theReview);
            return await context.SaveChangesAsync();
        }

    }
}
