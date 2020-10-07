using Microsoft.EntityFrameworkCore;

namespace Solid.Database
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\SOLID");
        }
    }
}
