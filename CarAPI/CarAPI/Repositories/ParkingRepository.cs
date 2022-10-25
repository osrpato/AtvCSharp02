using CarAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarAPI.Repositories
{
    public class ParkingRepository : IParkingRepository
    {
        public readonly ParkingCarContext _context;

        public ParkingRepository(ParkingCarContext context )
        {
            _context = context;
        }

        public async Task<Parking> Create(Parking parking)
        {
            _context.Parkings.Add(parking);
            await _context.SaveChangesAsync();

            return parking;
        }

        public async Task Delete(int Id)
        {
            var parkingToDelete = await _context.Parkings.FindAsync(Id);
            _context.Parkings.Remove(parkingToDelete);
            await _context.SaveChangesAsync();
        }


        public async Task<Parking> Get(int Id)
        {
            return await _context.Parkings.FindAsync(Id);
        }

        public async Task<IEnumerable<Parking>> List()
        {
            return await _context.Parkings.ToListAsync();
        }

        public async Task Update(Parking parking)
        {
            _context.Entry(parking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
