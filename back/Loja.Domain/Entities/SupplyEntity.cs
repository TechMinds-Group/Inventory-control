namespace Loja.Domain.Entities;

public class SupplyEntity
{
    public int Id { get; private set; }
    public DateTime SuppliedDate { get; private set; }

    public int SupplierId { get; private set; }
    public SupplierEntity Supplier { get; private set; }
    public ICollection<ProductEntity> Products { get; private set; }
}
