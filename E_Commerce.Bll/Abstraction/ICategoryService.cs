using E_Commerce.Model.Entity.Concrete;
using System.Collections.Generic;

namespace E_Commerce.Bll.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);
    }
}
