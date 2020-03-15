using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.ToTable("ProductsInCategories");

            builder.HasKey(t => new {t.CategoryId, t.ProductId});

            builder.HasOne(t => t.Product).WithMany(pc => pc.ProductsInCategories)
                .HasForeignKey(pc => pc.ProductId);

            builder.HasOne(c => c.Category).WithMany(pc => pc.ProductsInCategories)
                .HasForeignKey(ct => ct.CategoryId);

        }
    }
}
