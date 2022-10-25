
using CarParkingAPI.Model;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        internal ICarRepository carRepository => _carRepository;        

        [HttpGet]
        public Task<IEnumerable<Car>> ListCars(int ParkingId)
        {
            return carRepository.List(ParkingId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCars(int id)
        {
            return await carRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCars([FromBody] Car car)
        {
            var newCar = carRepository.Create(car);
            return await Task.FromResult(CreatedAtAction(nameof(GetCars), new { id = newCar.Id }, newCar));

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int Id)
        {
            var carToDelete = await carRepository.Get(Id);

            if (carToDelete != null)
                return NotFound();

            object value = await carRepository.Delete();
            return NoContent();

        }



    }
}
