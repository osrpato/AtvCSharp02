using Microsoft.EntityFrameworkCore;

namespace SAPI.MODELO
{
    public class ShoeContext : DbContext
    {
        public ShoeContext(DbContextOptions<ShoeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<shoes> vShoes { get; set; }
    }
}
