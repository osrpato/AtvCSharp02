using Microsoft.EntityFrameworkCore;

namespace ShoeAPI.Model
{
    public class ShoeContext : DbContext
    {
        public ShoeContext(DbContextOptions<ShoeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Shoe> Shoes { get; set; }
    }
}
