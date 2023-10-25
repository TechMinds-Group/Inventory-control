using Loja.Domain.Entities;

namespace Loja.Application.DTO;

public class UnitMeasureDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public bool Active { get; set; }
}
