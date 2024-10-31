using Microsoft.EntityFrameworkCore;
using HRManagementSystem.Models;

namespace HRManagementSystem.DataAccess
{
    public class HRDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options) { }
    }
}