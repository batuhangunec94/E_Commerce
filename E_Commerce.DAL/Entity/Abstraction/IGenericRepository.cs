using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace E_Commerce.DAL.Entity.Abstraction
{
    public interface IGenericRepository<T>
    {
        T GetByID(int id);
        T GetOne(Expression<Func<T, bool>> filter);

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null);

        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
