using Microsoft.EntityFrameworkCore.Migrations;

namespace TopicalFruitKnockoff.Migrations
{
    public partial class superfruits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryId", "Active", "Desctiption", "ImgUrl", "Name" },
                values: new object[] { 3, false, "All smoothies are 24 oz. and made with turbinado unless otherwise noted or requested. Splenda substitute available.", "wwwroot/images/Classic.PNG", "Supterfood Smoothies" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CatagoryId", "Description", "ImgUrl", "Name", "OrderId", "Price" },
                values: new object[,]
                {
                    { 17, 3, "acai, pomegranate, banana, blueberries & strawberries (470 cal)", "https://olo-images-live.imgix.net/a1/a1a8fdaaac2c4e04ba1c17169d858015.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=fd1ee10da835e0eeece9b4c81f17479e", "Aci Berry Boost", null, 5.99 },
                    { 18, 3, "avocado, pineapple, spinach, kale, coconut & lime (600 cal)", "https://olo-images-live.imgix.net/a4/a49cc30189f243338cb3ffecb61c0a3c.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=da6c1c885d1f8f0d13aae372dac436a2", "Avacolada", null, 5.99 },
                    { 19, 3, "roasted banana, chia seeds, almonds, whole-grain oats, cinnamon, dates & coconut with choice of strawberries or peanut butter (610/780 cal)", "https://olo-images-live.imgix.net/83/8339eb02d5b54862885f0976b63d4ba4.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=5c94e1f71088f3c60c9465a8c6545f58", "Chia Banana Boosy", null, 5.99 },
                    { 20, 3, "Chia Banana Boost, plus peanut butter & whey for max protein! Additional supplement charge applies. (880 cal)", "https://olo-images-live.imgix.net/a1/a1ecd254a1284cd680dd5b0414fdad88.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=3aeaa6066de20fff76ee59d1259c50a0", "Chia Banana Max", null, 5.99 },
                    { 21, 3, "spinach, kale, mango, pineapple, banana & fresh ginger (naturally sweetened) (180 cal)", "https://olo-images-live.imgix.net/d6/d6668cbf322145ef861746fdec275fe8.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=1f07cdad2cebf2799256c014b686ac53", "Detox Island Green", null, 5.99 },
                    { 22, 3, "blueberries, mango, banana, almonds & choice of protein (520-570 cal)", "https://olo-images-live.imgix.net/b3/b3692e8640984fc7850c4a51ddd489c0.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=408087148e29164d8c4b25ea7bade6de", "Health Nut", null, 5.99 },
                    { 23, 3, "spinach, kale, mango, pineapple & banana (410 cal)", "https://olo-images-live.imgix.net/75/75e22c8022774ef2959fa03889aaea65.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=4f4cc3c07b8f76a9377291d66331b91c", "Island Green", null, 5.99 },
                    { 24, 3, "strawberries, banana, fat burner & energizer (490 cal)", "https://olo-images-live.imgix.net/27/27972e4e183647009767b46ee3b264a6.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=20e43e9577b25e84a502730f919ba0a1", "Lean Machine", null, 5.99 },
                    { 25, 3, "strawberries, banana & choice of protein (470-520 cal)", "https://olo-images-live.imgix.net/1d/1d9910de321e440c94c3c9471918a3db.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2e57a7d5e373398af651c21488d786c7", "Muscle Blaster", null, 5.99 },
                    { 26, 3, "mango, fresh ginger, green apple, pineapple, carrot & orange juice (420 cal)", "https://olo-images-live.imgix.net/98/980be84ae5924334bd9b8897fb003da4.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=fe493f9bd8733bcabcea3d47695287d2", "Orange Ginger Glow", null, 5.99 },
                    { 27, 3, "peanut butter, banana, non-fat yogurt & choice of protein (690-740 cal)", "https://olo-images-live.imgix.net/2e/2ec2631d8d31498ab02cc4a1a8a24d4d.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=a32acae177207150e31bbbc6084decb0", "Peanut Paradise", null, 5.99 },
                    { 28, 3, "pomegranate, banana, cranberry & strawberries (520 cal)", "https://olo-images-live.imgix.net/eb/ebff537dff964fee891d1c8de09d9afa.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=b8f94e721fc6e5b6c8fcfb7201f5ed28", "Pomergranate Plunge", null, 5.99 },
                    { 29, 3, "strawberries, blueberries, cranberry, multivitamin, ground flaxseed, whole-grain oats, whey protein & Splenda® (410 cal)", "https://olo-images-live.imgix.net/0c/0c4bccfd4c854bb3a860af413f980364.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2af3e835a52c618b4b876f2c09335163", "Triple Berry Oat", null, 5.99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryId",
                keyValue: 3);
        }
    }
}
