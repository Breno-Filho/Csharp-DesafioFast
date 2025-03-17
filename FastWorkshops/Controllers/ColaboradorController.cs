using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

[ApiController]
[Route("[controller]")]
public class ColaboradorController : ControllerBase
{
    private readonly IColaboradorService _colaboradorService;

    public ColaboradorController(IColaboradorService colaboradorService)
    {
        _colaboradorService = colaboradorService;
    }

    [HttpGet]
    public async Task<ActionResult<List<ColaboradorModel>>> GetAllColaboradores()
    {
        var colaboradores = await _colaboradorService.GetAllColaboradores();
        return Ok(colaboradores);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ColaboradorModel>> GetColaboradorById(int id)
    {
        var colaborador = await _colaboradorService.GetColaboradorById(id);
        if (colaborador == null) return NotFound();
        return Ok(colaborador);
    }

    [HttpPost]
    public async Task<ActionResult<ColaboradorModel>> PostColaborador(ColaboradorModel colaborador)
    {
        var createdColaborador = await _colaboradorService.AddColaborador(colaborador);
        return CreatedAtAction(nameof(GetColaboradorById), new { id = createdColaborador.Id }, createdColaborador);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ColaboradorModel>> PutColaborador(int id, ColaboradorModel colaborador)
    {
        if (id != colaborador.Id) return BadRequest();
        var updatedColaborador = await _colaboradorService.UpdateColaborador(colaborador);
        return Ok(updatedColaborador);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteColaborador(int id)
    {
        var result = await _colaboradorService.DeleteColaborador(id);
        if (!result) return NotFound();
        return NoContent();
    }
}