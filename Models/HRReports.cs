using System;
using System.Collections.Generic;

namespace Modules
{
    public class HRReports
    {
        public List<Employee> Employees { get; set; }

        public HRReports()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void GenerateExperienceReport()
        {
            Console.WriteLine("Experience Report:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.Name} has {employee.Experience} years of experience.");
            }
        }

        public void GenerateSkillReport(string skill)
        {
            Console.WriteLine($"Employees with skill: {skill}");
            foreach (var employee in Employees)
            {
                if (employee.Skill == skill)
                {
                    Console.WriteLine($"- {employee.Name}");
                }
            }
        }
    }
}