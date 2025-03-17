using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

public class PresencaService : IPresencaService
{
    private readonly IPresencaRepository _presencaRepository;

    public PresencaService(IPresencaRepository presencaRepository)
    {
        _presencaRepository = presencaRepository;
    }

    public async Task<List<PresencaModel>> GetAllPresencas()
    {
        return await _presencaRepository.GetAllPresencas();
    }

    public async Task<PresencaModel> GetPresencaById(int id)
    {
        return await _presencaRepository.GetPresencaById(id);
    }

    public async Task<PresencaModel> AddPresenca(PresencaModel presenca)
    {
        return await _presencaRepository.AddPresenca(presenca);
    }

    public async Task<PresencaModel> UpdatePresenca(PresencaModel presenca)
    {
        return await _presencaRepository.UpdatePresenca(presenca);
    }

    public async Task<bool> DeletePresenca(int id)
    {
        return await _presencaRepository.DeletePresenca(id);
    }
}