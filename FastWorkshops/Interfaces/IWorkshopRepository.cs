using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

public interface IWorkshopRepository
{
    Task<List<WorkshopModel>> GetAllWorkshops();
    Task<WorkshopModel> GetWorkshopById(int id);
    Task<WorkshopModel> AddWorkshop(WorkshopModel workshop);
    Task<WorkshopModel> UpdateWorkshop(WorkshopModel workshop);
    Task<bool> DeleteWorkshop(int id);
}
