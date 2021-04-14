using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Web.Models
{
    public class ProductDetailsModel
    {
        public Product product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
