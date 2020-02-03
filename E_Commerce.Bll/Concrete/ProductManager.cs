﻿using E_Commerce.Bll.Abstraction;
using E_Commerce.DAL.Entity.Abstraction;
using E_Commerce.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E_Commerce.Bll.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Create(Product entity)
        {
            _productDal.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList();
        }

        public Product GetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
