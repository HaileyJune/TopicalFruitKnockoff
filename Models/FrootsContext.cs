using Microsoft.EntityFrameworkCore;

namespace TopicalFruitKnockoff.Models
{
    public class FrootsContext : DbContext
    {
        public FrootsContext(DbContextOptions options) : base(options) {}
    
        public DbSet<Item> Items{get;set;}
        public DbSet<Catagory> Catagories{get;set;}
        public DbSet<Order> Order{get;set;}
    }
}