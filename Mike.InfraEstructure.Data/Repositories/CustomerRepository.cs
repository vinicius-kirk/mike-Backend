using Mike.Domain.Entities;
using Mike.Domain.Repositories;
using Mike.InfraEstructure.Data.Context;

namespace Mike.InfraEstructure.Data.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContextData dbContextData) : base(dbContextData)
        {
        }
    }
}
