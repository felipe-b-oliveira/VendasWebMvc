using System.Collections.Generic;
using System.Threading.Tasks;
using vendasWebMvc.Models;

namespace vendasWebMvc.Services
{
    public interface IDepartamentoService
    {
        bool DepartamentoExists(int id);
        Task<List<Departamento>> FindAllAsync();
        Task<Departamento> FindByIdAsync(int id);
        Task InsertAsync(Departamento obj);
        Task RemoveAsync(int id);
        Task UpdateAsync(Departamento obj);
    }
}