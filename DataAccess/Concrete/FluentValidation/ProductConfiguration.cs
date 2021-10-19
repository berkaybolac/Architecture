using Entities.Entities;
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

            builder.HasOne(d => d.Category)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryID)
                .HasConstraintName("FK_Products_Categories");
        }
    }
}