using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Infrastructure.Data.EntitiesConfiguration;

public class SupplierConfiguration : IEntityTypeConfiguration<SupplierEntity>
{
    public void Configure(EntityTypeBuilder<SupplierEntity> builder)
    {
        builder.Property(e => e.Id).IsRequired();
        builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
        builder.Property(e => e.Type).IsRequired();
        builder.Property(e => e.TaxId).HasMaxLength(20).IsRequired();
        builder.Property(e => e.Address).HasMaxLength(100).IsRequired();
        builder.Property(e => e.City).HasMaxLength(100).IsRequired();
        builder.Property(e => e.State).HasMaxLength(100).IsRequired();
        builder.Property(e => e.ZipCode).HasMaxLength(15).IsRequired();
        builder.Property(e => e.PhoneNumber1).HasMaxLength(15).IsRequired();
        builder.Property(e => e.PhoneNumber2).HasMaxLength(15);
        builder.Property(e => e.Email).HasMaxLength(150).IsRequired();
        builder.Property(e => e.Website).HasMaxLength(150);
        builder.Property(e => e.ContactName1).HasMaxLength(50);
        builder.Property(e => e.Contact1PhoneNumber).HasMaxLength(15);
        builder.Property(e => e.ContactName2).HasMaxLength(50);
        builder.Property(e => e.Contact2PhoneNumber).HasMaxLength(15);
        builder.Property(e => e.Description).HasMaxLength(300);
        builder.Property(e => e.BankInformation).HasMaxLength(200);
        builder.Property(e => e.PerformanceRating);
        builder.Property(e => e.Active).IsRequired();
    }
}
