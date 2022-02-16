using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class SQLiteInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Users",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ReviewerUserID",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "BookTitle",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Reviews",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReviewID",
                table: "Reviews",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "ReviewerUserID",
                table: "Reviews",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewText",
                table: "Reviews",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<int>(
                name: "Rating",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "BookTitle",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "AuthorName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReviewID",
                table: "Reviews",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Sqlite:Autoincrement", true)
                .OldAnnotation("Sqlite:Autoincrement", true);
        }
    }
}
