namespace Loja.Domain.Entities;

public class UnitMeasureEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; set; }
    public bool Active { get; private set; } = true;

    public ICollection<ProductEntity> Products { get; private set; }
}
