using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce.Model.Entity.Concrete
{
    public class Product:Base
    {
        [Required]
        public string Title { get; set; }
        [MaxLength(200,ErrorMessage ="Max lenght 200")]
        public string Description { get; set; }
        public string Image { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
