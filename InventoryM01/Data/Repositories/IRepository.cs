﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventoryM01.Data.Repositories
{
        public interface IRepository<T> where T : class
        {
            void Add(T entity);
            void AddRange(IEnumerable<T> entity);
            T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
            IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false);
            void Remove(T entity);
            void RemoveRange(IEnumerable<T> entity);
        }
    
}
