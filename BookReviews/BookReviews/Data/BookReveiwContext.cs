using BookReviews.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public class BookReviewContext : IdentityDbContext<AppUser>
    {
        public BookReviewContext(
            DbContextOptions<BookReviewContext> options) : base(options) { }

        // TODO: Determine root entities and remove some DbSets
        public DbSet<Review> Reviews { get; set; }  // Currently the root entity
        public DbSet<Book> Books { get; set; }      // This should be the root entity
        public DbSet<Author> Authors { get; set; }  // This should be a root entity too
        public DbSet<Comment> Comments { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // We must call the base class method because it builds the Identity tables
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();  // This extension method will seed the database
        }
    }
}
