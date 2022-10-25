using Microsoft.AspNetCore.Mvc;
using ShoeAPI.Model;
using ShoeAPI.Repositories;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Threading.Tasks;

namespace ShoeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoesController : ControllerBase
    {
        private readonly IShoeRepository _shoeRepository;
        public ShoesController(IShoeRepository shoeRepository)
        {
            _shoeRepository = shoeRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Shoe>> GetShoes()
        {
            return await _shoeRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Shoe>> GetShoes(int id)
        {
            return await _shoeRepository.Get(id);   
        }

        [HttpPost]
        public async Task<ActionResult<Shoe>> PostShoes([FromBody] Shoe shoe)
        {
            var newShoe = await _shoeRepository.Create(shoe);
            return CreatedAtAction(nameof(GetShoes), new { id = newShoe.Id }, newShoe);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var shoeToDelete = await _shoeRepository.Get(id);

            if (shoeToDelete != null)
                return NotFound();

            await _shoeRepository.Delete(shoeToDelete.Id);
                return NoContent();

        }

        [HttpPut]
        public async Task<ActionResult> PutShoes(int id, [FromBody] Shoe shoe)
        {
            if(id == shoe.Id)
                return BadRequest();

            await _shoeRepository.Update(shoe);
            return NoContent();
        }
    }
}
