using Loja.Domain.Entities;
using Loja.Domain.Interfaces;
using Loja.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Loja.Infrastructure.Repositories;

public class UnitMeasureRepository : IUnitMeasureRepository
{
    private readonly ApplicationDbContext _context;
    public UnitMeasureRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UnitMeasureEntity> CreateAsync(UnitMeasureEntity unitMeasure)
    {
        _context.Add(unitMeasure);
        await _context.SaveChangesAsync();
        return unitMeasure;
    }

    public async Task<UnitMeasureEntity> UpdateAsync(UnitMeasureEntity unitMeasure)
    {
        _context.Update(unitMeasure);
        await _context.SaveChangesAsync();
        return unitMeasure;
    }

    public async Task<UnitMeasureEntity> RemoveAsync(UnitMeasureEntity unitMeasure)
    {
        _context.Remove(unitMeasure);
        await _context.SaveChangesAsync();
        return unitMeasure;
    }

    public async Task<IEnumerable<UnitMeasureEntity>> GetAllUnitMeasure()
    {
        var query = await _context.UnitsMeasures
            .Where(u => u.Active == true)
            .OrderBy(u => u.Name)
            .ToListAsync();

        return query;
    }

    public async Task<UnitMeasureEntity> GetUnitMeasureById(int? id)
    {
        var query = await _context.UnitsMeasures
            .Where(u => u.Active == true)
            .FirstOrDefaultAsync(u => u.Id == id);

        return query;
    }
}
