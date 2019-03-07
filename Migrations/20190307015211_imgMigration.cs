using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class imgMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 1,
                column: "ImgUrl",
                value: "C:/Users/haile/OneDrive/Documents/School/Projects/WebsitePractice/TopicalFruitKnockoff/wwwroot/images/Featured.PNG");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 2,
                column: "ImgUrl",
                value: "C:/Users/haile/OneDrive/Documents/School/Projects/WebsitePractice/TopicalFruitKnockoff/wwwroot/images/Classic.PNG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 1,
                column: "ImgUrl",
                value: "Testing");

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 2,
                column: "ImgUrl",
                value: "Testing");
        }
    }
}
