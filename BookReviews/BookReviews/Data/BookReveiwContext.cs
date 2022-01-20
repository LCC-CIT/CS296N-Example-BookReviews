using BookReviews.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public class BookReviewContext : IdentityDbContext
    {
        public BookReviewContext(
            DbContextOptions<BookReviewContext> options) : base(options) { }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();  // This extension method will seed the database
        }
    }
}
