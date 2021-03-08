using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip olabilir demek
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T>where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T GetById(Expression<Func<T, bool>> filter);//GetById    Get olabilir!!!
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
