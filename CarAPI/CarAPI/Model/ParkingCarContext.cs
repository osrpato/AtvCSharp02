using Microsoft.EntityFrameworkCore;

namespace CarAPI.Model
{

    public class ParkingCarContext : DbContext
    {

        public ParkingCarContext(DbContextOptions<ParkingCarContext> options) : base(options)
        {
            Database.EnsureCreatedAsync();
        }

        public DbSet<Parking> Parkings { get; set; }

        public DbSet<Car> Cars { get; set; }

    }
    
}
