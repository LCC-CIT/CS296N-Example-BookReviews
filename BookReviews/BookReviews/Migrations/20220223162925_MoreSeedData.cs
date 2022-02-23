using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a31de41-be09-47e8-ba25-a336b253b10f", "72451096-df6e-4b46-a1a1-ac8a50da7743" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a224645-0faa-4186-9447-e3cbe3f6137f", "2e6b6d76-b097-443a-884c-61992b25838b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7390f05-b62a-4ab5-b448-9b758635b1e8", "7c2ba419-d85f-471e-a1ba-203ba694ada2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "818b5f83-1b59-46ee-a0df-0e85b2870db3", "8f0e25fc-15d2-449f-a32c-d8c0bf617f0e" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 5, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I'm not sure how we're related. Some kind of distant cousin on my Mom's side.", "A", 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewText",
                value: "Wonderful book, written by a distant relative of mine.");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 7, "C. S. Lewis", "The Lion, the Witch and the Wardrobe", 4, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book inspired me to believe in things that others think are impossible.", "D" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 4, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yes, and as professor Kirk says, it's all about logic.", "B", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ec4f6a5-35af-49f3-bf5a-aca171599191", "d4b41306-2d44-4c5f-958f-772544bc47e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6f95428-8820-4dc8-8200-84d3b78b8760", "7319ec71-85ac-4dcb-be0f-37aa0c43c023" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "056d3be5-9023-45f9-9cf4-b6a1d2e8d284", "864fe7e9-4978-432a-aaad-ee4e3f48244f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12d7eacb-f496-41f2-b039-6929cbee8bef", "923256a0-eb31-4cae-9938-c0cd1eb0d46d" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3,
                column: "ReviewText",
                value: "Wonderful book, written by a distant cousin of mine.");
        }
    }
}
