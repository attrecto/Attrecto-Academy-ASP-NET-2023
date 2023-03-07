using Microsoft.EntityFrameworkCore;

namespace Academy_2023.Data
{
    public class ApplicationDbContext : DbContext
    {
        public string DbPath { get; set; }

        public DbSet<User> Users { get; set; } = null!;

        public ApplicationDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "academy.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
