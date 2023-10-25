using Loja.Domain.Entities;

namespace Loja.Domain.Interfaces;

public interface ISupplierRepository
{
    Task<SupplierEntity> CreateAsync(SupplierEntity supplier);
    Task<SupplierEntity> UpdateAsync(SupplierEntity supplier);
    Task<SupplierEntity> RemoveAsync(SupplierEntity supplier);

    Task<IEnumerable<SupplierEntity>> GetSupplierAsync();
    Task<SupplierEntity> GetSupplierById(int? id);
}
