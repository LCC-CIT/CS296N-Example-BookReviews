using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLiteMigrations.Migrations
{
    public partial class WriterToAuthor : Migration
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
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Birthdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
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
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    PrintDate = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(nullable: true),
                    ReviewerId = table.Column<string>(nullable: true),
                    ReviewText = table.Column<string>(maxLength: 500, nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    ReviewDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentText = table.Column<string>(nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    CommenterId = table.Column<string>(nullable: true),
                    ReviewId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CommenterId",
                        column: x => x.CommenterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "ReviewId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fbfc74cc-4b3e-422b-8259-e30a4d1f1772", 0, "71c679e5-5719-4106-bffb-bcce4e8f21c9", null, false, false, null, "Brian Bird", null, null, null, null, false, "0165cdd5-ba6f-460f-bbd6-0a266dab97f4", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f7b9ba75-4edb-48fa-a9cb-8a8d4014181d", 0, "6578fa95-2ff9-48d2-be3f-409b899eefd4", null, false, false, null, "Emma Watson", null, null, null, null, false, "62c4cacc-afe1-4a5b-9e9c-b383fdadcb5b", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3522cc34-179c-4b11-8387-b60c94deafee", 0, "6c2ea034-4a57-4d9a-b11a-f3b3e71864aa", null, false, false, null, "Daniel Radliiffe", null, null, null, null, false, "d4ef602d-1345-4236-8f22-42805ef440de", false, null });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Birthdate", "Name" },
                values: new object[] { 1, new DateTime(1888, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel Shellabarger" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Birthdate", "Name" },
                values: new object[] { 2, new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "leif Enger" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Birthdate", "Name" },
                values: new object[] { 3, new DateTime(1771, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sir Walter Scott" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PrintDate", "Title" },
                values: new object[] { 1, 1, new DateTime(1947, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prince of Foxes" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PrintDate", "Title" },
                values: new object[] { 2, 2, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virgil Wander" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "PrintDate", "Title" },
                values: new object[] { 3, 3, new DateTime(1819, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivanhoe" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "BookId", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 1, 1, 5, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Great book, a must read!", "f7b9ba75-4edb-48fa-a9cb-8a8d4014181d" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "BookId", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 2, 1, 5, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "I love the clever, witty dialog", "3522cc34-179c-4b11-8387-b60c94deafee" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "BookId", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 3, 2, 5, new DateTime(2020, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wonderful book, written by a distant cousin of mine.", "fbfc74cc-4b3e-422b-8259-e30a4d1f1772" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "BookId", "Rating", "ReviewDate", "ReviewText", "ReviewerId" },
                values: new object[] { 4, 3, 4, new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "It was a little hard going at first, but then I loved it!", "fbfc74cc-4b3e-422b-8259-e30a4d1f1772" });

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
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CommenterId",
                table: "Comments",
                column: "CommenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
