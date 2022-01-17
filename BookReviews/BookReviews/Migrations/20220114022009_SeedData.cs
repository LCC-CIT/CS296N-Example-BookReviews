using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name" },
                values: new object[] { 1, "Brian Bird" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name" },
                values: new object[] { 2, "Emma Watson" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Name" },
                values: new object[] { 3, "Daniel Radliiffe" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "AuthorName", "BookTitle", "ReviewDate", "ReviewText", "ReviewerUserID" },
                values: new object[,]
                {
                    { 3, "Lief Enger", "Virgil Wander", new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonderful book, written by a distant cousin of mine.", 1 },
                    { 4, "Sir Walter Scott", "Ivanho", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It was a little hard going at first, but then I loved it!", 1 },
                    { 1, "Samuel Shellabarger", "Prince of Foxes", new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great book, a must read!", 2 },
                    { 2, "Samuel Shellabarger", "Prince of Foxes", new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "I love the clever, witty dialog", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);
        }
    }
}
