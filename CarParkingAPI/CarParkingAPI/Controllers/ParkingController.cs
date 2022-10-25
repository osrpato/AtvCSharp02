using CarParkingAPI.Model;
using CarParkingAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ParkingController : ControllerBase
    {
        private readonly IParkingRepository _parkingRepository;

        public ParkingController(IParkingRepository parkingRepository)
        {
            _parkingRepository = parkingRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Parking>> GetParking()
        {
            return await _parkingRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Parking>> GetParking(int id)
        {
            return await _parkingRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Parking>> PostParking([FromBody] Parking parking)
        {
            var newParking = await _parkingRepository.Create(parking);
            return CreatedAtAction(nameof(GetParking), new { id = newParking.Id }, newParking);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var parkingToDelete = await _parkingRepository.Get(id);

            if (parkingToDelete != null)
                return NoContent();

            await _parkingRepository.Delete(parkingToDelete);
            return NoContent();

        }

        [HttpPut]
        public async Task<ActionResult> PutParking(int id, [FromBody] Parking parking)
        {
            if (id == parking.Id)
                return BadRequest();

            await _parkingRepository.Update(parking);
            return NoContent();

        }

    }
}
