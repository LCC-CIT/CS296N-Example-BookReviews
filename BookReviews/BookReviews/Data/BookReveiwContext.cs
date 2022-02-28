using BookReviews.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public class BookReviewContext : IdentityDbContext<AppUser>
    {
        public BookReviewContext(
            DbContextOptions<BookReviewContext> options) : base(options) { }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We must call the base class method because it builds the Identity tables
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();  // This extension method will seed the database

            modelBuilder.Entity<Review>()
                .HasMany(b => b.Comments)
                .WithOne(c => c.CommentedReview)
                .OnDelete(DeleteBehavior.ClientCascade); // delete dependent rows



        }
    }
}
