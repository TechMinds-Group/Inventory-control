using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Infrastructure.Data.EntitiesConfiguration;

public class SupllyConfiguration : IEntityTypeConfiguration<SupplyEntity>
{
    public void Configure(EntityTypeBuilder<SupplyEntity> builder)
    {
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e => e.SuppliedDate).IsRequired();
    }
}
