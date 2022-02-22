using System;
using BookReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public static class SeedData
    {
        // Create GUIDs to use for PKs in our AppUser objects
        private static readonly string appUserId1 = Guid.NewGuid().ToString();
        private static readonly string appUserId2 = Guid.NewGuid().ToString();
        private static readonly string appUserId3 = Guid.NewGuid().ToString();
        /// <summary>
        /// This is an extension method for the ModelBuilder class
        /// It is called from BookReviewContext.OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Create three AppUsers who will be reviewers
            var user1 = new AppUser()
            {
                Id = appUserId1,
                Name = "Brian Bird"
            };
            var user2 = new AppUser()
            {
                Id = appUserId2,
                Name = "Emma Watson"
            };
            var user3 = new AppUser
            {
                Id = appUserId3,
                Name = "Daniel Radliiffe"
            };

            // Add the three AppUsers to the database
            modelBuilder.Entity<AppUser>().HasData(
                user1, user2, user3
            );


            // Create and add authors to the database
            Author author1 = new Author()
            {
                AuthorId = 1,
                Name = "Samuel Shellabarger",
                Birthdate = DateTime.Parse("5/18/1888")
            };

            Author author2 = new Author()
            {
                AuthorId = 2,
                Name = "leif Enger",
                Birthdate = DateTime.Parse("1/1/1961")
            };

            Author author3 = new Author()
            {
                AuthorId = 3,
                Name = "Sir Walter Scott",
                Birthdate = DateTime.Parse("8/15/1771")
            };

            modelBuilder.Entity<Author>().HasData(author1, author2, author3);

            // Create and add books to the database
            // Since we are using shadow FK properties, we must books as anonymous objects
            const int BOOK_ID1 = 1, BOOK_ID2 = 2, BOOK_ID3 = 3;

            modelBuilder.Entity<Book>().HasData(
            new
            {
                BookId = BOOK_ID1,
                Title = "Prince of Foxes",
                AuthorId = author1.AuthorId,
                PrintDate = DateTime.Parse("1/1/1947")
            },

            new
            {
                BookId = BOOK_ID2,
                Title = "Virgil Wander",
                AuthorId = author2.AuthorId,
                PrintDate = DateTime.Parse("1/1/2018")
            },

            new
            {
                BookId = BOOK_ID3,
                Title = "Ivanhoe",
                AuthorId = author3.AuthorId,
                PrintDate = DateTime.Parse("1/1/1819")
            }
            );


            // Create and add three reviews to the database
            // These are also created as anonymous objects because they use shadow FK properties
            modelBuilder.Entity<Review>().HasData(
                new
                {
                    ReviewId = 1,
                    ReviewerId = appUserId2,
                    BookId = BOOK_ID1,
                    ReviewText = "Great book, a must read!",
                    ReviewDate = DateTime.Parse("11/1/2020"),
                    Rating = 5
                },
                // Another review of the same book
                new
                {
                    ReviewId = 2,
                    ReviewerId = appUserId3,
                    BookId = BOOK_ID1,
                    ReviewText = "I love the clever, witty dialog",
                    ReviewDate = DateTime.Parse("11/15/2020"),
                    Rating = 5
                }
            );

            // The next two reviews will be by the same reviewer
            modelBuilder.Entity<Review>().HasData(
                new
                {
                    ReviewId = 3,
                    ReviewerId = appUserId1,
                    BookId = BOOK_ID2,
                    ReviewText = "Wonderful book, written by a distant cousin of mine.",
                    ReviewDate = DateTime.Parse("11/30/2020"),
                    Rating = 5
                },

                new
                {
                    ReviewId = 4,
                    ReviewerId = appUserId1,
                    BookId = BOOK_ID3,
                    ReviewText = "It was a little hard going at first, but then I loved it!",
                    ReviewDate = DateTime.Parse("11/1/2020"),
                    Rating = 4
                }
            );
        }
    }
}

