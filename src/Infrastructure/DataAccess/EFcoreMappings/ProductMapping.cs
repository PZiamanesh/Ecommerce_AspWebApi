using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.EFcoreMappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Price).IsRequired().HasColumnType("decimal(19,2)");
            builder.Property(x=>x.PictureUrl).IsRequired().HasMaxLength(500);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(500);
            builder.Property(x=>x.Summary).HasMaxLength(100);

            builder.HasOne(x => x.ProductBrand).WithMany().HasForeignKey(x => x.ProductBrandId);
            builder.HasOne(x => x.ProductType).WithMany().HasForeignKey(x => x.ProductTypeId);
        }
    }
}
