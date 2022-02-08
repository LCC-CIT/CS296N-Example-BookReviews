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

        public  IQueryable<Review> Reviews 
        { 
            get 
            {
                // Get all the Review objects in the Reviews DbSet
                // and include the Reivewer object and list of comments in each Review.
                return context.Reviews.Include(review => review.Reviewer)
                         .Include(review => review.Comments)
                         .ThenInclude(comment => comment.Commenter);
            }
        }

        public async Task<int> AddReviewAsync(Review review)
        {
            // context.Comments.Add(review.Comments);
            await context.Reviews.AddAsync(review);
            return await context.SaveChangesAsync(); // returns the number of entries written to the DB
        }

        /// <summary>
        /// Updates an existing review with any changes that are in the review object.
        /// </summary>
        /// <param name="review"></param>
        /// <returns>A task object containing a result code </returns>
        public async Task<int> UpdateReviewAsync(Review review)
        {
            context.Reviews.Update(review);   // Find the review by ReviewID and update it
            return  await context.SaveChangesAsync();  // returns the number of entries written to the DB
        }

    }
}
