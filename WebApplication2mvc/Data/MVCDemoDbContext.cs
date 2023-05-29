using Microsoft.EntityFrameworkCore;
using WebApplication2mvc.Models.Domain;

namespace WebApplication2mvc.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees{ get; set; }

    }
}
