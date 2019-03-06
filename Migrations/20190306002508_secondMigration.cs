using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Catagories_CatagoryId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_CatagoryId",
                table: "Items");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CatagoryId",
                table: "Items",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Items",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "Desctiption", "ImgUrl", "Name" },
                values: new object[] { 1, "These are smoothies", "Testing", "Smoothies" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[] { 1, 1, "Mangoos", "Testing", "Mango", null, 2.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Items",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "CatagoryId",
                table: "Items",
                nullable: true,
                oldClrType: typeof(int));

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
                onDelete: ReferentialAction.Restrict);
        }
    }
}
