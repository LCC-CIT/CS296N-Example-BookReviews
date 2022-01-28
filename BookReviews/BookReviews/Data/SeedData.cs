﻿using System;
using BookReviews.Models;
using Microsoft.EntityFrameworkCore;

namespace BookReviews.Data
{
    public static class SeedData
    {
        // Create GUIDs to use for PKs in our AppUser objects
        private static readonly string id1 = Guid.NewGuid().ToString();
        private static readonly string id2 = Guid.NewGuid().ToString();
        private static readonly string id3 = Guid.NewGuid().ToString();
        private static readonly string id4 = Guid.NewGuid().ToString();
        /// <summary>
        /// This is an extension method for the ModelBuilder class
        /// It is called from BookReviewContext.OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Create four AppUsers who will be reviewers
            var user1 = new AppUser()
            {
                Id = id1,
                Name = "Brian Bird",
                UserName = "BrianB"
            };
            var user2 = new AppUser()
            {
                Id = id2,
                Name = "Emma Watson",
                UserName = "EmmaW"
            };
            var user3 = new AppUser
            {
                Id = id3,
                Name = "Daniel Radcliffe",
                UserName = "DanielR"
            };
            var user4 = new AppUser
            {
                Id = id4,
                Name = "Scarlett Johansson",
                UserName = "ScarlettJ"
            };

            // Add the three AppUsers to the database
            modelBuilder.Entity<AppUser>().HasData(
                user1, user2, user3, user4
            );

            // Create and add three reviews to the database
            modelBuilder.Entity<Review>().HasData(
                new 
                {
                    ReviewID = 1,
                    ReviewerId = id2,
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
                    ReviewText = "Great book, a must read!",
                    ReviewDate = DateTime.Parse("11/1/2020"),
                    Rating = 5
                },
                // Another review of the same book
                new
                {
                    ReviewID = 2,
                    ReviewerId = id3,
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
                    ReviewText = "I love the clever, witty dialog",
                    ReviewDate = DateTime.Parse("11/15/2020"),
                    Rating = 5
                }
            );

            // The next two reviews will be by the same reviewer
            modelBuilder.Entity<Review>().HasData(
                new
                {
                    ReviewID = 3,
                    ReviewerId = id1,
                    BookTitle = "Virgil Wander",
                    AuthorName = "Lief Enger",
                    ReviewText = "Wonderful book, written by a distant cousin of mine.",
                    ReviewDate = DateTime.Parse("11/30/2020"),
                    Rating = 5
                },

                 new
                 {
                     ReviewID = 4,
                     ReviewerId = id4,
                     BookTitle = "Virgil Wander",
                     AuthorName = "Lief Enger",
                     ReviewText = "This book is a bit surreal, but it kept me engaged and reading right to the end.",
                     ReviewDate = DateTime.Parse("10/3/2019"),
                     Rating = 4
                 },

                new
                {
                    ReviewID = 5,
                    ReviewerId = id1,
                    BookTitle = "Ivanho",
                    AuthorName = "Sir Walter Scott",
                    ReviewText = "It was a little hard going at first, but then I loved it!",
                    ReviewDate = DateTime.Parse("11/1/2020"),
                    Rating = 4
                },

                 new
                 {
                     ReviewID = 6,
                     ReviewerId = id2,
                     BookTitle = "The Lion, the Witch and the Wardrobe",
                     AuthorName = "C. S. Lewis",
                     ReviewText = "I loved this book as a kid and I still love it!",
                     ReviewDate = DateTime.Parse("11/1/2020"),
                     Rating = 4
                 }
            );
        }
    }
}

