using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Webshop.Entities;

namespace Webshop.DataAccess
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = "1",
                        Name = "VIRGIL TRUCKER - Spijkerjas",
                        Description = "This is a description",
                        SKU = "1589420",
                        Category = "Jackets",
                        Price = 2799,
                        Stock = 1,
                    },
                    new Product
                    {
                        Id = "2",
                        Name = "ASOS DESIGN smart tapered trousers in black",
                        Description = "This is a description",
                        SKU = "1572163",
                        Category = "Trousers",
                        Price = 3499,
                        Stock = 10,
                    }
                );
        }
    }
}
