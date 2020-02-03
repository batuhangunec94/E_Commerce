using E_Commerce.DAL.Entity.Abstraction;
using E_Commerce.DAL.Entity.Concrete.EfCore.Context;
using E_Commerce.Model.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.DAL.Entity.Concrete.EfCore
{
    public class EfCoreProductDal:EfCoreBaseGenericRepository<Product>,IProductDal
    {
        public EfCoreProductDal(ProjectContext db):base(db)
        {

        }
        public ProjectContext db
        {
            get { return db as ProjectContext; }
        }
    }
}
