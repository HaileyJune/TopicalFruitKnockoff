using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class seeds1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 4, 2, "strawberries, banana & chocolate (550 cal)", "https://olo-images-live.imgix.net/65/65ab2c0b569340f29f5a3da024823e4a.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=445c97f5c2d6193d0ce16265b3ffbac1", "Beach Bum", null, 5.99 },
                    { 5, 2, "strawberries, pineapple, orange juice & lime (440 cal)", "https://olo-images-live.imgix.net/01/01d5829cb85c478ca1a15b6ac883e27b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=f46625f9b3039d2c777ae878a8112011", "Blimey Limey", null, 5.99 },
                    { 6, 2, "blueberries, strawberries & banana (340 cal)", "https://olo-images-live.imgix.net/a4/a40d91f6251b4b40a86924fc08923f82.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=5104934fc1165c67f015302827dcc56d", "Blueberry Bliss", null, 5.99 },
                    { 7, 2, "strawberries & banana (370 cal)", "https://olo-images-live.imgix.net/36/36dd4be35fab41b8ae9d152a40744354.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=4800891004b7bad0e7eb85792b74da13", "Jerry Punch", null, 5.99 },
                    { 8, 2, "kiwi, strawberries & non-fat yogurt (450 cal)", "https://olo-images-live.imgix.net/82/82625c4eadf849c9b0540370fdb98000.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=84efefe5c7957d8853edd86a6669c968", "Kiwi Quencher", null, 5.99 },
                    { 9, 2, "mango, pineapple & non-fat yogurt (400 cal)", "https://olo-images-live.imgix.net/2d/2d7b7393d6d04ae983368fe531f933e2.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=84c7698fe93f22790790cb8d4419c3ab", "Mango Magic", null, 5.99 },
                    { 10, 2, "cholocate, coffee, cappuccino & non-fat yogurt (available in decaf) (660 cal)", "https://olo-images-live.imgix.net/6b/6b65403c1fd14c0fb1f71540b3be40f3.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=3aa4b2b1c6d1324fec82bcd1c28d3758", "Mocha Madness", null, 5.99 },
                    { 11, 2, "strawberries, banana & pineapple (430 cal)", "https://olo-images-live.imgix.net/3c/3cdb5fad022041ddb07581682d1c2ea5.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=318a6a03002d930cfe0452caa2809bff", "Paradise Point", null, 5.99 },
                    { 12, 2, "peaches, strawberries & banana (360 cal)", "https://olo-images-live.imgix.net/c7/c7117a873686420695ebead4ab1e07cc.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d41e797ad0e0f38e9b53d5ee71b8c418", "Peaches 'N Silk", null, 5.99 },
                    { 13, 2, "peanut butter, banana & chocolate (710 cal)", "https://olo-images-live.imgix.net/23/2356a719f82b4add9261d3feb980a5b2.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=acd288ab71b73531b5988ed071ba0f02", "Peanut Butter Cup", null, 5.99 },
                    { 14, 2, "strawberries & lime (470 cal)", "https://olo-images-live.imgix.net/c2/c240162fe4ce4d0588c9296d5972b84c.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2daddf7dbef2d8c3a1da38c43d315bf7", "Strawberry Limeade", null, 5.99 },
                    { 15, 2, "strawberries, pineapple, mango, & orange juice (360 cal)", "https://olo-images-live.imgix.net/1f/1f191046fa2c4c348cb010097c309067.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2017ac3dfab75f2fc77acfbcfc361e40", "Sunrise Sunset", null, 5.99 },
                    { 16, 2, "mango, banana, orange, pineapple & orange juice (390 cal)", "https://olo-images-live.imgix.net/36/36cadc17481c4748a1e20719f4eb2bc6.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=db913f5191c70cc66ffbcbd16c4688b5", "Sunshine", null, 5.99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);
        }
    }
}
