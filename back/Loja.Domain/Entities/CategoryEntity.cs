namespace Loja.Domain.Entities;

public class CategoryEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public string? ImageUrl { get; private set; }
    public bool Active { get; private set; } = true;

    public ICollection<ProductEntity> Products { get; private set; }
}
