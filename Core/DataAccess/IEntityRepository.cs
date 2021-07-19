using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // t desem hangi tip gelirse o olur 
  public  interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //filtreleme yapmak için 
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
  
    }
}
