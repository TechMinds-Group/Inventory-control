using Loja.Application.DTO;
using Loja.Application.Services.UnitMeasure;
using Microsoft.AspNetCore.Mvc;

namespace Loja.WebAPI.Controllers;

[ApiController]
public class UnitMeasureController : ControllerBase
{
    private readonly IUnitMeasureService _unitMeasureService;
    public UnitMeasureController(IUnitMeasureService unitMeasureService)
    {
        _unitMeasureService = unitMeasureService;
    }

    [HttpPost, Route("api/unitMeasure")]
    public async Task<IActionResult> PostUnitMeasure(UnitMeasureDTO unitMeasureDto)
    {
        try
        {
            if (unitMeasureDto == null)
            {
                return BadRequest();
            }

            await _unitMeasureService.Add(unitMeasureDto);

            return Ok();
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpPut, Route("api/unitMeasure")]
    public async Task<IActionResult> PutUnitMeasure(UnitMeasureDTO unitMeasureDto)
    {
        try
        {
            if (unitMeasureDto == null)
                return BadRequest();
            await _unitMeasureService.Update(unitMeasureDto);

            return Ok(unitMeasureDto);
        }
        catch
        (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpDelete, Route("api/unitMeasure/{id}")]
    public async Task<IActionResult> DeleteUnitMeasure(int? id)
    {
        try
        {
            var unitMeasure = await _unitMeasureService.GetUnitMeasureById(id);
            if (unitMeasure == null)
                return BadRequest();

            await _unitMeasureService.Remove(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }
    }

    [HttpGet, Route("api/unitMeasure")]
    public async Task<IActionResult> GetUnitsMeasures()
    {
        try
        {
            var unitsMeasures = await _unitMeasureService.GetUnitMeasureAsync();
            if (unitsMeasures == null)
                return NotFound();

            return Ok(unitsMeasures);
        }
        catch (Exception ex)
        {
            return this.StatusCode(StatusCodes.Status500InternalServerError, $"Something went wrong, please contact the developers. Error: {ex.Message}");
        }

    }
}
