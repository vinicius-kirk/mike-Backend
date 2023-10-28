using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mike.Domain.Entities;
using Mike.Domain.Models;
using Mike.InfraEstructure.Data.Context.Configuration;
using System.IO;

namespace Mike.InfraEstructure.Data.Context
{
    public class MikeDBContext : DbContext
    {
        public MikeDBContext()
        {
        }

        public MikeDBContext(DbContextOptions<MikeDBContext> options)
        :base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Mike;User ID=sa;Password=Tac@Pik4;TrustServerCertificate=true;");
            }
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new SubcategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountConfiguration());
        }
    }
}
