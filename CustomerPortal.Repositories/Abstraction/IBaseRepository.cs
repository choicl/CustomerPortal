using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CustomerPortal.Repositories.Abstraction
{
    public interface IBaseRepository<TEntity> where TEntity : class, new()
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        
        void Add(TEntity entity);
        void AddRange(TEntity entity);

        void Remove(TEntity entity);
        void RemoveRange(TEntity entity);

        Task<TEntity> GetByIdAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> AddRangeAsync(TEntity entity);
        Task<TEntity> RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(List<TEntity> entity);
        Task UpdateAsync(TEntity entity);

    }
}
