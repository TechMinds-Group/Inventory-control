using Loja.Application.DTO;

namespace Loja.Application.Services.Supprier;

public interface ISupplierService
{
    Task Add(SupplierDTO supplierDto);
    Task Update(SupplierDTO supplierDto);
    Task Remove(int? id);

    Task<IEnumerable<SupplierDTO>> GetSuppliers();
    Task<SupplierDTO> GetSupplierById(int? id);
}
