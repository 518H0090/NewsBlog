using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewsBlogAPI.Migrations
{
    public partial class InitialBlog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_newsPosts_users_UserId",
                table: "newsPosts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "newsPosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_newsPosts_users_UserId",
                table: "newsPosts",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_newsPosts_users_UserId",
                table: "newsPosts");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "newsPosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_newsPosts_users_UserId",
                table: "newsPosts",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
