using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Loja.Infrastructure.Data.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<InventoryEntity> Inventories { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<SupplierEntity> Suppliers { get; set; }
    public DbSet<SupplyEntity> Supplies { get; set; }
    public DbSet<UnitMeasureEntity> UnitsMeasures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        base.OnModelCreating(modelbuilder);

        modelbuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
