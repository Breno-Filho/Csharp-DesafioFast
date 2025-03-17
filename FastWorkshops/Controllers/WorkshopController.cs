using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

[ApiController]
[Route("[controller]")]
public class WorkshopController : ControllerBase
{
    private readonly IWorkshopService _workshopService;

    public WorkshopController(IWorkshopService workshopService)
    {
        _workshopService = workshopService;
    }

    [HttpGet]
    public async Task<ActionResult<List<WorkshopModel>>> GetAllWorkshops()
    {
        var workshops = await _workshopService.GetAllWorkshops();
        return Ok(workshops);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<WorkshopModel>> GetWorkshopById(int id)
    {
        var workshop = await _workshopService.GetWorkshopById(id);
        if (workshop == null) return NotFound();
        return Ok(workshop);
    }

    [HttpPost]
    public async Task<ActionResult<WorkshopModel>> PostWorkshop(WorkshopModel workshop)
    {
        var createdWorkshop = await _workshopService.AddWorkshop(workshop);
        return CreatedAtAction(nameof(GetWorkshopById), new { id = createdWorkshop.Id }, createdWorkshop);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<WorkshopModel>> PutWorkshop(int id, WorkshopModel workshop)
    {
        if (id != workshop.Id) return BadRequest();
        var updatedWorkshop = await _workshopService.UpdateWorkshop(workshop);
        return Ok(updatedWorkshop);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteWorkshop(int id)
    {
        var result = await _workshopService.DeleteWorkshop(id);
        if (!result) return NotFound();
        return NoContent();
    }
}