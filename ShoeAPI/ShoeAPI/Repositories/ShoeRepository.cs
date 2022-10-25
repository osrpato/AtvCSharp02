using Microsoft.EntityFrameworkCore;
using ShoeAPI.Model;
using SQLitePCL;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeAPI.Repositories
{
    
    public class ShoeRepository : IShoeRepository
    {
        public readonly ShoeContext _context;
        public ShoeRepository(ShoeContext context)
        {
            _context = context;
        }

        public async Task<Shoe> Create(Shoe shoe)
        {
            _context.Shoes.Add(shoe);
            await _context.SaveChangesAsync();

            return shoe;
        }

        public async Task Delete(int id)
        {
            var shoeToDelete = await _context.Shoes.FindAsync(id);
                _context.Shoes.Remove(shoeToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Shoe>> Get()
        {
            return await _context.Shoes.ToListAsync();

        }

        public async Task<Shoe> Get(int id)
        {
            return await _context.Shoes.FindAsync();
        }

        public async Task Update(Shoe shoe)
        {
            _context.Entry(shoe).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
