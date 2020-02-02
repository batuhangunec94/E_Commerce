using E_Commerce.DAL.Entity.Abstraction;
using E_Commerce.DAL.Entity.Concrete.EfCore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace E_Commerce.DAL.Entity.Concrete.EfCore
{
    public class EfCoreBaseGenericRepository<T> : IGenericRepository<T>
        where T:class, new()
    {
        private readonly ProjectContext db;
        protected DbSet<T> table;
        public EfCoreBaseGenericRepository(ProjectContext _db)
        {
            db = _db;
            table = db.Set<T>();
        }
        public void Create(T entity)
        {
            table.Add(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            table.Remove(entity);
            db.SaveChanges();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return table.ToList();
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            return table.Where(filter).SingleOrDefault();
        }

        public void Update(T entity)
        {
            
            table.Update(entity);
            db.SaveChanges();
            
        }
    }
}
