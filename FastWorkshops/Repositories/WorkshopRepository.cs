using Microsoft.EntityFrameworkCore;
using FastWorkshops.DataContext;
using FastWorkshops.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class WorkshopRepository : IWorkshopRepository
{
    private readonly ApplicationDbContext _context;

    public WorkshopRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<WorkshopModel>> GetAllWorkshops()
    {
        return await _context.DbWorkshop.ToListAsync();
    }

    public async Task<WorkshopModel> GetWorkshopById(int id)
    {
        return await _context.DbWorkshop.FindAsync(id);
    }

    public async Task<WorkshopModel> AddWorkshop(WorkshopModel workshop)
    {
        _context.DbWorkshop.Add(workshop);
        await _context.SaveChangesAsync();
        return workshop;
    }

    public async Task<WorkshopModel> UpdateWorkshop(WorkshopModel workshop)
    {
        _context.Entry(workshop).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return workshop;
    }

    public async Task<bool> DeleteWorkshop(int id)
    {
        var workshop = await _context.DbWorkshop.FindAsync(id);
        if (workshop == null) return false;

        _context.DbWorkshop.Remove(workshop);
        await _context.SaveChangesAsync();
        return true;
    }
}