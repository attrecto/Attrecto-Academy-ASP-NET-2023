using Microsoft.EntityFrameworkCore;

namespace Academy_2023.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions options) : base(options)   // az options-t már konfiguráltuk a program.cs-ben
        {
        }
    }
}
