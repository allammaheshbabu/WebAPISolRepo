using Microsoft.EntityFrameworkCore;
using WebAPIPro.Models;

namespace WebAPIPro.DB_Context
{
    public class QIS2Context : DbContext
    {
        public QIS2Context(DbContextOptions<QIS2Context>options):base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
