using System;
using System.Threading.Tasks;
using BookReviews.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookReviews.Data
{
    public static class SeedData
    {
<<<<<<< HEAD
        private const string ID1 = "A";
        private const string ID2 = "B";
        private const string ID3 = "C";
        private const string ID4 = "D";

        public static async Task SeedAdminUser(IServiceProvider serviceProvider)
        {
            // TODO: Remove the user name and password from source code
            const string USER_NAME = "admin";
            const string SCREEN_NAME = "Admin";
            const string PASS_WORD = "Secret!123";
            const string ROLE_NAME = "Admin";

            UserManager<AppUser> userManager =
                serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(ROLE_NAME) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(ROLE_NAME));
            }
            // if username doesn't exist, create it and add it to role if (await userManager.FindByNameAsync(username) == null) { User user = new User { UserName = username }; var result = await userManager.CreateAsync(user, password); if (result.Succeeded) {
            if (await userManager.FindByNameAsync(USER_NAME) == null)
            {
                var user = new AppUser { UserName = USER_NAME, Name = SCREEN_NAME };
                var result = await userManager.CreateAsync(user, PASS_WORD);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, ROLE_NAME);
                }
            }
        }

=======
        // Create GUIDs to use for PKs in our AppUser objects
        private static readonly string appUserId1 = Guid.NewGuid().ToString();
        private static readonly string appUserId2 = Guid.NewGuid().ToString();
        private static readonly string appUserId3 = Guid.NewGuid().ToString();
>>>>>>> 7-MoreComplexDomain
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
<<<<<<< HEAD
                Id = ID1,
                Name = "Brian Bird",
                UserName = "BrianB"
            };
            var user2 = new AppUser()
            {
                Id = ID2,
                Name = "Emma Watson",
                UserName = "EmmaW"
            };
            var user3 = new AppUser
            {
                Id = ID3,
                Name = "Daniel Radcliffe",
                UserName = "DanielR"
            };
            var user4 = new AppUser
            {
                Id = ID4,
                Name = "Scarlett Johansson",
                UserName = "ScarlettJ"
=======
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
>>>>>>> 7-MoreComplexDomain
            };

            // Add the three AppUsers to the database
            modelBuilder.Entity<AppUser>().HasData(
                user1, user2, user3, user4
            );

<<<<<<< HEAD
            // Create and add three reviews to the database.

            // These must be untyped objects because they use "shadow" FK preoperties
            // which are in the tables created by EF but not in the domain model.

=======

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
>>>>>>> 7-MoreComplexDomain
            modelBuilder.Entity<Review>().HasData(
                new
                {
                    ReviewId = 1,
<<<<<<< HEAD
                    ReviewerId = ID2,   // "shadow" FK
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
=======
                    ReviewerId = appUserId2,
                    BookId = BOOK_ID1,
>>>>>>> 7-MoreComplexDomain
                    ReviewText = "Great book, a must read!",
                    ReviewDate = DateTime.Parse("11/1/2020"),
                    Rating = 5
                },
                // Another review of the same book
                new
                {
                    ReviewId = 2,
<<<<<<< HEAD
                    ReviewerId = ID3,
                    BookTitle = "Prince of Foxes",
                    AuthorName = "Samuel Shellabarger",
=======
                    ReviewerId = appUserId3,
                    BookId = BOOK_ID1,
>>>>>>> 7-MoreComplexDomain
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
<<<<<<< HEAD
                    ReviewerId = ID1,
                    BookTitle = "Virgil Wander",
                    AuthorName = "Lief Enger",
                    ReviewText = "Wonderful book, written by a distant relative of mine.",
=======
                    ReviewerId = appUserId1,
                    BookId = BOOK_ID2,
                    ReviewText = "Wonderful book, written by a distant cousin of mine.",
>>>>>>> 7-MoreComplexDomain
                    ReviewDate = DateTime.Parse("11/30/2020"),
                    Rating = 5
                },

                 new
                 {
                     ReviewId = 4,
                     ReviewerId = ID4,
                     BookTitle = "Virgil Wander",
                     AuthorName = "Lief Enger",
                     ReviewText = "This book is a bit surreal, but it kept me engaged and reading right to the end.",
                     ReviewDate = DateTime.Parse("10/3/2019"),
                     Rating = 4
                 },

                new
                {
<<<<<<< HEAD
                    ReviewId = 5,
                    ReviewerId = ID1,
                    BookTitle = "Ivanho",
                    AuthorName = "Sir Walter Scott",
=======
                    ReviewId = 4,
                    ReviewerId = appUserId1,
                    BookId = BOOK_ID3,
>>>>>>> 7-MoreComplexDomain
                    ReviewText = "It was a little hard going at first, but then I loved it!",
                    ReviewDate = DateTime.Parse("11/1/2020"),
                    Rating = 4
                },

                 new
                 {
                     ReviewId = 6,
                     ReviewerId = ID2,
                     BookTitle = "The Lion, the Witch and the Wardrobe",
                     AuthorName = "C. S. Lewis",
                     ReviewText = "I loved this book as a kid and I still love it!",
                     ReviewDate = DateTime.Parse("11/1/2020"),
                     Rating = 4
                 },

                 new
                 {
                     ReviewId = 7,
                     ReviewerId = ID4,
                     BookTitle = "The Lion, the Witch and the Wardrobe",
                     AuthorName = "C. S. Lewis",
                     ReviewText = "This book inspired me to believe in things that others think are impossible.",
                     ReviewDate = DateTime.Parse("10/12/2021"),
                     Rating = 4
                 }
            );

            // Create and add comments to the database.

            // These must be untyped objects because they use "shadow" FK preoperties
            // which are in the tables created by EF but not in the domain model.

            modelBuilder.Entity<Comment>().HasData(
                new
                {
                    CommentId = 1,
                    CommentText = "I loved that book as a kid too!",
                    CommentDate = DateTime.Parse("11/5/2020"),
                    CommenterId = ID1,     // "shadow" FK 
                    ReviewId = 6           // "shadow" FK
                },

                new
                {
                    CommentId = 2,
                    CommentText = "I'm glad you were able to get into the book. I never could.",
                    CommentDate = DateTime.Parse("12/3/2020"),
                    CommenterId = ID3,
                    ReviewId = 5
                },

                new
                {
                    CommentId = 3,
                    CommentText = "Wow, how are you related to Lief Enger?",
                    CommentDate = DateTime.Parse("1/15/2021"),
                    CommenterId = ID2,
                    ReviewId = 3
                },

                 new
                 {
                     CommentId = 4,
                     CommentText = "Yes, and as professor Kirk says, it's all about logic.",
                     CommentDate = DateTime.Parse("10/15/2021"),
                     CommenterId = ID2,
                     ReviewId = 7
                 },

                new
                {
                    CommentId = 5,
                    CommentText = "I'm not sure how we're related. Some kind of distant cousin on my Mom's side.",
                    CommentDate = DateTime.Parse("2/1/2021"),
                    CommenterId = ID1,
                    ReviewId = 3
                }
             );
        }
    }
}

