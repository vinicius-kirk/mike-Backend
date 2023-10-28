using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Mike.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mike.Domain.Models;

namespace Mike.InfraEstructure.Data.Context.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Description);
            builder.Property(p => p.Price).HasColumnType("decimal(18, 2)");
            builder.Property(p => p.Brand);
            builder.Property(p => p.Model);
            builder.Property(p => p.Color);
            builder.Property(p => p.Size);
            builder.Property(p => p.StockQuantity);
            builder.Property(p => p.ReleaseDate);
            builder.Property(p => p.LastRestockDate);
            builder.Property(p => p.Material);
            builder.Property(p => p.Style);
            builder.Property(p => p.Gender);
            builder.HasOne(p => p.Category).WithMany(d => d.Products);
            builder.HasOne(p => p.Subcategory);
            builder.Property(p => p.IsAvailable);
            builder.Property(p => p.IsFeatured);
            builder.Property(p => p.IsOnSale);
            builder.Property(p => p.AverageRating);
            builder.HasOne(p => p.Discount);
            builder.HasMany(p => p.Reviews)
           .WithOne(p => p.Product) 
           .HasForeignKey(p => p.ProductId); 
        }

    }

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.Name).IsRequired();
            builder.HasMany(c => c.Subcategories).WithOne(s => s.Category);
            builder.HasMany(c => c.Products).WithOne(p => p.Category);
        }
    }

    public class SubcategoryConfiguration : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasKey(s => s.SubcategoryId);
            builder.Property(s => s.Name).IsRequired();
        }
    }

    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasKey(d => d.DiscountId);
            builder.Property(d => d.Name).IsRequired();
            builder.Property(d => d.Amount).IsRequired();
            builder.Property(d => d.StartDate).IsRequired();
            builder.Property(d => d.EndDate).IsRequired();
        }
    }

    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(d => d.ReviewId);
            builder.Property(d => d.UserName).IsRequired();
            builder.Property(d => d.DatePosted).IsRequired();
            builder.Property(d => d.UserName).IsRequired();
            builder.Property(d => d.Comment).IsRequired();
            builder.HasOne(r => r.Product) 
            .WithMany(p => p.Reviews) 
            .HasForeignKey(r => r.ProductId);
        }
    }

}
