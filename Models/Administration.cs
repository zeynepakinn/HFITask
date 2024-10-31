public class Administration
{
    public Employee Employee { get; set; } // Yönetilen Çalışan
    public decimal Salary { get; set; } // Çalışan Maaşı

    public Administration(Employee employee, decimal salary)
    {
        Employee = employee;
        Salary = salary;
    }

    public void HireEmployee(Employee newEmployee)
    {
        Console.WriteLine($"{newEmployee.Name} is hired!");
    }

    public void SetSalary(decimal salary)
    {
        Salary = salary;
        Console.WriteLine($"New salary is set to {Salary}");
    }
}