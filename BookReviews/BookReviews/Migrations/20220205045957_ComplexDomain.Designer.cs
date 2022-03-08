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
    [Migration("20220205045957_ComplexDomain")]
    partial class ComplexDomain
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
                            Id = "7dc3c5ff-fd2c-492d-a3d6-05a607c8eb5d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f53d2fad-70ca-4744-8c45-03e1ea60f2f6",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Brian Bird",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6a0dbf53-197b-46b0-be1c-1c148cceef21",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "755f75a9-ea9f-4e75-9d9a-d21b719c5afc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "62cd03d7-efaf-434c-8f3e-d21b159aca8e",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Emma Watson",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bf50f93d-17ba-4141-912d-79e3eff4f7fb",
                            TwoFactorEnabled = false
                        },
                        new
                        {
                            Id = "b5158425-0721-4169-acf0-ef8a080c2874",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9582f570-8f67-42b5-94e2-5528e79b8289",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Daniel Radliiffe",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "db79e9af-0ba1-4557-a441-c0093c4cc5a8",
                            TwoFactorEnabled = false
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

                    b.HasIndex("BookId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            BookId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Great book, a must read!",
                            ReviewerId = "755f75a9-ea9f-4e75-9d9a-d21b719c5afc"
                        },
                        new
                        {
                            ReviewId = 2,
                            BookId = 1,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I love the clever, witty dialog",
                            ReviewerId = "b5158425-0721-4169-acf0-ef8a080c2874"
                        },
                        new
                        {
                            ReviewId = 3,
                            BookId = 2,
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Wonderful book, written by a distant cousin of mine.",
                            ReviewerId = "7dc3c5ff-fd2c-492d-a3d6-05a607c8eb5d"
                        },
                        new
                        {
                            ReviewId = 4,
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

            modelBuilder.Entity("BookReviews.Models.Book", b =>
                {
                    b.HasOne("BookReviews.Models.Writer", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorWriterId");
                });

            modelBuilder.Entity("BookReviews.Models.Comment", b =>
                {
                    b.HasOne("BookReviews.Models.AppUser", "Commenter")
                        .WithMany()
                        .HasForeignKey("CommenterId");

                    b.HasOne("BookReviews.Models.Review", null)
                        .WithMany("Comments")
                        .HasForeignKey("ReviewId");
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