using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mike.Domain.Entities;

namespace Mike.InfraEstructure.Data.Context
{
    public class MikeDBContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public MikeDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adicione configurações de modelo separadas
            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            // Adicione outras configurações de modelo separadas conforme necessário.
        }
    }
}
