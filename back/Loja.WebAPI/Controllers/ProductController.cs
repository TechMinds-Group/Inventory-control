using Loja.Application.DTO;
using Loja.Application.Services.Products;
using Microsoft.AspNetCore.Mvc;

namespace Loja.WebAPI.Controllers;


[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    #region Métodos
    [HttpPost, Route("api/product")]
    public async Task<IActionResult> PostProduct(ProductDTO productDto)
    {
        try
        {
            if (productDto == null)
                return BadRequest();

            await _productService.Add(productDto);

            return Created($"api/product/" + productDto.Id, productDto);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpPut("api/product")]
    public async Task<IActionResult> PutProduct(ProductDTO productDto)
    {
        try
        {
            if (productDto == null)
                return NotFound();

            await _productService.Update(productDto);

            return Ok(productDto);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpDelete("api/product/{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        try
        {
            var product = await _productService.GetProductById(id);

            if (product == null)
                return NotFound();

            await _productService.Remove(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpGet, Route("api/product")]
    public async Task<IActionResult> GetProducts()
    {
        try
        {
            var products = await _productService.GetProductsAsync();

            if (products == null)
                return NotFound();

            return Ok(products);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpGet, Route("api/product/{id}")]
    public async Task<IActionResult> GetProductById(int id)
    {
        try
        {
            var product = await _productService.GetProductById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpGet, Route("api/inventory/{id}")]
    public async Task<IActionResult> GetProductByInventory(int id)
    {
        try
        {
            var products = await _productService.GetProductsInventoryAsync(id);

            if (products == null)
                return NotFound();

            return Ok(products);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }
    #endregion
}