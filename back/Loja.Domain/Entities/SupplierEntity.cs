namespace Loja.Domain.Entities;

public class SupplierEntity
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Type { get; private set; } //enum
    public string TaxId { get; private set; }
    public string Address { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }
    public string PhoneNumber1 { get; private set; }
    public string? PhoneNumber2 { get; private set; }
    public string Email { get; private set; }
    public string? Website { get; private set; }
    public string? ContactName1 { get; private set; }
    public string? Contact1PhoneNumber { get; private set; }
    public string? ContactName2 { get; private set; }
    public string? Contact2PhoneNumber { get; private set; }
    public string? Description { get; private set; }
    public string? BankInformation { get; private set; }
    public string? PerformanceRating { get; private set; }
    public bool Active { get; private set; } = true;

    public ICollection<SupplyEntity> Supplies { get; private set; }
}
