using Microsoft.Extensions.DependencyInjection;

namespace Mike.InfraEstructure.CrossCutting.InversionOfControl
{
    public static class ContextDependency
    {
        public static void AddContext(this IServiceCollection serviceDescriptors, string connection)
        {
            //serviceDescriptors.AddDbContext<DbContextData>(
            //                  options => options.UseSqlServer(connection));
        }
    }
}
