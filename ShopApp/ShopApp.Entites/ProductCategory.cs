using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entites
{
    public class ProductCategory
    {//çift taraflı çoklu ilişki 
      
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}
