using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArchitectureAspNetCoreEF.Core.Domain.Repositories
{
    public interface ICarros
    {
        Task<IEnumerable<Entities.Carro>> GetAllAsync();
        Task<Entities.Carro> GetByIdAsync(int? id);
        void Add(Entities.Carro carro);
        void Edit(Entities.Carro carro);
        void Delete(int id);
        bool Exists(int id);
    }
}