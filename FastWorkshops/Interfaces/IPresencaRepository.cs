using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

public interface IPresencaRepository
{
    Task<List<PresencaModel>> GetAllPresencas();
    Task<PresencaModel> GetPresencaById(int id);
    Task<PresencaModel> AddPresenca(PresencaModel presenca);
    Task<PresencaModel> UpdatePresenca(PresencaModel presenca);
    Task<bool> DeletePresenca(int id);
}