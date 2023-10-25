using AutoMapper;
using Loja.Application.DTO;
using Loja.Domain.Entities;
using Loja.Domain.Interfaces;

namespace Loja.Application.Services.Supprier;

public class SupplierService : ISupplierService
{
    private readonly ISupplierRepository _supplierRepository;
    private readonly IMapper _mapper;

    public SupplierService(ISupplierRepository supplierRepository, IMapper mapper)
    {
        _supplierRepository = supplierRepository;
        _mapper = mapper;
    }

    public async Task Add(SupplierDTO supplierDto)
    {
        var supplier = _mapper.Map<SupplierEntity>(supplierDto);
        await _supplierRepository.CreateAsync(supplier);
        supplierDto.Id = supplier.Id;
    }

    public async Task Update(SupplierDTO supplierDto)
    {
        var supplier = _mapper.Map<SupplierEntity>(supplierDto);
        await _supplierRepository.UpdateAsync(supplier);
    }

    public async Task Remove(int? id)
    {
        var supplier = await _supplierRepository.GetSupplierById(id);
        await _supplierRepository.RemoveAsync(supplier);
    }

    public async Task<IEnumerable<SupplierDTO>> GetSuppliers()
    {
        var supplier = await _supplierRepository.GetSupplierAsync();
        return _mapper.Map<IEnumerable<SupplierDTO>>(supplier);
    }

    public async Task<SupplierDTO> GetSupplierById(int? id)
    {
        var supplier = await _supplierRepository.GetSupplierById(id);
        return _mapper.Map<SupplierDTO>(supplier);
    }
}
