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
                return context.Reviews;
                /*
                // Get all the Review objects in the Reviews DbSet
                // and include the Reivewer object in each Review.
                return context.Reviews.Include(r => r.Reviewer)
                                      .Include(r => r.Comments)
                                      .ThenInclude(r => r.Commenter);
                */
            }
        }

        public async Task AddReviewAsync(Review review)
        {
            var reivew = context.Reviews.First();
            context.Entry(review).Collection(r => r.Comments).Load();
            context.Reviews.Add(review);
            await context.SaveChangesAsync();
        }

        public async Task UpdateReviewAsync(Review review)
        {
            context.Reviews.Update(review);   // Find the review by ReviewId and update it
            await context.SaveChangesAsync();
        }

        public async Task<int> DeleteRviewAsync(Review review)
        {
            var theReview = await context.Reviews.FindAsync(review.ReviewId);
            context.Reviews.Remove(theReview);
            return await context.SaveChangesAsync();
        }

    }
}
