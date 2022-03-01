using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class SQLiteInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookTitle = table.Column<string>(nullable: false),
                    AuthorName = table.Column<string>(nullable: true),
                    ReviewerId = table.Column<string>(nullable: true),
                    ReviewText = table.Column<string>(maxLength: 500, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentText = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    CommenterId = table.Column<string>(nullable: true),
                    ReviewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_CommenterId",
                        column: x => x.CommenterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comment_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "A", 0, "af0fb9a8-6c53-4570-9cc5-10767e86f061", null, false, false, null, "Brian Bird", null, null, null, null, false, "839771d7-f95f-45c7-bfb6-7171a89b7918", false, "BrianB" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "B", 0, "562c3355-ee39-4491-99bf-8abb87c80279", null, false, false, null, "Emma Watson", null, null, null, null, false, "c75039b9-2289-4eb9-8595-635472f52dd4", false, "EmmaW" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "C", 0, "506bf95f-6902-414f-92ab-0c1dc4223f42", null, false, false, null, "Daniel Radcliffe", null, null, null, null, false, "56ac5a1c-4b6d-4d00-bd30-4d43b29f55ce", false, "DanielR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "D", 0, "4cbb1a38-9b22-4f7b-98bc-6363bff779e2", null, false, false, null, "Scarlett Johansson", null, null, null, null, false, "e95067d7-8b3b-4980-acf2-55005de78e08", false, "ScarlettJ" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 3, "Lief Enger", "Virgil Wander", 5, new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonderful book, written by a distant relative of mine.", "A" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 5, "Sir Walter Scott", "Ivanho", 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It was a little hard going at first, but then I loved it!", "A" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 1, "Samuel Shellabarger", "Prince of Foxes", 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great book, a must read!", "B" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 6, "C. S. Lewis", "The Lion, the Witch and the Wardrobe", 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I loved this book as a kid and I still love it!", "B" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 2, "Samuel Shellabarger", "Prince of Foxes", 5, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "I love the clever, witty dialog", "C" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 4, "Lief Enger", "Virgil Wander", 4, new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book is a bit surreal, but it kept me engaged and reading right to the end.", "D" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "AuthorName", "BookTitle", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 7, "C. S. Lewis", "The Lion, the Witch and the Wardrobe", 4, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "This book inspired me to believe in things that others think are impossible.", "D" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 3, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wow, how are you related to Lief Enger?", "B", 3 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 5, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I'm not sure how we're related. Some kind of distant cousin on my Mom's side.", "A", 3 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 2, new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "I'm glad you were able to get into the book. I never could.", "C", 5 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 1, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "I loved that book as a kid too!", "A", 6 });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 4, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yes, and as professor Kirk says, it's all about logic.", "B", 7 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comment_CommenterId",
                table: "Comment",
                column: "CommenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ReviewId",
                table: "Comment",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
