using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Dados> Dados { get; set; }
    }
}
