using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tecweb2.webapi.Contexts;
using tecweb2.webapi.Models.Entities.Base;

namespace tecweb2.webapi.Repositories.Base
{
    public class BaseRepository<TContext, TModel> : IBaseRepository<TModel>
        where TContext : SqlContext where TModel : BaseEntity
    {
        protected readonly TContext _context;
        protected readonly DbSet<TModel> _dbSet;

        public BaseRepository(TContext context, DbSet<TModel> dbSet)
        {
            this._context = context;
            this._dbSet = dbSet;
        }

        public async Task CreateAsync(TModel item)
        {
            _context.Set<TModel>().Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TModel item)
        {
            _context.Set<TModel>().Update(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TModel item)
        {
            _context.Set<TModel>().Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task CreateBatchAsync(IEnumerable<TModel> items)
        {
            _context.Set<TModel>().AddRange(items);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBatchAsync(IEnumerable<TModel> items)
        {
            _context.Set<TModel>().UpdateRange(items);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBatchAsync(IEnumerable<TModel> items)
        {
            _context.Set<TModel>().RemoveRange(items);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TModel>> GetAll()
        {
            return await this._context.Set<TModel>().Where(w => w.Active).AsNoTracking().ToListAsync();
        }

        public async Task<TModel> GetLastAsync()
        {
            return await this._context.Set<TModel>().Where(w => w.Active).OrderBy(o => o.Id).FirstOrDefaultAsync();
        }

        public Task<bool> AnyAsync(Expression<Func<TModel, bool>> predicate)
        {
            return this._context.Set<TModel>().Where(w => w.Active).AnyAsync<TModel>(predicate, new CancellationToken());
        }

        public Task<TModel> GetAsync(params object[] keyValues)
        {
            return this._context.Set<TModel>().FindAsync(keyValues);
        }
    }
}