using AutoMapper;
using Loja.Application.DTO;
using Loja.Domain.Entities;
using Loja.Domain.Interfaces;

namespace Loja.Application.Services.UnitMeasure;

public class UnitMeasureService : IUnitMeasureService
{
    private readonly IUnitMeasureRepository _unitMeasureRepository;
    private readonly IMapper _mapper;

    public UnitMeasureService(IUnitMeasureRepository unitMeasureRepository, IMapper mapper)
    {
        _unitMeasureRepository = unitMeasureRepository;
        _mapper = mapper;
    }

    public async Task Add(UnitMeasureDTO unitMeasureDTO)
    {
        var unitMeasure = _mapper.Map<UnitMeasureEntity>(unitMeasureDTO);
        await _unitMeasureRepository.CreateAsync(unitMeasure);
    }

    public async Task Update(UnitMeasureDTO unitMeasureDTO)
    {
        var unitMeasure = _mapper.Map<UnitMeasureEntity>(unitMeasureDTO);
        await _unitMeasureRepository.UpdateAsync(unitMeasure);
    }

    public async Task Remove(int? id)
    {
        var unitMeasure = await _unitMeasureRepository.GetUnitMeasureById(id);
        await _unitMeasureRepository.RemoveAsync(unitMeasure);
    }

    public async Task<IEnumerable<UnitMeasureDTO>> GetUnitMeasureAsync()
    {
        var unitsMeasures = await _unitMeasureRepository.GetAllUnitMeasure();

        return _mapper.Map<IEnumerable<UnitMeasureDTO>>(unitsMeasures);
    }

    public async Task<UnitMeasureDTO> GetUnitMeasureById(int? id)
    {
        var unitMeasure = await _unitMeasureRepository.GetUnitMeasureById(id);

        return _mapper.Map<UnitMeasureDTO>(unitMeasure);
    }
}
