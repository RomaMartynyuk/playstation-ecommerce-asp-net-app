using Microsoft.EntityFrameworkCore;

namespace PlaystationStoreAsp.Models.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        DbSet<Game> Games { get; set; }
        DbSet<Company> Companies { get; set; }
    }
}
