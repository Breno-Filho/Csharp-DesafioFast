using System.Collections.Generic;
using System.Threading.Tasks;
using FastWorkshops.models;

public interface IColaboradorService
{
    Task<List<ColaboradorModel>> GetAllColaboradores();
    Task<ColaboradorModel> GetColaboradorById(int id);
    Task<ColaboradorModel> AddColaborador(ColaboradorModel colaborador);
    Task<ColaboradorModel> UpdateColaborador(ColaboradorModel colaborador);
    Task<bool> DeleteColaborador(int id);
}