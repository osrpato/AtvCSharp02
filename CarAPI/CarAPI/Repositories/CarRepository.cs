using CarAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarAPI.Repositories
{
    public class CarRepository : ICarRepository
    {
        public readonly ParkingCarContext _context;
        public CarRepository(ParkingCarContext context)
        {
            _context = context;
        } 
        public async Task<Car> Create(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return car;
        }

        public async Task Delete(int id)
        {
            var carToDelete = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(carToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Car> Get(int id)
        {
            return await _context.Cars.FindAsync(id);
           
        }

        public async Task<IEnumerable<Car>> List(int parkingId)
        {
            return await _context.Cars.Where(o => o.ParkingId == parkingId).ToListAsync();
        }
    }
}
