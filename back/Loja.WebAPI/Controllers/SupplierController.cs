using Loja.Application.DTO;
using Loja.Application.Services.Supprier;
using Microsoft.AspNetCore.Mvc;

namespace Loja.WebAPI.Controllers;

[ApiController]
public class SupplierController : ControllerBase
{
    private readonly ISupplierService _supplierService;

    public SupplierController(ISupplierService supplierService)
    {
        _supplierService = supplierService;
    }

    #region Métodos
    /// <summary>
    /// Register a supplier
    /// </summary>
    /// <remarks>
    /// Register a supplier in the database
    /// </remarks>
    /// <param name="supplierDto">Supplier data</param>
    /// <returns>Registered supplier</returns>
    /// <response code="201">Created</response>
    /// <response code="400">Bad Request</response>
    [ProducesResponseType(typeof(SupplierDTO), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
    [HttpPost, Route("api/supplier")]
    public async Task<IActionResult> PostSupplier(SupplierDTO supplierDto)
    {
        try
        {
            if (supplierDto == null)
                return BadRequest();

            await _supplierService.Add(supplierDto);
            return Created("api/supplier" + supplierDto.Id, supplierDto);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpPut, Route("api/supplier")]
    public async Task<IActionResult> PutSupplier(SupplierDTO supplierDto)
    {
        try
        {
            if (supplierDto == null)
                return NotFound();

            await _supplierService.Update(supplierDto);
            return Ok(supplierDto);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpDelete, Route("api/supplier/{id}")]
    public async Task<IActionResult> DeleteSupplier(int? id)
    {
        try
        {
            var supplier = await _supplierService.GetSupplierById(id);
            if (supplier == null)
                return NotFound();

            await _supplierService.Remove(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpGet, Route("api/supplier")]
    public async Task<IActionResult> GetSupplier()
    {
        try
        {
            var suppliers = await _supplierService.GetSuppliers();
            if (suppliers == null)
                return NotFound();

            return Ok(suppliers);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpGet, Route("api/supplier/{id}")]
    public async Task<IActionResult> GetSupplierById(int? id)
    {
        try
        {
            var supplier = await _supplierService.GetSupplierById(id);
            if (supplier == null)
                return NotFound();

            return Ok(supplier);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }
    #endregion
}