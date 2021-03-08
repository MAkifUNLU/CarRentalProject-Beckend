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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())//using içine yazdığımız şeyler bitince atılacak.
            {
                var addedEntity = context.Entry(entity);//Referansı yakala.
                addedEntity.State = EntityState.Added;//Bu eklenecek bir nesne
                context.SaveChanges();//Değişikliği kaydet
            }
        }

        public void Delete(Brand entity)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var deletedEntity = context.Entry(entity);//Referansı yakala
                deletedEntity.State = EntityState.Deleted;//Bu silinecek bir nesne
                context.SaveChanges();//Değişikliği kaydet
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                return filter == null                            //Filtre null mı ?
                    ? context.Set<Brand>().ToList()                //Evetse bura çalışır
                    : context.Set<Brand>().Where(filter).ToList(); //Değilse bura çalışır
            }
        }

        public Brand GetById(Expression<Func<Brand, bool>> filter)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public void Update(Brand entity)
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
