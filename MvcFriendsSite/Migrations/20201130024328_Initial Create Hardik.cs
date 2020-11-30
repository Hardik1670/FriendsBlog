using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcFriendsSite.Migrations
{
    public partial class InitialCreateHardik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Blogs");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_UserModel_AuthorId",
                table: "Blogs",
                column: "AuthorId",
                principalTable: "UserModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_UserModel_AuthorId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_AuthorId",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
