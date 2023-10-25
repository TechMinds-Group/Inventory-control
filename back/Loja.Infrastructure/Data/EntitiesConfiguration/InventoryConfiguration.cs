using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Loja.Infrastructure.Data.EntitiesConfiguration;

public class InventoryConfiguration : IEntityTypeConfiguration<InventoryEntity>
{
    public void Configure(EntityTypeBuilder<InventoryEntity> builder)
    {
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
        builder.Property(e => e.EntryDate).IsRequired();
        builder.Property(e => e.ExitDate);
        builder.Property(e => e.ExitReason).HasMaxLength(30);
        builder.Property(e => e.StorageLocation).HasMaxLength(150);
        builder.Property(e => e.AdditionalNotes).HasMaxLength(300);
        builder.Property(e => e.Active).IsRequired();
    }
}