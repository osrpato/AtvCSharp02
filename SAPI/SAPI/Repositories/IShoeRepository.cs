using SAPI.MODELO;
using System.Diagnostics.Eventing.Reader;

namespace SAPI.Repositories
{
    public interface IShoeRepository
    {
        Task<IEnumerable<IShoeRepository>> Get();
        Task<shoes> Get(int Id);
        Task<shoes> Create(shoes shoes);
        Task Update(shoes shoes);
        Task Delete(int Id);

    }
}