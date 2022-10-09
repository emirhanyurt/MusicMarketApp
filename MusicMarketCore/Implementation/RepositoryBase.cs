using Microsoft.EntityFrameworkCore;
using MusicMarketCore.Contracts;
using MusicMarketCore.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MusicMarketCore.Implementation
{
    public class RepositoryBase<TEntity>: IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly Context _ctx;

        public RepositoryBase(Context ctx)
        {
            _ctx = ctx;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _ctx.Set<TEntity>().AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _ctx.Set<TEntity>().AddRangeAsync(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _ctx.Set<TEntity>().Where(predicate);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _ctx.Set<TEntity>().ToListAsync();
        }

        public  ValueTask<TEntity> GetByIdAsync(int id)
        {
            return  _ctx.Set<TEntity>().FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _ctx.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _ctx.Set<TEntity>().RemoveRange(entities);
        }

        public Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return  _ctx.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }

        public Task UpdateAsync(TEntity entity)
        {
            _ctx.Entry(entity).State = EntityState.Modified;
            return _ctx.SaveChangesAsync();
        }
    }
}
