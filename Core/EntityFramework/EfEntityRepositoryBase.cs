using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.EntityFramework
{
   public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class ,IEntity,new()
       where TContext:DbContext ,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())// böle yapınca gecici bellekden atar  contexti kullanmak için
            {
                var addedEntity = context.Entry(entity);//referansı yakaladık burda
                addedEntity.State = EntityState.Added;//durumu belirt
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())// böle yapınca gecici bellekden atar  contexti kullanmak için
            {
                var deletedEntity = context.Entry(entity);//referansı yakaladık burda
                deletedEntity.State = EntityState.Deleted;//durumu belirt
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())// böle yapınca gecici bellekden atar  contexti kullanmak için
            {
                var updatedEntity = context.Entry(entity);//referansı yakaladık burda
                updatedEntity.State = EntityState.Modified;//durumu belirt
                context.SaveChanges();
            }
        }

    }
}
