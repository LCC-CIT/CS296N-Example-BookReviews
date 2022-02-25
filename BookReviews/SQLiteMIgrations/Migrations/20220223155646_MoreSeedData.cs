using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLiteMigrations.Migrations
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
                values: new object[] { "e8819dce-2ea1-4e43-808f-e7b2d6d7b818", "c25ccf8a-2133-442e-b78c-2c62e1e79378" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41930026-61fe-4a30-b969-052a6d5ea136", "c9e5994e-b981-41aa-832d-0d9bb9c4e066" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6313c21b-5790-4625-9153-e7091b76663d", "d748bfb0-2aee-4c0f-8f24-04df16d15cde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0883c6c1-a5a8-400f-9dff-f13d48fb0fc9", "7656c9b5-c725-4449-bf31-43a1da18b43a" });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentDate", "CommentText", "CommenterId", "ReviewId" },
                values: new object[] { 5, new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "I'm not sure how we're related. Some kind of distant cousin.", "A", 3 });

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
                values: new object[] { "e89d39bd-ded8-4c59-b1ac-52dfde668b0f", "bd3039de-0abc-4427-a5db-ec9365dde7ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93496e33-d552-4407-8d61-0e58bb00f624", "32d0af7c-5cf0-48a6-8867-e88c0e0d6231" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4c30095-0b87-461e-86a2-96e911f53727", "44ca3a4d-c529-481f-8fde-500616ced604" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7983f010-03cd-4850-9fa1-6145b58f97cc", "e1a8cf38-f838-4086-a385-599b76fbfa34" });
        }
    }
}
