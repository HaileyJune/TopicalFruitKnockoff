using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class DifferentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "Desctiption", "ImgUrl", "Name" },
                values: new object[] { 1, "", "Testing", "Featured Products" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "Desctiption", "ImgUrl", "Name" },
                values: new object[] { 2, "All smoothies are 24 oz. and made with turbinado unless otherwise noted or requested. Splenda substitute available.", "Testing", "Classic Smoothies" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[] { 1, 1, "unsweetened vanilla almond milk, mango, pineapple & turmeric", "https://olo-images-live.imgix.net/bf/bfd6170e52ec44259f5745202c350e09.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2af6f386acd3bbd2b1cc5d1b4a47aebc", "Mango Tumeric", null, 5.29 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[] { 2, 1, "unsweetened vanilla almond milk, strawberries, cinnamon & topped with granola", "https://olo-images-live.imgix.net/fc/fcc5c1cb95a34a6a9feb446c48099e48.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=0a8b0e6c1abe042d19719a48067d02b1", "Strawberry Granola", null, 5.29 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[] { 3, 2, "strawberries, pineapple, white chocolate & coconut (500 cal)", "https://olo-images-live.imgix.net/fb/fb690aae84b64c148317ac7809183f4b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d67aa2c28779fdc6858aef8d8f410eb2", "Bahama Mama", null, 5.99 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 2);
        }
    }
}
