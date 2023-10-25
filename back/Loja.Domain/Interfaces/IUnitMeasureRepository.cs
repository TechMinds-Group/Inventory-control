using Loja.Domain.Entities;

namespace Loja.Domain.Interfaces;

public interface IUnitMeasureRepository
{
    Task<UnitMeasureEntity> CreateAsync(UnitMeasureEntity unitMeasure);
    Task<UnitMeasureEntity> UpdateAsync(UnitMeasureEntity unitMeasure);
    Task<UnitMeasureEntity> RemoveAsync(UnitMeasureEntity unitMeasure);

    Task<UnitMeasureEntity> GetUnitMeasureById(int? id);
    Task<IEnumerable<UnitMeasureEntity>> GetAllUnitMeasure();
}
