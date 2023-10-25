using Loja.Domain.Entities;
using Loja.Domain.Interfaces;
using Loja.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Loja.Infrastructure.Repositories;

public class SupplierRepository : ISupplierRepository
{
    private readonly ApplicationDbContext _context;

    public SupplierRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<SupplierEntity> CreateAsync(SupplierEntity supplier)
    {
        _context.Add(supplier);
        await _context.SaveChangesAsync();
        return supplier;
    }

    public async Task<SupplierEntity> UpdateAsync(SupplierEntity supplier)
    {
        _context.Update(supplier);
        await _context.SaveChangesAsync();
        return supplier;
    }

    public async Task<SupplierEntity> RemoveAsync(SupplierEntity supplier)
    {
        _context.Remove(supplier);
        await _context.SaveChangesAsync();
        return supplier;
    }

    public async Task<IEnumerable<SupplierEntity>> GetSupplierAsync()
    {
        var query = await _context.Suppliers
            .Where(s => s.Active == true)
            .OrderBy(s => s.Name)
            .ToListAsync();

        return query;
    }

    public Task<SupplierEntity> GetSupplierById(int? id)
    {
        var query = _context.Suppliers
            .Where(s => s.Id == id && s.Active == true)
            .FirstOrDefaultAsync();

        return query;
    }
}
