using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

public class WorkshopService : IWorkshopService
{
    private readonly IWorkshopRepository _workshopRepository;

    public WorkshopService(IWorkshopRepository workshopRepository)
    {
        _workshopRepository = workshopRepository;
    }

    public async Task<List<WorkshopModel>> GetAllWorkshops()
    {
        return await _workshopRepository.GetAllWorkshops();
    }

    public async Task<WorkshopModel> GetWorkshopById(int id)
    {
        return await _workshopRepository.GetWorkshopById(id);
    }

    public async Task<WorkshopModel> AddWorkshop(WorkshopModel workshop)
    {
        return await _workshopRepository.AddWorkshop(workshop);
    }

    public async Task<WorkshopModel> UpdateWorkshop(WorkshopModel workshop)
    {
        return await _workshopRepository.UpdateWorkshop(workshop);
    }

    public async Task<bool> DeleteWorkshop(int id)
    {
        return await _workshopRepository.DeleteWorkshop(id);
    }
}