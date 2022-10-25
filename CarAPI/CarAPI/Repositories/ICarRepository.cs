using CarAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> List(int parkingId);
        Task<Car> Get(int id);
        Task<Car> Create(Car car);
        Task Delete(int id);
    }
}
