using HRManagementSystem.DataAccess;
using HRManagementSystem.Models;

namespace HRManagementSystem.Services
{
    public class EmployeeService
    {
        private readonly HRDbContext _context;

        public EmployeeService(HRDbContext context)
        {
            _context = context;
        }

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}