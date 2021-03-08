using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            //using içine yazılan nesneler using bitince garbic collector tarafından temizlenir(bellekten atılır)
            //IDisposable pattern implementation of c#
            using (MyDatabaseContext context= new MyDatabaseContext())
            {
                var addedEntity = context.Entry(entity);//Referansı yakala
                addedEntity.State = EntityState.Added;//Bu eklenecek bir nesne
                context.SaveChanges();//Değişikliği kaydet
            }
        }
        public void Delete(Car entity)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var deletedEntity = context.Entry(entity);//Referansı yakala
                deletedEntity.State = EntityState.Deleted;//Bu silinecek bir nesne
                context.SaveChanges();//Değişikliği kaydet
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                return filter == null                            //Filtre null mı ?
                    ? context.Set<Car>().ToList()                //Evetse bura çalışır
                    : context.Set<Car>().Where(filter).ToList(); //Değilse bura çalışır
            }
        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Update(Car entity)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var updatedEntity = context.Entry(entity);//Referansı yakala
                updatedEntity.State = EntityState.Modified;//Bu güncellenecek bir nesne
                context.SaveChanges();//Değişikliği kaydet
            }
        }
    }
}
