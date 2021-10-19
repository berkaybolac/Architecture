using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.FluentValidation
{
    public class CategoriesConfiguration: IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(p=>p.CategoryID);

            builder.Property(p => p.CategoryName).HasMaxLength(15).IsRequired();

            builder.Property(p => p.Description).HasMaxLength(500);
        }
    }
}