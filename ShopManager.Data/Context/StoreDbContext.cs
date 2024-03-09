using Microsoft.EntityFrameworkCore;
using ShopManager.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Data.Context
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
             : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add 10 products with real names and prices
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "iPhone 12", Price = 999.99m },
                new Product { Id = 2, Name = "Samsung Galaxy S21", Price = 899.99m },
                new Product { Id = 3, Name = "Google Pixel 5", Price = 699.99m },
                new Product { Id = 4, Name = "Sony PlayStation 5", Price = 499.99m },
                new Product { Id = 5, Name = "Xbox Series X", Price = 499.99m },
                new Product { Id = 6, Name = "Nintendo Switch", Price = 299.99m },
                new Product { Id = 7, Name = "Apple AirPods Pro", Price = 249.99m },
                new Product { Id = 8, Name = "Samsung 4K Smart TV", Price = 1499.99m },
                new Product { Id = 9, Name = "Dell XPS 13 Laptop", Price = 1299.99m },
                new Product { Id = 10, Name = "Logitech G502 Gaming Mouse", Price = 79.99m }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
