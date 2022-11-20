using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 1,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 2,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 3,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 4,
                column: "ImageUrl",
                value: "image");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 5,
                column: "ImageUrl",
                value: "image");
        }
    }
}
