using Microsoft.EntityFrameworkCore;

namespace Vidly.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        
        public string DbPath { get; }

        public ApplicationDbContext()
        {
            // var folder = Environment.SpecialFolder.LocalApplicationData;
            var folder = Directory.GetCurrentDirectory();
            var path = Path.Join(folder, "APP_DATA");
            DbPath = Path.Join(path, "Vidly.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}