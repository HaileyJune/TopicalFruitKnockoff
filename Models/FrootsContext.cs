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
                new Item() { ItemId = 1, Name = "Mango", Description = "Mangoos", ImgUrl = "Testing", Price = 2.00, CatagoryId = 1 }
            );

            modelBuilder.Entity<Catagory>().HasData(
                new Catagory {CatagoryId = 1, Name = "Smoothies", Desctiption = "These are smoothies", ImgUrl = "Testing"}
            );
        }
    }
}