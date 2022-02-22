﻿// <auto-generated />
using System;
using BookReviews.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SQLiteMigrations.Migrations
{
    [DbContext(typeof(BookReviewContext))]
    [Migration("20220216225947_SQLiteInitial")]
    partial class SQLiteInitial
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
                            Id = "A",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6b051854-f5a2-44dd-bf14-0bf671f9807d",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Brian Bird",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4f3c5bce-3e35-4b6e-8e51-bb7b2873795c",
                            TwoFactorEnabled = false,
                            UserName = "BrianB"
                        },
                        new
                        {
                            Id = "B",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d0ff45a7-be3d-40a3-983e-f26a31374ff5",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Emma Watson",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d38d0527-75ce-427d-8403-2ba18937dff5",
                            TwoFactorEnabled = false,
                            UserName = "EmmaW"
                        },
                        new
                        {
                            Id = "C",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "93b329fc-f6c7-43a5-b80e-a1dd4d7f87fc",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Daniel Radcliffe",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "47246933-8061-4c5b-9b66-515c77cd4d8b",
                            TwoFactorEnabled = false,
                            UserName = "DanielR"
                        },
                        new
                        {
                            Id = "D",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "eadc72ac-f150-43fa-a337-d835dd901205",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            Name = "Scarlett Johansson",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7a9283fb-c40f-4ece-b9dc-6ca8ea5c8beb",
                            TwoFactorEnabled = false,
                            UserName = "ScarlettJ"
                        });
                });

            modelBuilder.Entity("BookReviews.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AuthorName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

                    b.HasKey("ReviewID");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewID = 1,
                            AuthorName = "Samuel Shellabarger",
                            BookTitle = "Prince of Foxes",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Great book, a must read!",
                            ReviewerId = "B"
                        },
                        new
                        {
                            ReviewID = 2,
                            AuthorName = "Samuel Shellabarger",
                            BookTitle = "Prince of Foxes",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I love the clever, witty dialog",
                            ReviewerId = "C"
                        },
                        new
                        {
                            ReviewID = 3,
                            AuthorName = "Lief Enger",
                            BookTitle = "Virgil Wander",
                            Rating = 5,
                            ReviewDate = new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "Wonderful book, written by a distant cousin of mine.",
                            ReviewerId = "A"
                        },
                        new
                        {
                            ReviewID = 4,
                            AuthorName = "Lief Enger",
                            BookTitle = "Virgil Wander",
                            Rating = 4,
                            ReviewDate = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "This book is a bit surreal, but it kept me engaged and reading right to the end.",
                            ReviewerId = "D"
                        },
                        new
                        {
                            ReviewID = 5,
                            AuthorName = "Sir Walter Scott",
                            BookTitle = "Ivanho",
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "It was a little hard going at first, but then I loved it!",
                            ReviewerId = "A"
                        },
                        new
                        {
                            ReviewID = 6,
                            AuthorName = "C. S. Lewis",
                            BookTitle = "The Lion, the Witch and the Wardrobe",
                            Rating = 4,
                            ReviewDate = new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReviewText = "I loved this book as a kid and I still love it!",
                            ReviewerId = "B"
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

            modelBuilder.Entity("BookReviews.Models.Review", b =>
                {
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