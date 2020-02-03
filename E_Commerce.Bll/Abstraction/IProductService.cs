using E_Commerce.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Bll.Abstraction
{
    public interface IProductService
    {
        Product GetByID(int id);
        List<Product> GetAll();
        void Create(Product entity);

        void Update(Product entity);

        void Delete(Product entity);


    }
}
