using Microsoft.EntityFrameworkCore;

namespace CarParkingAPI.Model
{
    public class ParkingCarContext : DbContext
    {
        public ParkingCarContext(DbContextOptions<ParkingCarContext> op):base(op)
        {
            Database.EnsureCreated();
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Parking> Parkings { get; set; }
    }
}
