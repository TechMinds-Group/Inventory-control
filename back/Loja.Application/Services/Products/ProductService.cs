using AutoMapper;
using Loja.Application.DTO;
using Loja.Domain.Entities;
using Loja.Domain.Repositories;

namespace Loja.Application.Services.Products;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task Add(ProductDTO productDto)
    {
        var product = _mapper.Map<ProductEntity>(productDto);
        await _productRepository.CreateProductAsync(product);
    }

    public async Task Update(ProductDTO productDto)
    {
        var product = _mapper.Map<ProductEntity>(productDto);

        await _productRepository.UpdateProductAsync(product);
    }

    public async Task Remove(int? id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);

        await _productRepository.RemoveProductAsync(product);
    }

    public async Task<ProductDTO> GetProductById(int? id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);

        return _mapper.Map<ProductDTO>(product);
    }

    public async Task<IEnumerable<ProductDTO>> GetProductsAsync()
    {
        var products = await _productRepository.GetProductsAsync();

        return _mapper.Map<IEnumerable<ProductDTO>>(products);
    }

    public async Task<IEnumerable<ProductDTO>> GetProductsInventoryAsync(int? id)
    {
        var products = await _productRepository.GetProductsInventoryAsync(id);

        return _mapper.Map<IEnumerable<ProductDTO>>(products);
    }
}
