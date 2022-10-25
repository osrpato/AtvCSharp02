using Microsoft.EntityFrameworkCore;
using SAPI.MODELO;

namespace SAPI.Repositories
{
    public class ShoeRepository : IShoeRepository
    {
        public readonly ShoeContext _context;

        public ShoeRepository(ShoeContext context)
        {
            _context = context;
        }

        public async Task<shoes> Create(shoes shoes)
        {
            _context.vShoes.Add(shoes);
            await _context.SaveChangesAsync();

            return shoes;
        }

        public async Task Delete(int Id)
        {
            var shoesToDelete = await _context.vShoes.FindAsync(Id);
            _context.vShoes.Remove(shoesToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<shoes>> Get()
        {
            return await _context.vShoes.ToListAsync();
        }

        public async Task<shoes> Get(int id)
        {
            return await _context.vShoes.FindAsync(id);
        }

        public async Task Update(shoes shoes)
        {
            _context.Entry(shoes).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        Task<IEnumerable<IShoeRepository>> IShoeRepository.Get()
        {
            throw new NotImplementedException();
        }
    }
}
