using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //using içine yazılan nesneler using bitince garbic collector tarafından temizlenir(bellekten atılır)
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);    //Referansı yakala
                addedEntity.State = EntityState.Added;      //Bu eklenecek bir nesne
                context.SaveChanges();                      //Değişikliği kaydet
            }
        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı yakala
                deletedEntity.State = EntityState.Deleted; //Bu silinecek bir nesne
                context.SaveChanges();                     //Değişikliği kaydet
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null                                 //Filtre null mı ?
                    ? context.Set<TEntity>().ToList()                //Evetse bura çalışır
                    : context.Set<TEntity>().Where(filter).ToList(); //Değilse bura çalışır
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); //Referansı yakala
                updatedEntity.State = EntityState.Modified;//Bu güncellenecek bir nesne
                context.SaveChanges();                     //Değişikliği kaydet
            }
        }
    }
}
