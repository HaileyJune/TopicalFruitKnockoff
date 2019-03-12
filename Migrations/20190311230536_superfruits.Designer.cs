﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TopicalFruitKnockoff.Models;

namespace TopicalFruitKnockoff.Migrations
{
    [DbContext(typeof(FrootsContext))]
    [Migration("20190311230536_superfruits")]
    partial class superfruits
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TopicalFruitKnockoff.Models.Catagory", b =>
                {
                    b.Property<int>("CatagoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Desctiption");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.HasKey("CatagoryId");

                    b.ToTable("Catagories");

                    b.HasData(
                        new { CatagoryId = 1, Active = true, Desctiption = "", ImgUrl = "wwwroot/images/Featured.PNG", Name = "Featured Products" },
                        new { CatagoryId = 2, Active = false, Desctiption = "All smoothies are 24 oz. and made with turbinado unless otherwise noted or requested. Splenda substitute available.", ImgUrl = "wwwroot/images/Classic.PNG", Name = "Classic Smoothies" },
                        new { CatagoryId = 3, Active = false, Desctiption = "All smoothies are 24 oz. and made with turbinado unless otherwise noted or requested. Splenda substitute available.", ImgUrl = "wwwroot/images/Classic.PNG", Name = "Supterfood Smoothies" }
                    );
                });

            modelBuilder.Entity("TopicalFruitKnockoff.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CatagoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<double>("Price");

                    b.HasKey("ItemId");

                    b.HasIndex("CatagoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Items");

                    b.HasData(
                        new { ItemId = 1, CatagoryId = 1, Description = "unsweetened vanilla almond milk, mango, pineapple & turmeric", ImgUrl = "https://olo-images-live.imgix.net/bf/bfd6170e52ec44259f5745202c350e09.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2af6f386acd3bbd2b1cc5d1b4a47aebc", Name = "Mango Tumeric", Price = 5.29 },
                        new { ItemId = 2, CatagoryId = 1, Description = "unsweetened vanilla almond milk, strawberries, cinnamon & topped with granola", ImgUrl = "https://olo-images-live.imgix.net/fc/fcc5c1cb95a34a6a9feb446c48099e48.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=0a8b0e6c1abe042d19719a48067d02b1", Name = "Strawberry Granola", Price = 5.29 },
                        new { ItemId = 3, CatagoryId = 2, Description = "strawberries, pineapple, white chocolate & coconut (500 cal)", ImgUrl = "https://olo-images-live.imgix.net/fb/fb690aae84b64c148317ac7809183f4b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d67aa2c28779fdc6858aef8d8f410eb2", Name = "Bahama Mama", Price = 5.99 },
                        new { ItemId = 4, CatagoryId = 2, Description = "strawberries, banana & chocolate (550 cal)", ImgUrl = "https://olo-images-live.imgix.net/65/65ab2c0b569340f29f5a3da024823e4a.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=445c97f5c2d6193d0ce16265b3ffbac1", Name = "Beach Bum", Price = 5.99 },
                        new { ItemId = 5, CatagoryId = 2, Description = "strawberries, pineapple, orange juice & lime (440 cal)", ImgUrl = "https://olo-images-live.imgix.net/01/01d5829cb85c478ca1a15b6ac883e27b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=f46625f9b3039d2c777ae878a8112011", Name = "Blimey Limey", Price = 5.99 },
                        new { ItemId = 6, CatagoryId = 2, Description = "blueberries, strawberries & banana (340 cal)", ImgUrl = "https://olo-images-live.imgix.net/a4/a40d91f6251b4b40a86924fc08923f82.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=5104934fc1165c67f015302827dcc56d", Name = "Blueberry Bliss", Price = 5.99 },
                        new { ItemId = 7, CatagoryId = 2, Description = "strawberries & banana (370 cal)", ImgUrl = "https://olo-images-live.imgix.net/36/36dd4be35fab41b8ae9d152a40744354.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=4800891004b7bad0e7eb85792b74da13", Name = "Jerry Punch", Price = 5.99 },
                        new { ItemId = 8, CatagoryId = 2, Description = "kiwi, strawberries & non-fat yogurt (450 cal)", ImgUrl = "https://olo-images-live.imgix.net/82/82625c4eadf849c9b0540370fdb98000.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=84efefe5c7957d8853edd86a6669c968", Name = "Kiwi Quencher", Price = 5.99 },
                        new { ItemId = 9, CatagoryId = 2, Description = "mango, pineapple & non-fat yogurt (400 cal)", ImgUrl = "https://olo-images-live.imgix.net/2d/2d7b7393d6d04ae983368fe531f933e2.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=84c7698fe93f22790790cb8d4419c3ab", Name = "Mango Magic", Price = 5.99 },
                        new { ItemId = 10, CatagoryId = 2, Description = "cholocate, coffee, cappuccino & non-fat yogurt (available in decaf) (660 cal)", ImgUrl = "https://olo-images-live.imgix.net/6b/6b65403c1fd14c0fb1f71540b3be40f3.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=3aa4b2b1c6d1324fec82bcd1c28d3758", Name = "Mocha Madness", Price = 5.99 },
                        new { ItemId = 11, CatagoryId = 2, Description = "strawberries, banana & pineapple (430 cal)", ImgUrl = "https://olo-images-live.imgix.net/3c/3cdb5fad022041ddb07581682d1c2ea5.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=318a6a03002d930cfe0452caa2809bff", Name = "Paradise Point", Price = 5.99 },
                        new { ItemId = 12, CatagoryId = 2, Description = "peaches, strawberries & banana (360 cal)", ImgUrl = "https://olo-images-live.imgix.net/c7/c7117a873686420695ebead4ab1e07cc.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d41e797ad0e0f38e9b53d5ee71b8c418", Name = "Peaches 'N Silk", Price = 5.99 },
                        new { ItemId = 13, CatagoryId = 2, Description = "peanut butter, banana & chocolate (710 cal)", ImgUrl = "https://olo-images-live.imgix.net/23/2356a719f82b4add9261d3feb980a5b2.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=acd288ab71b73531b5988ed071ba0f02", Name = "Peanut Butter Cup", Price = 5.99 },
                        new { ItemId = 14, CatagoryId = 2, Description = "strawberries & lime (470 cal)", ImgUrl = "https://olo-images-live.imgix.net/c2/c240162fe4ce4d0588c9296d5972b84c.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2daddf7dbef2d8c3a1da38c43d315bf7", Name = "Strawberry Limeade", Price = 5.99 },
                        new { ItemId = 15, CatagoryId = 2, Description = "strawberries, pineapple, mango, & orange juice (360 cal)", ImgUrl = "https://olo-images-live.imgix.net/1f/1f191046fa2c4c348cb010097c309067.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2017ac3dfab75f2fc77acfbcfc361e40", Name = "Sunrise Sunset", Price = 5.99 },
                        new { ItemId = 16, CatagoryId = 2, Description = "mango, banana, orange, pineapple & orange juice (390 cal)", ImgUrl = "https://olo-images-live.imgix.net/36/36cadc17481c4748a1e20719f4eb2bc6.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=db913f5191c70cc66ffbcbd16c4688b5", Name = "Sunshine", Price = 5.99 },
                        new { ItemId = 17, CatagoryId = 3, Description = "acai, pomegranate, banana, blueberries & strawberries (470 cal)", ImgUrl = "https://olo-images-live.imgix.net/a1/a1a8fdaaac2c4e04ba1c17169d858015.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=fd1ee10da835e0eeece9b4c81f17479e", Name = "Aci Berry Boost", Price = 5.99 },
                        new { ItemId = 18, CatagoryId = 3, Description = "avocado, pineapple, spinach, kale, coconut & lime (600 cal)", ImgUrl = "https://olo-images-live.imgix.net/a4/a49cc30189f243338cb3ffecb61c0a3c.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=da6c1c885d1f8f0d13aae372dac436a2", Name = "Avacolada", Price = 5.99 },
                        new { ItemId = 19, CatagoryId = 3, Description = "roasted banana, chia seeds, almonds, whole-grain oats, cinnamon, dates & coconut with choice of strawberries or peanut butter (610/780 cal)", ImgUrl = "https://olo-images-live.imgix.net/83/8339eb02d5b54862885f0976b63d4ba4.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=5c94e1f71088f3c60c9465a8c6545f58", Name = "Chia Banana Boosy", Price = 5.99 },
                        new { ItemId = 20, CatagoryId = 3, Description = "Chia Banana Boost, plus peanut butter & whey for max protein! Additional supplement charge applies. (880 cal)", ImgUrl = "https://olo-images-live.imgix.net/a1/a1ecd254a1284cd680dd5b0414fdad88.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=3aeaa6066de20fff76ee59d1259c50a0", Name = "Chia Banana Max", Price = 5.99 },
                        new { ItemId = 21, CatagoryId = 3, Description = "spinach, kale, mango, pineapple, banana & fresh ginger (naturally sweetened) (180 cal)", ImgUrl = "https://olo-images-live.imgix.net/d6/d6668cbf322145ef861746fdec275fe8.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=1f07cdad2cebf2799256c014b686ac53", Name = "Detox Island Green", Price = 5.99 },
                        new { ItemId = 22, CatagoryId = 3, Description = "blueberries, mango, banana, almonds & choice of protein (520-570 cal)", ImgUrl = "https://olo-images-live.imgix.net/b3/b3692e8640984fc7850c4a51ddd489c0.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=408087148e29164d8c4b25ea7bade6de", Name = "Health Nut", Price = 5.99 },
                        new { ItemId = 23, CatagoryId = 3, Description = "spinach, kale, mango, pineapple & banana (410 cal)", ImgUrl = "https://olo-images-live.imgix.net/75/75e22c8022774ef2959fa03889aaea65.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=4f4cc3c07b8f76a9377291d66331b91c", Name = "Island Green", Price = 5.99 },
                        new { ItemId = 24, CatagoryId = 3, Description = "strawberries, banana, fat burner & energizer (490 cal)", ImgUrl = "https://olo-images-live.imgix.net/27/27972e4e183647009767b46ee3b264a6.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=20e43e9577b25e84a502730f919ba0a1", Name = "Lean Machine", Price = 5.99 },
                        new { ItemId = 25, CatagoryId = 3, Description = "strawberries, banana & choice of protein (470-520 cal)", ImgUrl = "https://olo-images-live.imgix.net/1d/1d9910de321e440c94c3c9471918a3db.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2e57a7d5e373398af651c21488d786c7", Name = "Muscle Blaster", Price = 5.99 },
                        new { ItemId = 26, CatagoryId = 3, Description = "mango, fresh ginger, green apple, pineapple, carrot & orange juice (420 cal)", ImgUrl = "https://olo-images-live.imgix.net/98/980be84ae5924334bd9b8897fb003da4.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=fe493f9bd8733bcabcea3d47695287d2", Name = "Orange Ginger Glow", Price = 5.99 },
                        new { ItemId = 27, CatagoryId = 3, Description = "peanut butter, banana, non-fat yogurt & choice of protein (690-740 cal)", ImgUrl = "https://olo-images-live.imgix.net/2e/2ec2631d8d31498ab02cc4a1a8a24d4d.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=a32acae177207150e31bbbc6084decb0", Name = "Peanut Paradise", Price = 5.99 },
                        new { ItemId = 28, CatagoryId = 3, Description = "pomegranate, banana, cranberry & strawberries (520 cal)", ImgUrl = "https://olo-images-live.imgix.net/eb/ebff537dff964fee891d1c8de09d9afa.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=b8f94e721fc6e5b6c8fcfb7201f5ed28", Name = "Pomergranate Plunge", Price = 5.99 },
                        new { ItemId = 29, CatagoryId = 3, Description = "strawberries, blueberries, cranberry, multivitamin, ground flaxseed, whole-grain oats, whey protein & Splenda® (410 cal)", ImgUrl = "https://olo-images-live.imgix.net/0c/0c4bccfd4c854bb3a860af413f980364.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2af3e835a52c618b4b876f2c09335163", Name = "Triple Berry Oat", Price = 5.99 }
                    );
                });

            modelBuilder.Entity("TopicalFruitKnockoff.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("TopicalFruitKnockoff.Models.Item", b =>
                {
                    b.HasOne("TopicalFruitKnockoff.Models.Catagory", "Catagory")
                        .WithMany("Items")
                        .HasForeignKey("CatagoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TopicalFruitKnockoff.Models.Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}