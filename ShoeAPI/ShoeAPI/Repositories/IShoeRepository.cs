using ShoeAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoeAPI.Repositories
{
    public interface IShoeRepository
    {
        Task<IEnumerable<Shoe>> Get();
        Task<Shoe> Get(int Id);
        Task<Shoe> Create(Shoe shoe);
        Task Update (Shoe shoe);
        Task Delete (int Id);   
    }
}
