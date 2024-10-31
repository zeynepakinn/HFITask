public class Employee
{
    public int Id { get; set; } 
    public string Name { get; set; } 
    public string Qualification { get; set; } 
    public string Skill { get; set; } 
    public int Experience { get; set; } 
    public string LoginId { get; set; } 
    public string Password { get; set; } 

    public Employee(int id, string name, string qualification, string skill, int experience, string loginId, string password)
    {
        Id = id;
        Name = name;
        Qualification = qualification;
        Skill = skill;
        Experience = experience;
        LoginId = loginId;
        Password = password;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Qualification: {Qualification}, Skill: {Skill}, Experience: {Experience} years");
    }
}