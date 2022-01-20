using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class SQLiteInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookTitle = table.Column<string>(nullable: false),
                    AuthorName = table.Column<string>(nullable: true),
                    ReviewerUserID = table.Column<int>(nullable: true),
                    ReviewText = table.Column<string>(maxLength: 500, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_ReviewerUserID",
                        column: x => x.ReviewerUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                columns: new[] { "ReviewID", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerUserID" },
                values: new object[] { 3, "Lief Enger", "Virgil Wander", 5, new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonderful book, written by a distant cousin of mine.", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerUserID" },
                values: new object[] { 4, "Sir Walter Scott", "Ivanho", 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It was a little hard going at first, but then I loved it!", 1 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerUserID" },
                values: new object[] { 1, "Samuel Shellabarger", "Prince of Foxes", 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great book, a must read!", 2 });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerUserID" },
                values: new object[] { 2, "Samuel Shellabarger", "Prince of Foxes", 5, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "I love the clever, witty dialog", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerUserID",
                table: "Reviews",
                column: "ReviewerUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
