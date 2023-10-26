using Microsoft.Extensions.DependencyInjection;
using Mike.Domain.Repositories;
using Mike.InfraEstructure.Data.Repositories;

namespace Mike.InfraEstructure.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepository(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
