using CarAPI.Model;
using CarAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public Task<IEnumerable<Car>> ListCars(int ParkingId)
        {
            return _carRepository.List(ParkingId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCars(int id)
        {
            return await _carRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCars([FromBody] Car car)
        {
            var newCar = await _carRepository.Create(car);
            return CreatedAtAction(nameof(GetCars), new { id = newCar.Id }, newCar);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var carToDelete = await _carRepository.Get(id);

            if (carToDelete != null)
                return NotFound();

            await _carRepository.Delete(carToDelete.Id);
                return NoContent();
            
        }

        

    }
}
