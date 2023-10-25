using AutoMapper;
using Loja.Application.DTO;
using Loja.Domain.Entities;

namespace Loja.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<ProductEntity, ProductDTO>().ReverseMap();
        CreateMap<UnitMeasureEntity, UnitMeasureDTO>().ReverseMap();
        CreateMap<SupplierEntity, SupplierDTO>().ReverseMap();
    }
}
