namespace Loja.Application.DTO;

public class SupplierDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string TaxId { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber1 { get; set; }
    public string? PhoneNumber2 { get; set; }
    public string Email { get; set; }
    public string? Website { get; set; }
    public string? ContactName1 { get; set; }
    public string? Contact1PhoneNumber { get; set; }
    public string? ContactName2 { get; set; }
    public string? Contact2PhoneNumber { get; set; }
    public string? Description { get; set; }
    public string? BankInformation { get; set; }
    public string? PerformanceRating { get; set; }
}
