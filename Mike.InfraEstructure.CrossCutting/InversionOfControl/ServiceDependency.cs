using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Mike.Interface.Mapper;
using Mike.Interface.Services;
using Mike.Service.Service;

namespace Mike.InfraEstructure.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
      
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
        }
    }
}
