using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerPortal.Repositories.Abstraction;


namespace CustomerPortal.Repositories.Implementation
{
    public class BaseRepository<TEntity, TDataContext> : IBaseRepository<TEntity> where TEntity : class, new() where TDataContext : DbContext
    {
        protected readonly DbContext DbContext;
        public BaseRepository(DbContext context)
        {
            DbContext = context;
        }

        public TEntity GetById(int id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>().ToList();
        }

        public void Add(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
        }
        public void AddRange(TEntity entity)
        {
            DbContext.Set<TEntity>().AddRange(entity);
        }

        public void Remove(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
        }
        public void RemoveRange(TEntity entity)
        {
            DbContext.Set<TEntity>().RemoveRange(entity);
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await DbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task <List<TEntity>> GetAllAsync()
        {
            return await DbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            DbContext.Set<TEntity>().Add(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }
        public async Task<TEntity> AddRangeAsync(TEntity entity)
        {
            DbContext.Set<TEntity>().AddRange(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            DbContext.Set<TEntity>().Remove(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }
        public async Task RemoveRangeAsync(List<TEntity> entity)
        {
            DbContext.Set<TEntity>().RemoveRange(entity);
            await DbContext.SaveChangesAsync();
        }
        
        public async Task UpdateAsync(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            await DbContext.SaveChangesAsync();

        }
    }
}
