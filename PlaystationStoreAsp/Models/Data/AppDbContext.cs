using Microsoft.EntityFrameworkCore;

namespace PlaystationStoreAsp.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}
