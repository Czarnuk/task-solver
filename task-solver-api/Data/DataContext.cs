using Microsoft.EntityFrameworkCore;
using task_solver_api.Entities;

namespace task_solver_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
    }
}
