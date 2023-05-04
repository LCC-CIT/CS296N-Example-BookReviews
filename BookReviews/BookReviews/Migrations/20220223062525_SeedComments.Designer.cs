﻿// <auto-generated />
using System;
using BookReviews.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookReviews.Migrations
{
    [DbContext(typeof(BookReviewContext))]
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
    [Migration("20220223062525_SeedComments")]
    partial class SeedComments
========
    [Migration("20220205045957_ComplexDomain")]
    partial class ComplexDomain
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("BookReviews.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(60);

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            Id = "A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ec4f6a5-35af-49f3-bf5a-aca171599191",
========
                            Id = "7dc3c5ff-fd2c-492d-a3d6-05a607c8eb5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f53d2fad-70ca-4744-8c45-03e1ea60f2f6",
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Brian Bird",
                            PhoneNumberConfirmed = false,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            SecurityStamp = "d4b41306-2d44-4c5f-958f-772544bc47e4",
                            TwoFactorEnabled = false,
                            UserName = "BrianB"
                        },
                        new
                        {
                            Id = "B",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c6f95428-8820-4dc8-8200-84d3b78b8760",
========
                            SecurityStamp = "6a0dbf53-197b-46b0-be1c-1c148cceef21",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "755f75a9-ea9f-4e75-9d9a-d21b719c5afc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "62cd03d7-efaf-434c-8f3e-d21b159aca8e",
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Emma Watson",
                            PhoneNumberConfirmed = false,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            SecurityStamp = "7319ec71-85ac-4dcb-be0f-37aa0c43c023",
                            TwoFactorEnabled = false,
                            UserName = "EmmaW"
                        },
                        new
                        {
                            Id = "C",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "056d3be5-9023-45f9-9cf4-b6a1d2e8d284",
========
                            SecurityStamp = "bf50f93d-17ba-4141-912d-79e3eff4f7fb",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "b5158425-0721-4169-acf0-ef8a080c2874",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9582f570-8f67-42b5-94e2-5528e79b8289",
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Daniel Radcliffe",
                            PhoneNumberConfirmed = false,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            SecurityStamp = "864fe7e9-4978-432a-aaad-ee4e3f48244f",
                            TwoFactorEnabled = false,
                            UserName = "DanielR"
                        },
                        new
                        {
                            Id = "D",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12d7eacb-f496-41f2-b039-6929cbee8bef",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Scarlett Johansson",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "923256a0-eb31-4cae-9938-c0cd1eb0d46d",
                            TwoFactorEnabled = false,
                            UserName = "ScarlettJ"
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommenterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("CommenterId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            CommentDate = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "I loved that book as a kid too!",
                            CommenterId = "A",
                            ReviewId = 6
                        },
                        new
                        {
                            CommentId = 2,
                            CommentDate = new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "I'm glad you were able to get into the book. I never could.",
                            CommenterId = "C",
                            ReviewId = 5
                        },
                        new
                        {
                            CommentId = 3,
                            CommentDate = new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CommentText = "Wow, how are you related to Lief Enger?",
                            CommenterId = "B",
                            ReviewId = 3
========
                            SecurityStamp = "db79e9af-0ba1-4557-a441-c0093c4cc5a8",
                            TwoFactorEnabled = false
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AuthorWriterId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("PrintDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorWriterId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AuthorWriterId = 1,
                            PrintDate = new DateTime(1947, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Prince of Foxes"
                        },
                        new
                        {
                            BookId = 2,
                            AuthorWriterId = 2,
                            PrintDate = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Virgil Wander"
                        },
                        new
                        {
                            BookId = 3,
                            AuthorWriterId = 3,
                            PrintDate = new DateTime(1819, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Ivanhoe"
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommentText")
                        .HasColumnType("TEXT");

                    b.Property<string>("CommenterId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CommentId");

                    b.HasIndex("CommenterId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BookReviews.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(500);

                    b.Property<string>("ReviewerId")
                        .HasColumnType("TEXT");

                    b.HasKey("ReviewId");
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
========

                    b.HasIndex("BookId");
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            AuthorName = "Samuel Shellabarger",
                            BookTitle = "Prince of Foxes",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Great book, a must read!",
                            ReviewerId = "B"
========
                            BookId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Great book, a must read!",
                            ReviewerId = "755f75a9-ea9f-4e75-9d9a-d21b719c5afc"
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                        },
                        new
                        {
                            ReviewId = 2,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            AuthorName = "Samuel Shellabarger",
                            BookTitle = "Prince of Foxes",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I love the clever, witty dialog",
                            ReviewerId = "C"
========
                            BookId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I love the clever, witty dialog",
                            ReviewerId = "b5158425-0721-4169-acf0-ef8a080c2874"
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                        },
                        new
                        {
                            ReviewId = 3,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            AuthorName = "Lief Enger",
                            BookTitle = "Virgil Wander",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Wonderful book, written by a distant cousin of mine.",
                            ReviewerId = "A"
========
                            BookId = 2,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Wonderful book, written by a distant cousin of mine.",
                            ReviewerId = "7dc3c5ff-fd2c-492d-a3d6-05a607c8eb5d"
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                        },
                        new
                        {
                            ReviewId = 4,
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                            AuthorName = "Lief Enger",
                            BookTitle = "Virgil Wander",
                            Rating = 4,
                            ReviewDate = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "This book is a bit surreal, but it kept me engaged and reading right to the end.",
                            ReviewerId = "D"
                        },
                        new
                        {
                            ReviewId = 5,
                            AuthorName = "Sir Walter Scott",
                            BookTitle = "Ivanho",
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "It was a little hard going at first, but then I loved it!",
                            ReviewerId = "A"
                        },
                        new
                        {
                            ReviewId = 6,
                            AuthorName = "C. S. Lewis",
                            BookTitle = "The Lion, the Witch and the Wardrobe",
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I loved this book as a kid and I still love it!",
                            ReviewerId = "B"
========
                            BookId = 3,
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "It was a little hard going at first, but then I loved it!",
                            ReviewerId = "7dc3c5ff-fd2c-492d-a3d6-05a607c8eb5d"
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("WriterId");

                    b.ToTable("Writers");

                    b.HasData(
                        new
                        {
                            WriterId = 1,
                            Birthdate = new DateTime(1888, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samuel Shellabarger"
                        },
                        new
                        {
                            WriterId = 2,
                            Birthdate = new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "leif Enger"
                        },
                        new
                        {
                            WriterId = 3,
                            Birthdate = new DateTime(1771, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Sir Walter Scott"
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
========
            modelBuilder.Entity("BookReviews.Models.Book", b =>
                {
                    b.HasOne("BookReviews.Models.Writer", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorWriterId");
                });

>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
            modelBuilder.Entity("BookReviews.Models.Comment", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", "Commenter")
                        .WithMany()
                        .HasForeignKey("CommenterId");

                    b.HasOne("BookReviews.Models.Review", null)
                        .WithMany("Comments")
<<<<<<<< HEAD:BookReviews/BookReviews/Migrations/20220223062525_SeedComments.Designer.cs
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
========
                        .HasForeignKey("ReviewId");
>>>>>>>> 7-MoreComplexDomain:BookReviews/BookReviews/Migrations/20220205045957_ComplexDomain.Designer.cs
                });

            modelBuilder.Entity("BookReviews.Models.Review", b =>
                {
                    b.HasOne("BookReviews.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("BookReviews.Models.AppUser", "Reviewer")
                        .WithMany()
                        .HasForeignKey("ReviewerId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
