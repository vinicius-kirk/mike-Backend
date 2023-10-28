using Mike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mike.Domain.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> Add(T entity);
        Task<T> GetByID(int id);
        Task<IEnumerable<T>> GetAll(Func<T, bool> func);
        Task<T> Put(T entity);
        Task Delete(int id);
    }
}
