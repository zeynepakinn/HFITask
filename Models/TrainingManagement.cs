namespace Modules
{
    public class TrainingManagement
    {
        public Employee Employee { get; set; }
        public string TrainingProgram { get; set; }

        public TrainingManagement(Employee employee, string trainingProgram)
        {
            Employee = employee;
            TrainingProgram = trainingProgram;
        }

        public void EnrollInTraining()
        {
            Console.WriteLine($"{Employee.Name} is enrolled in {TrainingProgram} training.");
        }
    }
}