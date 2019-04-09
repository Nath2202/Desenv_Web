using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Repositories.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T item);

        Task UpdateAsync(T item);

        Task DeleteAsync(T item);

        Task<T> GetAsync(params object[] keyValues);

        Task<List<T>> GetAll();

        Task<T> GetLastAsync();

        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        Task CreateBatchAsync(IEnumerable<T> items);

        Task UpdateBatchAsync(IEnumerable<T> items);

        Task DeleteBatchAsync(IEnumerable<T> items);
    }
}