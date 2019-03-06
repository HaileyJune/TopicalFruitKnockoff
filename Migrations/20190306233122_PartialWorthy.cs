using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class PartialWorthy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Catagories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 1,
                column: "Active",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Catagories");
        }
    }
}
