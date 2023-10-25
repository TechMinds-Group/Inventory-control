namespace Loja.Application.DTO;

public class ProductDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int Quantity { get; set; }
    public string? Weight { get; set; }
    public string? Dimensions { get; set; }
    public string? ImageUrl { get; set; }
    public string? AdditionalNotes { get; set; }
    public string? Barcode { get; set; }
    public float AlertLevel { get; set; }
    public float CriticalLevel { get; set; }
    public bool Available { get; set; }
    public bool Active { get; set; } = true;

    public int UnitMeasureId { get; set; }
    public int CategoryId { get; set; }
    public int InventoryId { get; set; }
    public int SupplyId { get; set; }
}