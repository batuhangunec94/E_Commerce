using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce.Model.Entity.Concrete
{
    public class Category:Base
    {
        [Required,MaxLength(20,ErrorMessage = "Max Lenght 20")]
        public string Name { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
