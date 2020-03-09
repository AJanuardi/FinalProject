using Microsoft.EntityFrameworkCore;
using HR_App.Models;

namespace HR_App.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Paging> pagings { get; set; }
        public DbSet<Attendance> attendances { get; set; }
        public DbSet<Broadcast> broadcasts { get; set; }

        public AppDbContext(DbContextOptions options) : base (options) 
        {

        }
    }
}