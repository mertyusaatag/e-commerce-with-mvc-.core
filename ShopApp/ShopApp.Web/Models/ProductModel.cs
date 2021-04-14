using ShopApp.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Web.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =1,ErrorMessage ="Ürün İsmi minimum 1 maxiumum 100 karakter")]
        public string Name { get; set; }
      
        public string ImageUrl { get; set; }
        [Required(ErrorMessage ="Fiyat Belirtiniz")]
        [Range(1,1000000)]
        public decimal? Price { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Ürün Açıklaması minimum 1 maxiumum 100 karakter")]
        public string Description { get; set; }

        public List<Category> SelectedCategories { get; set; }

    }
}
