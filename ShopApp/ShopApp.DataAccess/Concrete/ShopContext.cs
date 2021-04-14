using Microsoft.EntityFrameworkCore;
using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public class ShopContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //connection 2
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8DDK0UD;Database=ShopDb;integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>()
                  .HasKey(c => new { c.CategoryId, c.ProductId });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }



    }
}
