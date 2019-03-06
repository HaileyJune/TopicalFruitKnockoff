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
            modelBuilder.Entity<Item>().HasData(
                new Item() { ItemId = 1, Name = "Mango Tumeric", Description = "unsweetened vanilla almond milk, mango, pineapple & turmeric", ImgUrl = "https://olo-images-live.imgix.net/bf/bfd6170e52ec44259f5745202c350e09.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=2af6f386acd3bbd2b1cc5d1b4a47aebc", Price = 5.29, CatagoryId = 1 },
                new Item() { ItemId = 2, Name = "Strawberry Granola", Description = "unsweetened vanilla almond milk, strawberries, cinnamon & topped with granola", ImgUrl = "https://olo-images-live.imgix.net/fc/fcc5c1cb95a34a6a9feb446c48099e48.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=0a8b0e6c1abe042d19719a48067d02b1", Price = 5.29, CatagoryId = 1 },
                new Item() { ItemId = 3, Name = "Bahama Mama", Description = "strawberries, pineapple, white chocolate & coconut (500 cal)", ImgUrl = "https://olo-images-live.imgix.net/fb/fb690aae84b64c148317ac7809183f4b.png?auto=format%2Ccompress&q=60&cs=tinysrgb&w=170&h=113&fit=crop&s=d67aa2c28779fdc6858aef8d8f410eb2", Price = 5.99, CatagoryId = 2 }
            );

            modelBuilder.Entity<Catagory>().HasData(
                new Catagory {CatagoryId = 1, Name = "Featured Products", Desctiption = "", ImgUrl = "Testing"},
                new Catagory {CatagoryId = 2, Name = "Classic Smoothies", Desctiption = "All smoothies are 24 oz. and made with turbinado unless otherwise noted or requested. Splenda substitute available.", ImgUrl = "Testing"}
            );
        }
    }
}