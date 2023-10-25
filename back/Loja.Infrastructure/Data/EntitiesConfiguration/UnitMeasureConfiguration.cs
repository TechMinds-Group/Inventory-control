using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Infrastructure.Data.EntitiesConfiguration;

public class UnitMeasureConfiguration : IEntityTypeConfiguration<UnitMeasureEntity>
{
    public void Configure(EntityTypeBuilder<UnitMeasureEntity> builder)
    {
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(300);
        builder.Property(e => e.Active).IsRequired();
    }
}
