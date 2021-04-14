using Microsoft.EntityFrameworkCore;
using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);

                }
                context.SaveChanges();
            }
        }
            private static Product[] Products =
        {
            new Product(){Name="Samsung S5",Price=2000,ImageUrl="1.png",Description="<p>güzel telefon</p>"},
            new Product(){Name="Samsung S6",Price=3000,ImageUrl="1.png",Description="<p>güzel telefon</p>"},
            new Product(){Name="Samsung S7",Price=4000,ImageUrl="2.jpg",Description="<p>güzel telefon</p>"},
            new Product(){Name="Samsung S8",Price=5000,ImageUrl="1.png",Description="<p>güzel telefon</p>"},
            new Product(){Name="İphone 6",Price=4000,ImageUrl="2.jpg",Description="<p>güzel telefon</p>"},
            new Product(){Name="iphone 7",Price=6000,ImageUrl="1.png",Description="<p>güzel telefon</p>"}
        };
       

        private static Category[] categories =
        {
            new Category(){Name="Telefon"},
            new Category(){Name="Bilgisayar"},
            new Category(){Name="Elektronik"}
            
        };

        private static ProductCategory[] ProductCategory =
       {
            new ProductCategory() { Product=Products[0], Category=categories[0]},
            new ProductCategory() { Product=Products[0], Category=categories[2]},
            new ProductCategory() { Product=Products[1], Category=categories[0]},
            new ProductCategory() { Product=Products[1], Category=categories[1]},
            new ProductCategory() { Product=Products[2], Category=categories[0]},
            new ProductCategory() { Product=Products[2], Category=categories[2]},
            new ProductCategory() { Product=Products[3], Category=categories[0]},
            new ProductCategory() { Product=Products[3], Category=categories[2]}

        };
    }
    }

