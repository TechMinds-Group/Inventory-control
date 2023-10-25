using Loja.Application.DTO;

namespace Loja.Application.Services.UnitMeasure;

public interface IUnitMeasureService
{
    Task Add(UnitMeasureDTO unitMeasureDTO);
    Task Update(UnitMeasureDTO unitMeasureDTO);
    Task Remove(int? id);

    Task<IEnumerable<UnitMeasureDTO>> GetUnitMeasureAsync();
    Task<UnitMeasureDTO> GetUnitMeasureById(int? id);
}
