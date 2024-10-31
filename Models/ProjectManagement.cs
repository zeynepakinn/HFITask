using System;
using System.Collections.Generic;

namespace Modules
{
    public class ProjectManagement
    {
        public Employee Employee { get; set; }
        public List<string> Projects { get; set; }

        public ProjectManagement(Employee employee)
        {
            Employee = employee;
            Projects = new List<string>();
        }

        public void AssignProject(string projectName)
        {
            Projects.Add(projectName);
            Console.WriteLine($"{Employee.Name} is assigned to project: {projectName}");
        }

        public void ListProjects()
        {
            Console.WriteLine($"{Employee.Name}'s Projects:");
            foreach (var project in Projects)
            {
                Console.WriteLine($"- {project}");
            }
        }
    }
}