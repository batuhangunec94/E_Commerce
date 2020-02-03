using E_Commerce.DAL.Entity.Abstraction;
using E_Commerce.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace E_Commerce.DAL.Entity.Concrete.Memory
{
    public class MemoryProductDal : IProductDal 
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product(){ID = 1, Title = "Samsung S6", Image = "1.jpg", Price=1000},
                new Product(){ID = 2, Title = "Samsung S7", Image = "2.jpg", Price=2000},
                new Product(){ID = 3, Title = "Samsung S8", Image = "3.jpg", Price=3000}
            };
            return products;
        }

        public Product GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
