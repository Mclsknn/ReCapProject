using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{   
    //generic constraint
    //class : referans tip olabilir
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : newlenebilir olmalı

   public interface IEntityRepository<T> where T:class,IEntity,new()
    {  //filter = null filtre vermeyedebilir
        List<T> GetAll(Expression<Func<T,bool>> filter =null);
        T Get(Expression<Func<T, bool>> filter);
        T GetById(int Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
