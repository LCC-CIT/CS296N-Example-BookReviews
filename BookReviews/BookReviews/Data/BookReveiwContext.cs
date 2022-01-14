using BookReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public class BookReviewContext : DbContext
    {
        public BookReviewContext(
            DbContextOptions<BookReviewContext> options) : base(options) { }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();  // This extension method will seed the database
        }
    }
}
