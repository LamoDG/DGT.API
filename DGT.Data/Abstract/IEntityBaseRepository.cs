﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DGT.Data.Abstract
{
    public interface IEntityBaseRepository<T> where T : class
    {
  
        Task<IEnumerable<T>> GetAllAsync();

        Task<int> CountAsync();

        Task<T> GetSingleAsync(object id);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);


        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void DeleteWhere(Expression<Func<T, bool>> predicate);
    }
}
