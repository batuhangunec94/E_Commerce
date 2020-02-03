using E_Commerce.Bll.Abstraction;
using E_Commerce.DAL.Entity.Abstraction;
using E_Commerce.Model.Entity.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace E_Commerce.Bll.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Create(Category entity)
        {
            _categoryDal.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll().ToList();
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
