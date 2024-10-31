uusing System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HRManagementSystem.Models;
using HRManagementSystem.DataAccess;
using HRManagementSystem.Services;

namespace HRManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddDbContext<HRDbContext>(options => options.UseSqlite("Data Source=hrmanagement.db"))
                .AddTransient<EmployeeService>()
                .BuildServiceProvider();

            using (var context = serviceProvider.GetService<HRDbContext>())
            {
                context.Database.EnsureCreated();
            }

            var employeeService = serviceProvider.GetService<EmployeeService>();

            var employee1 = new Employee(1, "Zeynep", "Computer Engineering", "C#", 3, "zeynepA", "pass123");

            employeeService.AddEmployee(employee1);
            Console.WriteLine("Employee added successfully.");
        }
    }
}
