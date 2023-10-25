using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Loja.Infrastructure.Data.EntitiesConfiguration;

public class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
{
    public void Configure(EntityTypeBuilder<ProductEntity> builder)
    {
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(300);
        builder.Property(e => e.PurchasePrice).HasPrecision(18, 2).IsRequired();
        builder.Property(e => e.SellingPrice).HasPrecision(18, 2).IsRequired();
        builder.Property(e => e.Quantity).IsRequired();
        builder.Property(e => e.Weight);
        builder.Property(e => e.Dimensions).HasMaxLength(15);
        builder.Property(e => e.ImageUrl).HasMaxLength(150);
        builder.Property(e => e.AdditionalNotes).HasMaxLength(300);
        builder.Property(e => e.Barcode).HasMaxLength(20).IsRequired();
        builder.Property(e => e.AlertLevel).IsRequired();
        builder.Property(e => e.CriticalLevel).IsRequired();
        builder.Property(e => e.Available).IsRequired();
        builder.Property(e => e.Active).IsRequired();
    }
}