using Microsoft.AspNetCore.Mvc;
using SAPI.MODELO;
using SAPI.Repositories;
using System.Diagnostics.Eventing.Reader;

namespace SAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoeController : ControllerBase
    {
        private readonly IShoeRepository _shoeRepository;
        private readonly object? newshoe;
        public ShoeController(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<shoes>> Getshoes()
        {
            return (IEnumerable<shoes>)await _shoeRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<shoes>> Getshoes(int id)
        {
            return await _shoeRepository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<shoes>> Postshoes([FromBody] shoes shoes)
        {
            var newShoe = await _shoeRepository.Create(shoes);
            return shoes;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<shoes>> Delete(int id)
        {
            var shoesToDelete = await _shoeRepository.Get(id);
            if (shoesToDelete == null)
                return NotFound();
            await _shoeRepository.Delete(shoesToDelete.Id);
            return NoContext();
        }
        private ActionResult? NoContext()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<ActionResult> Putshoes(int id, [FromBody] shoes shoes)
        {
            if(id != shoes.id)
                return BadRequest();
                await _shoeRepository.Update(shoes);

            return NoContext();

            
                  
        }

    }
}
