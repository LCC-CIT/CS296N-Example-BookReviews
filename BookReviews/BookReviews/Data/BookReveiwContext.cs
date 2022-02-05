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
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We must call the base class method because it builds the Identity tables
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();  // This extension method will seed the database
        }
    }
}
