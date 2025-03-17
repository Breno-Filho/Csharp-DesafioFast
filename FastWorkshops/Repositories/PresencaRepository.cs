using Microsoft.EntityFrameworkCore;
using FastWorkshops.DataContext;
using FastWorkshops.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PresencaRepository : IPresencaRepository
{
    private readonly ApplicationDbContext _context;

    public PresencaRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<PresencaModel>> GetAllPresencas()
    {
        return await _context.DbPresenca.ToListAsync();
    }

    public async Task<PresencaModel> GetPresencaById(int id)
    {
        return await _context.DbPresenca.FindAsync(id);
    }

    public async Task<PresencaModel> AddPresenca(PresencaModel presenca)
    {
        _context.DbPresenca.Add(presenca);
        await _context.SaveChangesAsync();
        return presenca;
    }

    public async Task<PresencaModel> UpdatePresenca(PresencaModel presenca)
    {
        _context.Entry(presenca).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return presenca;
    }

    public async Task<bool> DeletePresenca(int id)
    {
        var presenca = await _context.DbPresenca.FindAsync(id);
        if (presenca == null) return false;

        _context.DbPresenca.Remove(presenca);
        await _context.SaveChangesAsync();
        return true;
    }
}