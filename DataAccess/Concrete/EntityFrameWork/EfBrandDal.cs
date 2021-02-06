using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                return filter == null ?
                    context.Set<Brand>().ToList()
                    :
                    context.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand entity)
        {
            using (NewDatabaseContext context = new NewDatabaseContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
