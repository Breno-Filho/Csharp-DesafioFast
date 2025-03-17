using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

[ApiController]
[Route("[controller]")]
public class PresencaController : ControllerBase
{
    private readonly IPresencaService _presencaService;

    public PresencaController(IPresencaService presencaService)
    {
        _presencaService = presencaService;
    }

    [HttpGet]
    public async Task<ActionResult<List<PresencaModel>>> GetAllPresencas()
    {
        var presencas = await _presencaService.GetAllPresencas();
        return Ok(presencas);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PresencaModel>> GetPresencaById(int id)
    {
        var presenca = await _presencaService.GetPresencaById(id);
        if (presenca == null) return NotFound();
        return Ok(presenca);
    }

    [HttpPost]
    public async Task<ActionResult<PresencaModel>> PostPresenca(PresencaModel presenca)
    {
        var createdPresenca = await _presencaService.AddPresenca(presenca);
        return CreatedAtAction(nameof(GetPresencaById), new { id = createdPresenca.Id }, createdPresenca);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<PresencaModel>> PutPresenca(int id, PresencaModel presenca)
    {
        if (id != presenca.Id) return BadRequest();
        var updatedPresenca = await _presencaService.UpdatePresenca(presenca);
        return Ok(updatedPresenca);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeletePresenca(int id)
    {
        var result = await _presencaService.DeletePresenca(id);
        if (!result) return NotFound();
        return NoContent();
    }
}