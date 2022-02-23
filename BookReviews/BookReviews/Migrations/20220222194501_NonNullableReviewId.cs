using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReviews.Migrations
{
    public partial class NonNullableReviewId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Reviews_ReviewId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewId",
                table: "Comment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a018cbf3-ebef-407c-b5ef-7d1603bff160", "e825f706-580f-4eec-b7dd-5519fb4d8f32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6b17576-59b9-4b9e-9c07-97b352b5ec25", "c92fb965-77c2-41c6-9eb3-41b675f05a42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca7ecd97-2f4e-4d4f-80fd-7e0155e52d57", "4d5c4203-32c5-49a0-9b9c-ac0037d415a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df5b486a-b74d-4f3a-9a5f-1e57ddf8804c", "b58acb2d-a154-4138-8448-7f5822c4579e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Reviews_ReviewId",
                table: "Comment",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Reviews_ReviewId",
                table: "Comment");

            migrationBuilder.AlterColumn<int>(
                name: "ReviewId",
                table: "Comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "A",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a6d0b48-7c18-471b-b629-9f9a476c7173", "13acffc9-a546-40fc-87e3-094b381e8ead" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4004628d-fd58-4699-a82f-f8d31f6b1907", "1f66af12-a8b6-48fe-a989-aced90646c99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8871c758-153b-45e1-a307-4e9bfe2c5f75", "a2d366e8-b557-4701-84b8-fe265056e304" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6267d5af-eb7b-4e57-ad75-2147fdfcb1ed", "3886fd63-cc02-4482-ae4a-732cf91bdb5c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Reviews_ReviewId",
                table: "Comment",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
