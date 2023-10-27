using Mike.Domain.Entities;
using Mike.Domain.Repositories;
using Mike.InfraEstructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Mike.InfraEstructure.Data.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : Entity
    {
        protected readonly MikeDBContext _dbContextData;

        public BaseRepository(MikeDBContext dbContextData)
        {
            _dbContextData = dbContextData;
        }

        public async Task<T> Put(T entity)
        {
            _dbContextData.Update(entity);
            await _dbContextData.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> GetAll(Func<T, bool> func)
        {
            return await _dbContextData.Set<T>().Where(func).AsQueryable().ToListAsync();
        }

        public async Task<T> GetByID(Guid id)
        {
            return await _dbContextData.Set<T>().FindAsync(id);
        }

        public async Task<T> Add(T entity)
        {
            _dbContextData.Add(entity);
            await _dbContextData.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _dbContextData.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _dbContextData.Set<T>().Remove(entity);
                await _dbContextData.SaveChangesAsync();
            }

        }
    }
}
