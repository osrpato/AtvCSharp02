using CarAPI.Model;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Repositories
{
    public interface IParkingRepository
    {
        Task<Parking> Get(int Id);

        Task<IEnumerable<Parking>> List();

        Task<Parking> Create(Parking parking);

        Task Delete (int Id);
     
        Task Update(Parking parking);
    }
}
