using CarAPI.Controllers;
using CarParkingAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarParkingAPI.Repositories
{

}
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

    public Task Delete(object id)
    {
        throw new System.NotImplementedException();
    }

    public Task<object> Delete()
    {
        throw new System.NotImplementedException();
    }

    public async Task<Car> Get(int id)
    {
        return await _context.Cars.FindAsync();
    }

    public async Task<IEnumerable<Car>> List(int parkingId)
    {
        return await _context.Cars.Where(o => o.ParkingId == parkingId).ToListAsync();
    }

    Task ICarRepository.Create(Car car)
    {
        throw new System.NotImplementedException();
    }

    Task<ActionResult<Car>> ICarRepository.Get(int id)
    {
        throw new System.NotImplementedException();
    }
}