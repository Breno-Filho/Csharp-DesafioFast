using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

public class ColaboradorService : IColaboradorService
{
    private readonly IColaboradorRepository _colaboradorRepository;

    public ColaboradorService(IColaboradorRepository colaboradorRepository)
    {
        _colaboradorRepository = colaboradorRepository;
    }

    public async Task<List<ColaboradorModel>> GetAllColaboradores()
    {
        return await _colaboradorRepository.GetAllColaboradores();
    }

    public async Task<ColaboradorModel> GetColaboradorById(int id)
    {
        return await _colaboradorRepository.GetColaboradorById(id);
    }

    public async Task<ColaboradorModel> AddColaborador(ColaboradorModel colaborador)
    {
        return await _colaboradorRepository.AddColaborador(colaborador);
    }

    public async Task<ColaboradorModel> UpdateColaborador(ColaboradorModel colaborador)
    {
        return await _colaboradorRepository.UpdateColaborador(colaborador);
    }

    public async Task<bool> DeleteColaborador(int id)
    {
        return await _colaboradorRepository.DeleteColaborador(id);
    }
}