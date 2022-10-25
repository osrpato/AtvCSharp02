using CarParkingAPI.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarParkingAPI.Repositories
{
    public interface IParkingRepository
    {
        Task<IEnumerable<Parking>> List { get; }

        Task<Parking> Get(int Id);

        Task<Parking> Create(Parking parking);

        Task Update(Parking parking);

        Task Delete(int Id);
        Task<System.Collections.Generic.IEnumerable<Parking>> Get();
        Task Delete(Parking parkingToDelete);
    }
}
