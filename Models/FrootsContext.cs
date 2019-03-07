using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TopicalFruitKnockoff.Models
{
    public class FrootsContext : DbContext
    {
        public FrootsContext(DbContextOptions options) : base(options) {}
    
        public DbSet<Item> Items{get;set;}
        public DbSet<Catagory> Catagories{get;set;}
        public DbSet<Order> Order{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasOne(d => d.Catagory)
                    .WithMany(p => p.Items)
                    .HasForeignKey("CatagoryId");
            });

            modelBuilder.Entity<Item>().HasData(
                new Item() { ItemId = 1, Name = "Mango Tumeric", Description = "unsweetened vanilla almond milk, mango, pineapple & turmeric", ImgUrl = "https://olo-images-live.imgix.net/bf/bfd6170e52ec44259f5745202c350e09.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2af6f386acd3bbd2b1cc5d1b4a47aebc", Price = 5.29, CatagoryId = 1 },
                new Item() { ItemId = 2, Name = "Strawberry Granola", Description = "unsweetened vanilla almond milk, strawberries, cinnamon & topped with granola", ImgUrl = "https://olo-images-live.imgix.net/fc/fcc5c1cb95a34a6a9feb446c48099e48.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=0a8b0e6c1abe042d19719a48067d02b1", Price = 5.29, CatagoryId = 1 },
                
                new Item() { ItemId = 3, Name = "Bahama Mama", Description = "strawberries, pineapple, white chocolate & coconut (500 cal)", ImgUrl = "https://olo-images-live.imgix.net/fb/fb690aae84b64c148317ac7809183f4b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d67aa2c28779fdc6858aef8d8f410eb2", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 4, Name = "Beach Bum", Description = "strawberries, banana & chocolate (550 cal)", ImgUrl = "https://olo-images-live.imgix.net/65/65ab2c0b569340f29f5a3da024823e4a.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=445c97f5c2d6193d0ce16265b3ffbac1", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 5, Name = "Blimey Limey", Description = "strawberries, pineapple, orange juice & lime (440 cal)", ImgUrl = "https://olo-images-live.imgix.net/01/01d5829cb85c478ca1a15b6ac883e27b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=f46625f9b3039d2c777ae878a8112011", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 6, Name = "Blueberry Bliss", Description = "blueberries, strawberries & banana (340 cal)", ImgUrl = "https://olo-images-live.imgix.net/a4/a40d91f6251b4b40a86924fc08923f82.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=5104934fc1165c67f015302827dcc56d", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 7, Name = "Jerry Punch", Description = "strawberries & banana (370 cal)", ImgUrl = "https://olo-images-live.imgix.net/36/36dd4be35fab41b8ae9d152a40744354.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=4800891004b7bad0e7eb85792b74da13", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 8, Name = "Kiwi Quencher", Description = "kiwi, strawberries & non-fat yogurt (450 cal)", ImgUrl = "https://olo-images-live.imgix.net/82/82625c4eadf849c9b0540370fdb98000.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=84efefe5c7957d8853edd86a6669c968", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 9, Name = "Mango Magic", Description = "mango, pineapple & non-fat yogurt (400 cal)", ImgUrl = "https://olo-images-live.imgix.net/2d/2d7b7393d6d04ae983368fe531f933e2.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=84c7698fe93f22790790cb8d4419c3ab", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 10, Name = "Mocha Madness", Description = "cholocate, coffee, cappuccino & non-fat yogurt (available in decaf) (660 cal)", ImgUrl = "https://olo-images-live.imgix.net/6b/6b65403c1fd14c0fb1f71540b3be40f3.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=3aa4b2b1c6d1324fec82bcd1c28d3758", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 11, Name = "Paradise Point", Description = "strawberries, banana & pineapple (430 cal)", ImgUrl = "https://olo-images-live.imgix.net/3c/3cdb5fad022041ddb07581682d1c2ea5.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=318a6a03002d930cfe0452caa2809bff", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 12, Name = "Peaches 'N Silk", Description = "peaches, strawberries & banana (360 cal)", ImgUrl = "https://olo-images-live.imgix.net/c7/c7117a873686420695ebead4ab1e07cc.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d41e797ad0e0f38e9b53d5ee71b8c418", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 13, Name = "Peanut Butter Cup", Description = "peanut butter, banana & chocolate (710 cal)", ImgUrl = "https://olo-images-live.imgix.net/23/2356a719f82b4add9261d3feb980a5b2.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=acd288ab71b73531b5988ed071ba0f02", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 14, Name = "Strawberry Limeade", Description = "strawberries & lime (470 cal)", ImgUrl = "https://olo-images-live.imgix.net/c2/c240162fe4ce4d0588c9296d5972b84c.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2daddf7dbef2d8c3a1da38c43d315bf7", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 15, Name = "Sunrise Sunset", Description = "strawberries, pineapple, mango, & orange juice (360 cal)", ImgUrl = "https://olo-images-live.imgix.net/1f/1f191046fa2c4c348cb010097c309067.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2017ac3dfab75f2fc77acfbcfc361e40", Price = 5.99, CatagoryId = 2 },
                new Item() { ItemId = 16, Name = "Sunshine", Description = "mango, banana, orange, pineapple & orange juice (390 cal)", ImgUrl = "https://olo-images-live.imgix.net/36/36cadc17481c4748a1e20719f4eb2bc6.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=db913f5191c70cc66ffbcbd16c4688b5", Price = 5.99, CatagoryId = 2 }
            );


            modelBuilder.Entity<Catagory>().HasData(
                new Catagory {CatagoryId = 1, Name = "Featured Products", Desctiption = "", ImgUrl = "wwwroot/images/Featured.PNG", Active = true},
                new Catagory {CatagoryId = 2, Name = "Classic Smoothies", Desctiption = "All smoothies are 24 oz. and made with turbinado unless otherwise noted or requested. Splenda substitute available.", ImgUrl = "wwwroot/images/Classic.PNG", Active = false}
            );
        }
    }
}