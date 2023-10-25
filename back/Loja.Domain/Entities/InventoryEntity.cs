namespace Loja.Domain.Entities;

public sealed class InventoryEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public DateTime EntryDate { get; private set; }
    public DateTime? ExitDate { get; private set; }
    public string? ExitReason { get; private set; } //Enum
    public string? StorageLocation { get; private set; }
    public string? AdditionalNotes { get; set; }
    public bool Active { get; private set; } = true;



    public int UserId { get; private set; }

    public ICollection<ProductEntity> Products { get; private set; }
}
