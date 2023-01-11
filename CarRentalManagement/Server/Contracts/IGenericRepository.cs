﻿using System.Linq.Expressions;

namespace CarRentalManagement.Server.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>> Expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
        );
         
        Task<T> GetAsync(
            Expression<Func<T, bool>> expression,
            List<string> includes = null
        );

        Task InsertAsync(T entity);
        Task InsertRangeAsync(IEnumerable<T> entities);
        Task DeleteAsync(int id);
        void DeleteRange(IEnumerable<T> entities);
        void Update(T entity);
    }
}
