using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class MoreAdjustments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Items_CatagoryId",
                table: "Items",
                column: "CatagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Catagories_CatagoryId",
                table: "Items",
                column: "CatagoryId",
                principalTable: "Catagories",
                principalColumn: "CatagoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Catagories_CatagoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CatagoryId",
                table: "Items");

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "Desctiption", "ImgUrl", "Name" },
                values: new object[] { 1, "These are smoothies", "Testing", "Smoothies" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[] { 1, 1, "Mangoos", "Testing", "Mango", null, 2.0 });
        }
    }
}
