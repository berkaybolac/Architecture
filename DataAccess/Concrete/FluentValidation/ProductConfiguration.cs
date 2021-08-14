using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.FluentValidation
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasKey(p => p.ProductID);

            builder.Property(p => p.ProductName).
                HasMaxLength(40).
                IsRequired();

            builder.Property(p => p.QuantityPerUnit).
                HasMaxLength(20);

            builder.Property(p => p.UnitsInStock).
                HasDefaultValue(0);

            builder.Property(p => p.UnitsOnOrder).
                HasDefaultValue(0);

            builder.Property(p => p.ReorderLevel).
                HasDefaultValue(0);

            builder.Property(p => p.Discontinued).
                HasDefaultValue(0);

            builder.HasOne(p => p.Category).
                WithMany(p => p.Products).
                HasForeignKey("FK_Products_Categories");
        }
    }
}