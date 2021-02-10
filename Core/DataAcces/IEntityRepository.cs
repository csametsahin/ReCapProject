
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcces
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
