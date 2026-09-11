using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiProduct.Entity;

namespace WebApiProduct.Schema;

public class ProductSchema : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(p => p.Description)
            .HasMaxLength(500);
        builder.Property(p => p.Price)
            .HasColumnType("decimal(18,2)")
            .IsRequired();
        builder.Property(p => p.Stock)
            .IsRequired();
        builder.Property(p => p.CreatedAt)
            .HasDefaultValueSql("GETUTCDATE()")
            .IsRequired();
        builder.Property(p => p.UpdatedAt)
            .HasDefaultValueSql("GETUTCDATE()")
            .IsRequired();
        
        builder.HasIndex(p => p.Name)
            .HasDatabaseName("idx_product_name")
            .IsUnique();
    }
}