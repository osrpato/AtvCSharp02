using Microsoft.EntityFrameworkCore;

namespace VAPI.Model
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
