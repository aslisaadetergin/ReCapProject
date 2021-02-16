﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetById();
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtrelemede 
        T Get(Expression<Func<T, bool>> filter);  //bir şeyin detayını getirirken

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
