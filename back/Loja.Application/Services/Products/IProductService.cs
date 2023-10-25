using Loja.Application.DTO;

namespace Loja.Application.Services.Products;

public interface IProductService
{
    Task Add(ProductDTO productDto);
    Task Update(ProductDTO productDto);
    Task Remove(int? id);

    Task<IEnumerable<ProductDTO>> GetProductsAsync();
    Task<ProductDTO> GetProductById(int? id);
    Task<IEnumerable<ProductDTO>> GetProductsInventoryAsync(int? id);
}
