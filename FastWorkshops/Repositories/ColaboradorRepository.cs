using Microsoft.EntityFrameworkCore;
using FastWorkshops.DataContext;
using FastWorkshops.models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class ColaboradorRepository : IColaboradorRepository
{
    private readonly ApplicationDbContext _context;

    public ColaboradorRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ColaboradorModel>> GetAllColaboradores()
    {
        return await _context.DbColaborador.ToListAsync();
    }

    public async Task<ColaboradorModel> GetColaboradorById(int id)
    {
        return await _context.DbColaborador.FindAsync(id);
    }

    public async Task<ColaboradorModel> AddColaborador(ColaboradorModel colaborador)
    {
        _context.DbColaborador.Add(colaborador);
        await _context.SaveChangesAsync();
        return colaborador;
    }

    public async Task<ColaboradorModel> UpdateColaborador(ColaboradorModel colaborador)
    {
        _context.Entry(colaborador).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return colaborador;
    }

    public async Task<bool> DeleteColaborador(int id)
    {
        var colaborador = await _context.DbColaborador.FindAsync(id);
        if (colaborador == null) return false;

        _context.DbColaborador.Remove(colaborador);
        await _context.SaveChangesAsync();
        return true;
    }
}